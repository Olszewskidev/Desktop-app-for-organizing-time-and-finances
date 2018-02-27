using Limilabs.Client.IMAP;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
       private UserSettingInfoModel model = new UserSettingInfoModel();
        private bool PasswordShow = false;
        public Form3()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        //Void checking and adding user data to xml file if data are correct.
        private void button1_Click(object sender, EventArgs e)
        {
            string UserPassword;
            string emailvalidator = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(Adressemail.Text,emailvalidator))
            {
                try
                {
                   
                    model.Adress = Adressemail.Text;
                    UserPassword = PasswordEmail.Text;

                    using (Imap imap = new Imap())
                    {
                       
                            imap.ConnectSSL("imap.gmail.com");
                            imap.UseBestLogin(model.Adress, UserPassword);
                            EncryptingPassword(UserPassword);
                            SavingUserSettinginXML.SaveData(model, "UserSettingInfo.xml");
                            MessageBox.Show("Pomyślnie udało się zalogować do poczty g-mail.");
                            Adressemail.Text = "";
                            PasswordEmail.Text = "";
           
                    }
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Dane nie zostały podane poprawnie i nie udało się zalogować do poczty. Upewnij się czy twoja skrzynka korzystanie z protokołu IMAP");
                }
            }
            else
            {
                errorProvider1.SetError(this.Adressemail, "Uzupełnij to pole poprawnie");
                return;
            }
          
        }
        //Void encrypting user password before saving in xml file
        private void EncryptingPassword(string password)
        {
            byte[] encrypted;
            TripleDESCryptoServiceProvider tr = new TripleDESCryptoServiceProvider();
            UTF8Encoding utf = new UTF8Encoding();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            tr.Key = md5.ComputeHash(utf.GetBytes("************"));//the key to encrypting its my sweet secret :P
            tr.Mode = CipherMode.ECB;
            tr.Padding = PaddingMode.PKCS7;
            ICryptoTransform trans = tr.CreateEncryptor();
            encrypted = trans.TransformFinalBlock(utf.GetBytes(password), 0, utf.GetBytes(password).Length);
            model.Password = BitConverter.ToString(encrypted);
            
        }
        //Void to show and hide the password, when user is adding password in textbox
        private void button3_Click(object sender, EventArgs e)
        {
            if (PasswordShow == false)
            {
                PasswordEmail.UseSystemPasswordChar = false;
                button3.Image = System.Drawing.Image.FromFile(@"C:\Users\Kamil\Desktop\hide.png");
                PasswordShow = true;
            }
            else
            {
                PasswordEmail.UseSystemPasswordChar = true;
                button3.Image = System.Drawing.Image.FromFile(@"C:\Users\Kamil\Desktop\view.png");
                PasswordShow = false;
            }
        }
    }
    }
