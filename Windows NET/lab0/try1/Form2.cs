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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                int n = Convert.ToInt32(textBoxN.Value);
                int m = Convert.ToInt32(textBoxM.Value);
                if (n>0 & m>0)
                {

                    main.textBoxN.Value = Convert.ToInt32(n);
                    main.textBoxM.Value = Convert.ToInt32(m);
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите корректные значения");
                }
            }
            this.Close();
        }
    }
}
