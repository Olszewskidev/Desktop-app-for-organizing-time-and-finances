using Limilabs.Client.IMAP;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
   public class SavingUserSettinginXML
    {
        private void SaveData(UserSettingInfoModel obj, string filename)
        {
            XmlSerializer serialize = new XmlSerializer(obj.GetType());
            TextWriter writer = new StreamWriter(filename);
            serialize.Serialize(writer, obj);
            writer.Close();
        }
        public bool isValid(UserSettingInfoModel model)
        {
            string emailvalidator = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            return (Regex.IsMatch(model.Adress, emailvalidator) && model.Password != null ? true : false);
        }
        public bool AddDataAndSave(UserSettingInfoModel Us)
        {
            try
            {
                using (Imap imap = new Imap())
                {

                    imap.ConnectSSL("imap.gmail.com");
                    imap.UseBestLogin(Us.Adress, Us.Password);
                    Us.Password=EncryptingPassword(Us.Password);
                    SaveData(Us, "UserSettingInfo.xml");
                    MessageBox.Show("Pomyślnie udało się zalogować do poczty g-mail.");
                    return true;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Dane nie zostały podane poprawnie i nie udało się zalogować do poczty. Upewnij się czy twoja skrzynka korzystanie z protokołu IMAP");
                return false;
            }
        }
        //Void encrypting user password before saving in xml file
        private string EncryptingPassword(string password)
        {
            byte[] encrypted;
            TripleDESCryptoServiceProvider tr = new TripleDESCryptoServiceProvider();
            UTF8Encoding utf = new UTF8Encoding();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            tr.Key = md5.ComputeHash(utf.GetBytes("KamilOlszewski123"));//the key to encrypting its my sweet secret :P
            tr.Mode = CipherMode.ECB;
            tr.Padding = PaddingMode.PKCS7;
            ICryptoTransform trans = tr.CreateEncryptor();
            encrypted = trans.TransformFinalBlock(utf.GetBytes(password), 0, utf.GetBytes(password).Length);
            return BitConverter.ToString(encrypted);
        }
        public bool SaveLocation(string location)
        {
            try
            {
                XDocument xml = System.Xml.Linq.XDocument.Load("UserSettingInfo.xml");
                xml.Element("UserSettingInfoModel").Add(new XElement("Miejscowosc", location));
                xml.Save("UserSettingInfo.xml");
                MessageBox.Show("Udało się dodać twoją lokalizację do aplikacji");
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Nie udało się dodać twojej lokalizacji do aplikacji");
                return false;
            }
        }
    }
}
