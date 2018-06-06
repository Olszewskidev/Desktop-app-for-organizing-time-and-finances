using System;
using System.Windows.Forms;


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
            TaskToDoController TaskControl = new TaskToDoController();
            TaskControl.AddTask(textBox1.Text, dateTimePicker1.Text, ref dataGridView1, ref label4);        
        }
        private void button3_Click(object sender, EventArgs e)
        {
            TaskToDoController TaskControl = new TaskToDoController();
            TaskControl.UpdateDataGridView(ref dataGridView1, ref label4, dateTimePicker2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
