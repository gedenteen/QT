using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
//
using System.IO;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool have_pic = false;
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            ofd.Dispose();
            have_pic = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, bm.Width, bm.Height));
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bm.Save(sfd.FileName);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Dmitry\\Desktop\\программирование\\" +
                "С4_визуальное_программирование\\lab2&3\\forpaint\\empty.png");
            have_pic = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функционал: \n" +
                    "1. Загружать, редактировать, создавать, сохранять изображения; \n" +
                    "2. Рисовать с помощью мыши (При нажатии левой кнопки мыши  и её перемещении " +
                    "отображается кривая движения указателя мыши. При нажатии правой кнопки мыши " +
                    "появляется стирательная резинка. При двойном щелчке - стирается весь рисунок). \n " +
                    "3. Задавать цвет, толщину и стиль линии; Для рисования нужно открыть или создать изображение. \n" +
                    "\n Автор: Разумов Д. \n Группа: ИП-811");
        }

        private bool _dragging = false;
        private System.Drawing.Point _oldLocation;
        private GraphicsPath _currentPath;
        public Color _fgColor = Color.Black;
        public Pen _currentPen = new Pen(Brushes.Black);

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (have_pic == false)
            {
                MessageBox.Show("Для рисования нужно открыть или создать изображение.");
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                _dragging = true;
                _oldLocation = e.Location;
                _currentPath = new GraphicsPath();
                _currentPen.Width = trackBar1.Value;
            }
            if (e.Button == MouseButtons.Right)
            {
                if (pictureBox1.Cursor == Cursors.Default)
                {
                    pictureBox1.Cursor = Cursors.Hand;
                    //_currentPen.Color = _bgColor;
                    _currentPen.Color = Color.White;
                }
                else
                {
                    pictureBox1.Cursor = Cursors.Default;
                    _currentPen.Color = _fgColor;
                }
            }
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            labelXValue.Text = e.X.ToString();
            labelYValue.Text = e.Y.ToString();
            if (_dragging)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                _currentPath.AddLine(_oldLocation, e.Location);
                g.DrawPath(_currentPen, _currentPath);
                _oldLocation = e.Location;
                g.Dispose();
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _dragging = false;
                try
                {
                    _currentPath.Dispose();
                }
                catch { };
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
            g.Dispose();
            pictureBox1.Invalidate();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _fgColor = dlg.Color;
                _currentPen.Color = _fgColor;
            }
            
        }

        private void myColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.ShowDialog();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _currentPen.Width = trackBar1.Value;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        { //1 кнопка тулстрип
            colorToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        { //2 кнопка тулстрип
            newToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        { //3 кнопка тулстрип
            openToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        { //4 кнопка тулстрип
            saveToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        { //5 кнопка тулстрип
            aboutToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        { //6 кнопка тулстрип
            exitToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        { //7 кнопка тулстрип
            myColorToolStripMenuItem_Click(sender, e);
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            undoToolStripMenuItem_Click(sender, e);
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        { //1 тип кисти из подменю
            _currentPen.DashStyle = DashStyle.Solid;
            solidToolStripMenuItem.Checked = true;
            dotToolStripMenuItem.Checked = false;
            dashDotDotToolStripMenuItem.Checked = false;
            dashToolStripMenuItem.Checked = false;
        }

        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        { //2 тип кисти из подменю
            _currentPen.DashStyle = DashStyle.Dot;
            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = true;
            dashDotDotToolStripMenuItem.Checked = false;
            dashToolStripMenuItem.Checked = false;
        }

        private void dashDotDotToolStripMenuItem_Click(object sender, EventArgs e)
        { //3 тип кисти из подменю
            _currentPen.DashStyle = DashStyle.DashDotDot;
            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = false;
            dashDotDotToolStripMenuItem.Checked = true;
            dashToolStripMenuItem.Checked = false;
        }
        private void dashToolStripMenuItem_Click(object sender, EventArgs e)
        { //4 тип кисти из подменю
            _currentPen.DashStyle = DashStyle.Dash;
            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = false;
            dashDotDotToolStripMenuItem.Checked = false;
            dashToolStripMenuItem.Checked = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == comboBox1.Items[0])
            {
                solidToolStripMenuItem_Click(sender, e);
            }
            else if (comboBox1.SelectedItem == comboBox1.Items[1])
            {
                dotToolStripMenuItem_Click(sender, e);
            }
            else if (comboBox1.SelectedItem == comboBox1.Items[2])
            {
                dashDotDotToolStripMenuItem_Click(sender, e);
            }
            else if (comboBox1.SelectedItem == comboBox1.Items[3])
            {
                dashToolStripMenuItem_Click(sender, e);
            }
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            pictureBox1.Name = "pictureBox1";
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Load("http://vb6mania.bawana.net/wp-content/uploads/2011/11/msdn.png");

            panel1.AutoScroll = true;
            panel1.Controls.Add(pictureBox1);
            panel1.Name = "panel1";
            panel1.TabIndex = 8;
            this.Controls.Add(panel1);
        }
    }
}
