using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                string textToAdd = textBox1.Text;
                if (checkBox1.Checked)
                {
                    main.listBox1.Items.Add(textToAdd);
                }

                if (checkBox2.Checked)
                {
                    main.listBox2.Items.Add(textToAdd);
                }
            }
            this.Close();
            
                /*......
                switch (dlg.Section)
                {
                    case 1: lstSection1.Items.Add(dlg.UserInput); break;
                    case 2: lstSection2.Items.Add(dlg.UserInput); break;
                    default: break;
                }*/
            //}
        }
    }
}
