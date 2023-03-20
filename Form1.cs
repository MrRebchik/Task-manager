using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TaskManager
{
    public partial class TaskManager : Form
    {
        


        public TaskManager()
        {
            InitializeComponent();
           
        }
        


        Label aboba = new Label();
        string Vvod="0";
        //int TotalNum = 0;
        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            while (DataBank.Check) {
                Label boba = new Label();
                boba.Text = DataBank.TempText;
                tableLayoutPanel1.Controls.Add(boba, DataBank.TotalNum, 1);
            }

            /*Label boba = new Label();
            boba.Text = "boo";
            tableLayoutPanel1.Controls.Add(boba, TotalNum, 1);
            Label aboba = new Label();
            aboba.Text = $"sfgs+{Vvod}";
            tableLayoutPanel1.Controls.Add(aboba);
            */
            

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Scroll(object sender, ScrollEventArgs e)
        {
            //скролинг таблицы
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DataBank.ArrTask.Add(new DataBank.SomeTask(DataBank.TotalNum,));
            
            AddingNewRow newForm = new AddingNewRow(this);
            newForm.Show();

        }

        public void NewRow() {
            
            DataBank.TotalNum++;
            tableLayoutPanel1.RowStyles.Add(new RowStyle() { Height = 50, SizeType = SizeType.Absolute });
            tableLayoutPanel1.RowCount++;
            

        }
        public void InsertToRow()
        {
            Label boba = new Label();
            boba.Text = DataBank.TempText;
            tableLayoutPanel1.Controls.Add(boba, DataBank.TotalNum, 1);
            
        }
    }
}
