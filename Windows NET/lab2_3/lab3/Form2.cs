using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form2 : Form
    {
        Color c;

        public Form2()
        {
            InitializeComponent();
            hsbRed.Tag = nudRed;
            hsbGreen.Tag = nudGreen;
            hsbBlue.Tag = nudBlue;

            nudRed.Tag = hsbRed;
            nudGreen.Tag = hsbGreen;
            nudBlue.Tag = hsbBlue;
        }

        private void UpdateColor()
        {
            c = Color.FromArgb(hsbRed.Value, hsbGreen.Value, hsbBlue.Value);
            panel1.BackColor = c;
        }

        private void hsbRed_ValueChanged(object sender, EventArgs e)
        {
            UpdateColor();
            nudRed.Value = hsbRed.Value;
        }

        private void hsbGreen_ValueChanged(object sender, EventArgs e)
        {
            UpdateColor();
            nudGreen.Value = hsbGreen.Value;
        }

        private void hsbBlue_ValueChanged(object sender, EventArgs e)
        {
            UpdateColor();
            nudBlue.Value = hsbBlue.Value;
        }

        private void nudRed_ValueChanged(object sender, EventArgs e)
        {
            UpdateColor();
            hsbRed.Value = Decimal.ToInt32(nudRed.Value);
        }

        private void nudGreen_ValueChanged(object sender, EventArgs e)
        {
            UpdateColor();
            hsbGreen.Value = Decimal.ToInt32(nudGreen.Value);
        }

        private void nudBlue_ValueChanged(object sender, EventArgs e)
        {
            UpdateColor();
            hsbBlue.Value = Decimal.ToInt32(nudBlue.Value);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                main._fgColor = c;
                main._currentPen.Color = c;
            }
            this.Close();
        }

        void Start()
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                c = main._fgColor;
                panel1.BackColor = main._fgColor;
                nudRed.Value = c.R;
                c = main._fgColor;
                nudGreen.Value = c.G;
                c = main._fgColor;
                nudBlue.Value = c.B;
            }
        }
        private void panel1_Layout(object sender, LayoutEventArgs e)
        {
            Start();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Start();
        }

        
    }
}
