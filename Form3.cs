using System;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        SavingUserSettinginXML XMLController = new SavingUserSettinginXML();
        private bool PasswordShow;

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
            UserSettingInfoModel UserInput = new UserSettingInfoModel();
            UserInput.Adress = Adressemail.Text;
            UserInput.Password = PasswordEmail.Text;
            if (XMLController.isValid(UserInput))
            {
                if (XMLController.AddDataAndSave(UserInput))
                {
                    Adressemail.Text = "";
                    PasswordEmail.Text = "";
                    panel1.Visible = false;
                    panel2.Visible = true;
                }
            }
            else
            {
                errorProvider1.SetError(this.Adressemail, "Uzupełnij to pole poprawnie");
                return;
            }
          
        }
    
        //Void to show and hide the password, when user is adding password in textbox
        private void button3_Click(object sender, EventArgs e)
        {
            if (PasswordShow == false)
            {
                PasswordEmail.UseSystemPasswordChar = false;
                button3.Image = Image.FromFile(@"C:\Users\Kamil\Desktop\hide.png");
                PasswordShow = true;
            }
            else
            {
                PasswordEmail.UseSystemPasswordChar = true;
                button3.Image = Image.FromFile(@"C:\Users\Kamil\Desktop\view.png");
                PasswordShow = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(XMLController.SaveLocation(cityname.Text))
                this.Visible = false;   
        }
    }
    }
