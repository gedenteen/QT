using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace lab5
{
    public partial class Form1 : Form
    {
        char[] bmp_info = new char[6] {'R', 'y', 'C', 'r', 'S', 'b'};
        //Rectangle yellow, Circle red, Square blue

        public Form1()
        {
            InitializeComponent();
            drawFigure(pictureBox1, bmp_info[0], bmp_info[1]);
            drawFigure(pictureBox2, bmp_info[2], bmp_info[3]);
            drawFigure(pictureBox3, bmp_info[4], bmp_info[5]);
        }

        private void drawFigure(PictureBox picbox, char figure, char color)
        {
            Bitmap bmp = new Bitmap(picbox.Width, picbox.Height);
            Brush brush = Brushes.White;
            switch (color)
            {
                case 'y':
                    brush = Brushes.Gold;
                    break;
                case 'r':
                    brush = Brushes.Red;
                    break;
                case 'b':
                    brush = Brushes.Blue;
                    break;
                default:
                    MessageBox.Show("Ошибка, неправильно передана инф-ия о цвете фигуры");
                    break;
            }
            using (Graphics g = Graphics.FromImage(bmp))
            {
                /// Рисование на белом фоне. Делаем заливку белым цветом
                g.Clear(Color.White);
                Pen pen = new Pen(brush, 8);
                switch (figure)
                {
                    case 'R':
                        pen.LineJoin = LineJoin.Bevel;//задаем скошенные углы
                        pen.MiterLimit = 8;//задаем ограничение толщины скошенных углов
                        g.DrawRectangle(pen, new Rectangle(4, 4, picbox.Width - 8, picbox.Height - 48));
                        g.FillRectangle(brush, new Rectangle(4, 4, picbox.Width - 8, picbox.Height - 48));
                        break;
                    case 'C':
                        g.DrawEllipse(pen, new Rectangle(3, 3, picbox.Width - 8, picbox.Height - 8));
                        g.FillEllipse(brush, new Rectangle(3, 3, picbox.Width - 8, picbox.Height - 8));
                        break;
                    case 'S':
                        g.DrawRectangle(pen, new Rectangle(4, 4, picbox.Width - 8, picbox.Height - 8));
                        g.FillRectangle(brush, new Rectangle(4, 4, picbox.Width - 8, picbox.Height - 8));
                        break;
                }
            }
            /// Назначаем наш Bitmap свойству Image
            picbox.Image = bmp;
        }

        private int x = 0, y = 0;

        private void generalMouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void generalMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // или любую другую, какая удобнее
            {
                Point pos = new Point(Cursor.Position.X - x, Cursor.Position.Y - y);
                //button1.Location = PointToClient(pos);
                (sender as PictureBox).Location = PointToClient(pos);
            }
        }

        private void generalMouseUp(object sender, MouseEventArgs e, int num)
        {
            int sendX1 = (sender as PictureBox).Location.X;
            int sendY1 = (sender as PictureBox).Location.Y;
            int sendX2 = sendX1 + (sender as PictureBox).Size.Width;
            int sendY2 = sendY1 + (sender as PictureBox).Size.Height;
            int labelX1 = label1.Location.X;
            int labelY1 = label1.Location.Y;
            int labelX2 = labelX1 + label1.Size.Width;
            int labelY2 = labelY1 + label1.Size.Height;
            char figure = bmp_info[num * 2];
            char color = bmp_info[num * 2 + 1];
            if (labelX1 <= sendX1 && labelY1 <= sendY1 && labelX2 >= sendX2 && labelY2 >= sendY2)
            {
                switch (figure)
                {
                    case 'R':
                        label3.Text = "Форма фигуры: прямоугольник";
                        break;
                    case 'C':
                        label3.Text = "Форма фигуры: круг";
                        break;
                    case 'S':
                        label3.Text = "Форма фигуры: квадрат";
                        break;
                    default:
                        MessageBox.Show("Ошибка, неправильно передана инф-ия о форме фигуры");
                        break;
                }
                switch (color)
                {
                    case 'y':
                        label3.Text += "\nЦвет фигуры: желтый";
                        break;
                    case 'r':
                        label3.Text += "\nЦвет фигуры: красный";
                        break;
                    case 'b':
                        label3.Text += "\nЦвет фигуры: синий";
                        break;
                    default:
                        MessageBox.Show("Ошибка, неправильно передана инф-ия о цвете фигуры");
                        break;
                }
            }
            labelX1 = label2.Location.X;
            labelY1 = label2.Location.Y;
            labelX2 = labelX1 + label2.Size.Width;
            labelY2 = labelY1 + label2.Size.Height;
            if (labelX1 <= sendX1 && labelY1 <= sendY1 && labelX2 >= sendX2 && labelY2 >= sendY2)
            {
                switch (figure)
                {
                    case 'R':
                        bmp_info[num * 2] = figure = 'C';
                        break;
                    case 'C':
                        bmp_info[num * 2] = figure = 'S';
                        break;
                    case 'S':
                        bmp_info[num * 2] = figure = 'R';
                        break;
                    default:
                        MessageBox.Show("Ошибка, неправильно передана инф-ия о форме фигуры");
                        break;
                }
                drawFigure((sender as PictureBox), figure, color);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            generalMouseDown(sender, e);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            generalMouseMove(sender, e);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            generalMouseUp(sender, e, 0);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            generalMouseDown(sender, e);
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            generalMouseMove(sender, e);
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            generalMouseUp(sender, e, 1);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            generalMouseDown(sender, e);       
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            generalMouseMove(sender, e);
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            generalMouseUp(sender, e, 2);
        }

    }
}
