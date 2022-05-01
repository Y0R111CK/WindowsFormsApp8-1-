using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView.RowCount = 10;
            dataGridView.ColumnCount = 10;
            int[,] a = new int[10, 10];
            int i, j;
            Random rand = new Random();
            for (i = 0; i < 10; i++)
                for (j = 0; j < 10; j++)
                    a[i, j] = rand.Next(-100, 100);
            for (i = 0; i < 10; i++)
                for (j = 0; j < 10; j++)
                    dataGridView.Rows[i].Cells[j].Value = a[i, j].ToString();
            double s = int.MaxValue;
            for (i = 0; i < 10; i++)
                if (s > 10)
                    s = s + 13.5;
            if (s <= 10)
                s = s * s - 1.5;
            textBox1.Text = Convert.ToString(s);
        }
    }
}
