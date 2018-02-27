using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
 
        public Form2()
        {
            InitializeComponent();
            panel3.Visible = false;
            this.CenterToScreen();
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
                try
                {
                    float PerValue;
                    XDocument file = XDocument.Load("Sallary.xml");
                    XElement root = file.Root;
                    var lastsallary = root.Elements("kasa").Elements("wysokosc").Last().Value;
                    float LastSallaryValue = float.Parse(lastsallary.ToString());
                    PerValue=LastSallaryValue*0.55f;
                    opstalebar.Text = PerValue.ToString();
                    PerValue = LastSallaryValue * 0.1f;
                    przyjbar.Text = PerValue.ToString();
                    edubar.Text = PerValue.ToString();
                    wiekszezakbar.Text = PerValue.ToString();
                    inwestycjebar.Text = PerValue.ToString();
                    PerValue = LastSallaryValue * 0.05f;
                    dlainnychbar.Text = PerValue.ToString();
                    OszczLabel.Text = "Metoda 6 słoików ";
                    OszczLabel.Visible = true;
                    label3.Text ="Twoja wypłata:"+ LastSallaryValue.ToString();
                    label3.Visible = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie udało się pobrać danych");
                }
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
            {
                try
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    XDocument file = XDocument.Load("Sallary.xml");
                    var sall = from sal in file.Element("wyplata").Elements("kasa")
                               select sal.Attribute("za").Value;
                    var money = from sal in file.Element("wyplata").Elements("kasa")
                                select sal.Element("wysokosc").Value;
                    int rows = sall.Count();
                    foreach (var date in sall)
                    {
                        int licz = dataGridView1.Rows.Add();
                        dataGridView1.Rows[licz].Cells[0].Value = date.ToString();
                       
                    }
                    foreach (var date in money)
                    {

                        int licz = dataGridView1.Rows.Add() - rows;
                        dataGridView1.Rows[licz].Cells[1].Value = date.ToString();

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie udało się pobrać danych");
                }


            }
            else
            {
                MessageBox.Show("Skonfigurujesz tę opcję po dodaniu wypłat");
            }

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
            try
            {
                XDocument xml = System.Xml.Linq.XDocument.Load("Sallary.xml");
                var CheckToday = xml.Descendants("wyplata").Descendants("kasa").
                Where(n => (string)n.Attribute("za") == wyplatadata.Text).FirstOrDefault();

                if (CheckToday != null)
                {
                    xml.Element("wyplata").Elements("kasa").
                    Where(n => (string)n.Attribute("za").Value == wyplatadata.Text).FirstOrDefault().
                    SetElementValue("wysokosc", Wyplatawys.Text);
                    xml.Save("Sallary.xml");
                }

                else
                {
                    xml.Element("wyplata").Add(new XElement("kasa", new XAttribute("za", wyplatadata.Text),
                    new XElement("wysokosc", Wyplatawys.Text)));
                    xml.Save("Sallary.xml");
                }
                MessageBox.Show("Dodano wypłatę do bazy");
                Wyplatawys.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Nie udało się wprowadzić twojej wypłaty do bazy");
            }
        }
    }
}
