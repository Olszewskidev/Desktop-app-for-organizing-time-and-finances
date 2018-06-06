using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {

        SallaryController SallarControl;
        public Form2()
        {
            InitializeComponent();
            panel3.Visible = false;
            this.CenterToScreen();
            SallarControl = new SallaryController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com/");
        }

        //Void read the our last sallary value and makes mathematics calculations for the saving money model 
        private void button2_Click(object sender, EventArgs e)
        {
            board1.Controls.Add(ppointer);
            ppointer.Height = button2.Height;
            ppointer.Top = button2.Top;
            PanelActionDodaj.Visible = false;
            panel4.Visible = false;
            panel3.Visible = true;
            this.Controls.Add(panel3);
            panel3.Location = new Point(250, 78);
            panel3.Size = new Size(400, 322);
            if (File.Exists("Sallary.xml"))
            {
                    opstalebar.Text = SallarControl.Sallary55percentage();
                    przyjbar.Text = SallarControl.Sallary10percentage();
                    edubar.Text = SallarControl.Sallary10percentage();
                    wiekszezakbar.Text = SallarControl.Sallary10percentage();
                    inwestycjebar.Text = SallarControl.Sallary10percentage();
                    dlainnychbar.Text = SallarControl.Sallary05percentage();
                    OszczLabel.Text = "Metoda 6 słoików ";
                    OszczLabel.Visible = true;
                    label3.Text = "Twoja wypłata:" + SallarControl.FullSallary();
                    label3.Visible = true;
            }
            else
            {
                MessageBox.Show("Skonfigurujesz tę opcję po dodaniu wypłat");
            }
        }
        //Void to read the data from xml file using LINQ and add this to the datagridview source
        private void button3_Click(object sender, EventArgs e)
        {

            if (File.Exists("Sallary.xml"))
                SallarControl.UpdateDataGrid(ref dataGridView1);
            else
                MessageBox.Show("Skonfigurujesz tę opcję po dodaniu wypłat");
            
            board1.Controls.Add(ppointer);
            ppointer.Height = button3.Height;
            ppointer.Top = button3.Top;
            panel3.Visible = false;
            PanelActionDodaj.Visible = false;
            label3.Visible = false;
            panel4.Visible = true;
            OszczLabel.Text = "Spis wypłat: ";
            OszczLabel.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            board1.Controls.Add(ppointer);
            ppointer.Height = button4.Height;
            ppointer.Top = button4.Top;
            label3.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            OszczLabel.Text = "Dodaj informacje:";
            OszczLabel.Visible = true;
            PanelActionDodaj.Visible = true;
            this.Controls.Add(PanelActionDodaj);
            PanelActionDodaj.Location = new Point(250, 78);
            PanelActionDodaj.Size = new Size(400, 322);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        //Void adding sallary value to the xml.file
        private void DodajWyplate_Click_1(object sender, EventArgs e)
        {
            SallarControl.AddMySallary(wyplatadata.Text, Wyplatawys.Text);
            Wyplatawys.Text = "";
        }
    }
}
