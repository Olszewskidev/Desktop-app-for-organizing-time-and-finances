using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelDodajzadanie.Visible = false;
        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            panelDodajzadanie.Visible = true;
        }
        //Void to add tasks to do list. 
        private void button1_Click(object sender, EventArgs e)
        {
          try
            { 

                XDocument xml = XDocument.Load("Tasks.xml");
                var CheckToday = xml.Descendants("zadania").Descendants("zadanie").
                Where(n => (string)n.Attribute("kiedy") == dateTimePicker1.Text).FirstOrDefault();

                if (CheckToday != null)
                 {
                xml.Element("zadania").Elements("zadanie").
                Where(n => (string)n.Attribute("kiedy").Value == dateTimePicker1.Text).FirstOrDefault().
                Add(new XElement("tresc", textBox1.Text + ","));
                xml.Save("Tasks.xml");
                 }

                else
                 {
                xml.Element("zadania").Add(new XElement("zadanie", new XAttribute("kiedy", dateTimePicker1.Text),
                new XElement("tresc", textBox1.Text + ",")));
                xml.Save("Tasks.xml");
                 }
                MessageBox.Show("Dodano zadanie do określonego dnia");
                textBox1.Text = "";
                UpdateDataGridView();
            }

            catch (Exception)
            {
                MessageBox.Show("Nie udało się dodać zadania");
            }
          
        }
        //Void updating data in datagridview
        private void UpdateDataGridView()
        {
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                int TasksID=0;
               XDocument xml = XDocument.Load("Tasks.xml");
               var lista = xml.Descendants("zadanie").Where(x => (string)x.Attribute("kiedy") == dateTimePicker2.Text).
                Select(q => (string)q.Value).ToList();

               if (lista != null)
            {
                string[] ToDoTasks = lista[0].ToString().Split(',');
                foreach (string element in ToDoTasks.Take(ToDoTasks.Length - 1))
                {
                    int licz = dataGridView1.Rows.Add();
                    dataGridView1.Rows[licz].Cells[0].Value = (TasksID + 1).ToString();
                    dataGridView1.Rows[licz].Cells[1].Value = element;
                    TasksID++;
                }
                dataGridView1.Visible = true;
                    label4.Visible = false;
            }
                 else
                {
                    dataGridView1.Visible = false;
                    label4.Visible = true;
                }
             
            }
            catch (Exception)
            {
                MessageBox.Show("Niesty nie udało się wczytać zadań na określony dzień");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
