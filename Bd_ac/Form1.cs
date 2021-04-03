using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bd_ac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdDataSet.Bd". При необходимости она может быть перемещена или удалена.
            this.bdTableAdapter.Fill(this.bdDataSet.Bd);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string log = textBox1.Text;
            string pas = textBox2.Text;
            bool log_ch = false;
            bool pas_ch = false;
            int row = -1;

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    if (Convert.ToString(dataGridView1[i,j].Value) == log && i == 0)
                    {
                        log_ch = true;
                        row = j;
                    }

                    if (Convert.ToString(dataGridView1[i, j].Value) == pas && i == 1 && j == row)
                    {
                        pas_ch = true;
                    }
                }
            }

            if (log_ch == true && pas_ch == true)
            {
                MessageBox.Show("success");
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bdTableAdapter.Update(bdDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string log = textBox1.Text;
            string pas = textBox2.Text;
            

        }
    }
}
