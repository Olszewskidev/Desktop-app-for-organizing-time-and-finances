using Limilabs.Client.IMAP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    class GetDataFromWebsite
    {
        private string temperatureInMyCity { get; set; }
        private string emailNumber { get; set; }

        public string EmailsCount()
        {
            GetNewEmails();
            return emailNumber;
        }

        public string Temperature()
        {
            WeatherforMyLocation();
            return temperatureInMyCity;
        }

        private void GetNewEmails()
        {
            if (File.Exists("UserSettingInfo.xml"))
            {
                UserSettingInfoModel us = new UserSettingInfoModel();
                XmlSerializer XmlSerial = new XmlSerializer(typeof(UserSettingInfoModel));
                FileStream read = new FileStream("UserSettingInfo.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                us = (UserSettingInfoModel)XmlSerial.Deserialize(read);
                string userAdress = us.Adress;
                string userPassword = DecryptingPassword(us.Password); ;
                
                using (Imap imap = new Imap())
                {
                    try
                    {
                        imap.ConnectSSL("imap.gmail.com");
                        imap.UseBestLogin(userAdress, userPassword);
                        imap.SelectInbox();
                        List<long> uids = imap.Search(Flag.Unseen);
                        int newmessages = uids.Count;
                        emailNumber = newmessages.ToString();
                        imap.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Wystąpiły problemy podczas logowania do skrzynki g-mail. Upewnij się, że jesteś połączony z siecią internetową.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Musisz skonfigurować swoje dane dotyczące adresu e-mail oraz lokalizację");
                emailNumber = "?";
            }
               
            

        }
        //Decrypt the password from xml file to the real password string
        private string DecryptingPassword(string password)
        {
            TripleDESCryptoServiceProvider tr = new TripleDESCryptoServiceProvider();
            ICryptoTransform toArray = tr.CreateEncryptor();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding utf = new UTF8Encoding();
            tr.Key = md5.ComputeHash(utf.GetBytes("******************"));//the key is my sweet secret :P
            tr.Mode = CipherMode.ECB;
            tr.Padding = PaddingMode.PKCS7;
            ICryptoTransform trans = tr.CreateDecryptor();
            byte[] data = password.Split('-').Select(b => Convert.ToByte(b, 16)).ToArray();
            return utf.GetString(trans.TransformFinalBlock(data, 0, data.Length));
        }
        //Getting info from website about weather in our location
        private async void WeatherforMyLocation()
        {
            try
            {
                XDocument xml = System.Xml.Linq.XDocument.Load("UserSettingInfo.xml");
                string cityname = xml.Descendants("Miejscowosc").FirstOrDefault().FirstNode.ToString();
                if (cityname.Contains(" ") == true)// checing if our location is one part string name city or two part string name
                    cityname = cityname.Replace(" ", "-");
                string urllink = "http://www.pogodynka.pl/polska/" + cityname + "_" + cityname; //crating special url link to get to the website for our location
                var httpClient = new HttpClient();
                var frompage = await httpClient.GetStringAsync(urllink);

                var htmlDoc = new HtmlAgilityPack.HtmlDocument();
                htmlDoc.LoadHtml(frompage);
                var data = htmlDoc.DocumentNode.Descendants("div").
                            Where(n => n.GetAttributeValue("class", "").Equals("autodin")).ToList();
                string temperature = data[0].Descendants("b").Where(m => m.InnerText.Contains("&#176;C")).FirstOrDefault().InnerText;
                temperatureInMyCity = temperature.Replace("&#176;C", "°C");
            }
            catch (Exception)
            {
                MessageBox.Show("Niestety nie udało się pobrać danych pogodowych");
                temperatureInMyCity = "?";
            }

        }
    }
}
