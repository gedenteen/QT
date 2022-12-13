using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace try1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        int n, m;
        private void buttonStart_Click(object sender, EventArgs e)
        {
            
            n = Convert.ToInt32(textBoxN.Value);
            m = Convert.ToInt32(textBoxM.Value);
            Random rand = new Random();
            if (n > 0 & m > 0)
            {
                dataGridView1.RowCount = n;
                dataGridView1.ColumnCount = m;
                int[,] mas = new int[n, m];
                int i, j;
                for (i = 0; i < n; ++i)
                    for (j = 0; j < m; ++j)
                    {
                        mas[i, j] = rand.Next(100);
                        dataGridView1.Rows[i].Cells[j].Value = mas[i, j];
                    }
                for (j = 0; j < m; ++j)
                {
                    dataGridView1.Columns[j].Width = 50; //меняю ширину столбцов
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные значения");
            }
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            int[] mas = new int[n];
            int max, i, j;
            if (n <=0 | m <= 0)
            {
                return;
            }
            for (i = 0; i < n; ++i)
            {
                mas[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                for (j = 0; j < m; ++j)
                {
                    max = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                    if (max > mas[i])
                        mas[i] = max;
                }
            }
            dataGridView2.RowCount = n;
            dataGridView2.ColumnCount = 1;
            for (i = 0; i < n; ++i)
            {
                dataGridView2.Rows[i].Cells[0].Value = mas[i];
            }
            dataGridView2.Columns[0].Width = 50;
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e) //кнопка меню старт
        {
            buttonStart_Click(sender, e); 
        }

        private void toolStripMenuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ФИО: Разумов Д. Б.\nГруппа: ИП-811");
        }

        private void toolStripMenuSize_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.ShowDialog();
        }

        private void toolStripMenuMax_Click(object sender, EventArgs e)
        {
            buttonMax_Click(sender, e);
        } 

    }
}
