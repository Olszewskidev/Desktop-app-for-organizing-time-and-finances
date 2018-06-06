using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApplication1
{
    class SallaryController
    {
        float LastSallary;
        XDocument file = new XDocument();
        public SallaryController()
        {
            CheckIfFileExist();
        }
        private void CheckIfFileExist()
        {
            if (File.Exists("Sallary.xml"))
            {
                file = XDocument.Load("Sallary.xml");
                XElement root = file.Root;
                var lastsallary = root.Elements("kasa").Elements("wysokosc").Last().Value;
                LastSallary = float.Parse(lastsallary.ToString());
            }
        }
        public string Sallary55percentage()
        {
            float percentage= LastSallary*0.55f;
            return percentage.ToString();
        }
        public string Sallary10percentage()
        {
            float percentage = LastSallary * 0.1f;
            return percentage.ToString();
        }
        public string Sallary05percentage()
        {
            float percentage = LastSallary * 0.05f;
            return percentage.ToString();
        }
        public string FullSallary()
        {
            return LastSallary.ToString();
        }
        public void UpdateDataGrid(ref DataGridView DGV)
        {
            try
            {
                DGV.Rows.Clear();
                DGV.Refresh();
                var sall = from sal in file.Element("wyplata").Elements("kasa")
                           select sal.Attribute("za").Value;
                var money = from sal in file.Element("wyplata").Elements("kasa")
                            select sal.Element("wysokosc").Value;
                int rows = sall.Count();
                foreach (var date in sall)
                {
                    int licz = DGV.Rows.Add();
                    DGV.Rows[licz].Cells[0].Value = date.ToString();

                }
                foreach (var date in money)
                {
                    int licz = DGV.Rows.Add() - rows;
                    DGV.Rows[licz].Cells[1].Value = date.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nie udało się pobrać danych");
            }
        }
        public void AddMySallary(string SallaryForMonth, string SallaryValue)
        {
            try
            {
                var CheckToday = file.Descendants("wyplata").Descendants("kasa").
                Where(n => (string)n.Attribute("za") == SallaryForMonth).FirstOrDefault();

                if (CheckToday != null)
                {
                    file.Element("wyplata").Elements("kasa").
                    Where(n => (string)n.Attribute("za").Value == SallaryForMonth).FirstOrDefault().
                    SetElementValue("wysokosc", SallaryValue);
                    file.Save("Sallary.xml");
                }

                else
                {
                    file.Element("wyplata").Add(new XElement("kasa", new XAttribute("za", SallaryForMonth),
                    new XElement("wysokosc", SallaryValue)));
                    file.Save("Sallary.xml");
                }
                MessageBox.Show("Dodano wypłatę do bazy");
            }
            catch (Exception)
            {
                MessageBox.Show("Nie udało się wprowadzić twojej wypłaty do bazy");
            }
        }
    }
}
