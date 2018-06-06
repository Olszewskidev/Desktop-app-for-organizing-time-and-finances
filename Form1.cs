using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Form2 f2 = new Form2();
        private bool form4;
        private Form3 f3 = new Form3();
        private Form4 f4 = new Form4();
        private bool formfin;
        private bool showform3;
        public Form1()
        {
            InitializeComponent();
            SetFormProp();
            UpDataPanel();
        }
        private void SetFormProp()
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right + 60 - Size.Width, workingArea.Bottom - 140 - Size.Height);
            this.Size = new System.Drawing.Size(80, 500);
        }
        private void UpDataPanel()
        {
            GetDataFromWebsite Data = new GetDataFromWebsite();
            label1.Text = Data.EmailsCount();
            LabelTemp.Text = Data.Temperature();
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
            UpDataPanel();
        }
    }
}
