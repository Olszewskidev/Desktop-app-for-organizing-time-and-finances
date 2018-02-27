using System;
using Limilabs.Client.IMAP;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Security.Cryptography;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Form2 f2 = new Form2();
        private bool form4 = false;
        private Form3 f3 = new Form3();
        private Form4 f4 = new Form4();
        private bool formfin = false;
        private bool showform3 = false;
        private string userAdress;
        private string userPassword;
        UserSettingInfoModel us;

        public Form1()
        {
            InitializeComponent();
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right+60 - Size.Width,workingArea.Bottom-140 - Size.Height);
            this.Size=  new System.Drawing.Size(80, 400);
            GetNewEmails();
        }

        //Void to get our unsee email count by the login in to gmail acount using Limilabs
        private void GetNewEmails()
        {
            if (File.Exists("UserSettingInfo.xml"))
            {
                us = new UserSettingInfoModel();
                XmlSerializer XmlSerial = new XmlSerializer(typeof(UserSettingInfoModel));
                FileStream read = new FileStream("UserSettingInfo.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                us = (UserSettingInfoModel)XmlSerial.Deserialize(read);
                userAdress = us.Adress;
                userPassword = us.Password;
                DecryptingPassword(userPassword);
            
            using (Imap imap = new Imap())
            {
                    try { 
                    imap.ConnectSSL("imap.gmail.com");
                    imap.UseBestLogin(userAdress, userPassword);
                    imap.SelectInbox();
                    List<long> uids = imap.Search(Flag.Unseen);
                    int newmessages = uids.Count;
                    label1.Text = newmessages.ToString();
                    imap.Close();
                    }
                    catch(Exception )
                    {
                        MessageBox.Show("Wystąpiły problemy podczas logowania do skrzynki g-mail. Upewnij się, że jesteś połączony z siecią internetową.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Musisz skonfigurować dostęp do skrzynki w ustawieniach aplikacji");
            }

        }
        //Decrypt the password from xml file to the real password string
        private void DecryptingPassword(string password)
        {
            TripleDESCryptoServiceProvider tr = new TripleDESCryptoServiceProvider();
            ICryptoTransform toArray = tr.CreateEncryptor();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding utf = new UTF8Encoding();
            tr.Key = md5.ComputeHash(utf.GetBytes("************"));//the key is my sweet secret :P
            tr.Mode = CipherMode.ECB;
            tr.Padding = PaddingMode.PKCS7;
            ICryptoTransform trans = tr.CreateDecryptor();
            byte[] data = password.Split('-').Select(b => Convert.ToByte(b, 16)).ToArray();
            userPassword = utf.GetString(trans.TransformFinalBlock(data, 0, data.Length));
        }

        private void exitpanel_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }
        //Button to show finance form
        private void Finanse_Click(object sender, EventArgs e)
        {
            if (formfin == false)
            {
                f2.board1.Visible = true;
                f2.Show();
                formfin = true;
            }
            else
            {
                f2.Visible = false;
                formfin = false;
            }
                
        }
        //Button go to g-mail.com
        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com/");
      
        }
        //Button to form with user config
        private void button2_Click(object sender, EventArgs e)
        {
            if (showform3 == false)
            {
                f3.Visible = true;
                showform3 = true;
            }
            else
            {
                f3.Visible = false;
                showform3 = false;

            }
        }
        //Button to form with Tasks To Do
        private void Zadania_Click(object sender, EventArgs e)
        {
            if (form4 == false)
            {
                f4.Visible = true;
                form4 = true;
            }
            else
                f4.Visible = false;
        }

        //Refresh button 
        private void button2_Click_1(object sender, EventArgs e)
        {
            GetNewEmails();
        }
    }
}
