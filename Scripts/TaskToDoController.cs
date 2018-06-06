using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApplication1
{
    class TaskToDoController
    {
        public void AddTask(string TaskToDo, string DataTime, ref DataGridView DGV, ref Label lb)
        {
            try
            {
                XDocument xml = XDocument.Load("Tasks.xml");
                var CheckToday = xml.Descendants("zadania").Descendants("zadanie").
                Where(n => (string)n.Attribute("kiedy") == DataTime).FirstOrDefault();

                if (CheckToday != null)
                {
                    xml.Element("zadania").Elements("zadanie").
                    Where(n => (string)n.Attribute("kiedy").Value == DataTime).FirstOrDefault().
                    Add(new XElement("tresc", TaskToDo + ","));
                    xml.Save("Tasks.xml");
                }

                else
                {
                    xml.Element("zadania").Add(new XElement("zadanie", new XAttribute("kiedy", DataTime),
                    new XElement("tresc", TaskToDo + ",")));
                    xml.Save("Tasks.xml");
                }
                MessageBox.Show("Dodano zadanie do określonego dnia");
                UpdateDataGridView(ref DGV, ref lb, DataTime);
            }

            catch (Exception)
            {
                MessageBox.Show("Nie udało się dodać zadania");
            }
        }
        public void UpdateDataGridView(ref DataGridView DGV, ref Label  lb, string When)
        {
            try
            {
                DGV.Rows.Clear();
                DGV.Refresh();
                int TasksID = 0;
                XDocument xml = XDocument.Load("Tasks.xml");
                var lista = xml.Descendants("zadanie").
                                Where(x => (string)x.
                                    Attribute("kiedy") == When).
                                         Select(q => (string)q.Value).ToList();
                if (lista != null)
                {
                    string[] ToDoTasks = lista[0].ToString().Split(',');
                    foreach (string element in ToDoTasks.Take(ToDoTasks.Length - 1))
                    {
                        int licz = DGV.Rows.Add();
                        DGV.Rows[licz].Cells[0].Value = (TasksID + 1).ToString();
                        DGV.Rows[licz].Cells[1].Value = element;
                        TasksID++;
                    }
                    DGV.Visible = true;
                    lb.Visible = false;
                }
                else
                {
                    DGV.Visible = false;
                    lb.Visible = true;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Niesty nie udało się wczytać zadań na określony dzień");
            }


        }
    }
}
