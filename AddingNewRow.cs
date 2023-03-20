using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class AddingNewRow : Form
    {
        public string CurrentTask;

        public AddingNewRow()
        {
            InitializeComponent();
        }
        public AddingNewRow(TaskManager f)   //конструктор
        {
            InitializeComponent();
            f.NewRow();
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataBank.TempText = CurrentTask;
            DataBank.Check = true;
            //DataBank.ArrTask[DataBank.TotalNum];
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CurrentTask = textBox1.Text;
            DataBank.Task[DataBank.TotalNum] = CurrentTask; 

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
