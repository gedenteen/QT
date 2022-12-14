using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course
{

    public partial class FormFeed : Form
    {
        public class food_category
        { //класс для обработки label с кол-вом порций
            public int[] f_num;
            public string[] f_name;
            public int f_max;

            public food_category()
            {
                f_num = new int[20];
                f_name = new string[20];
                f_max = 0;
            }
        }
        food_category[] food_c = new food_category[4];

        public FormFeed(Form1.food_data food_available)
        {
            InitializeComponent();
            food_c[0] = new food_category();
            food_c[1] = new food_category();
            food_c[2] = new food_category();
            food_c[3] = new food_category();
            uploadData(food_available);
        }

        public void uploadData(Form1.food_data food_available)
        {
            comboBox1.Items.Add("");
            comboBox2.Items.Add("");
            comboBox3.Items.Add("");
            comboBox4.Items.Add("");
            int[] si = new int[4]; //selected i
            si[0] = si[1] = si[2] = si[3] = 0;
            for (int i = 0; i < 20; i++)
            {
                int sw = food_available.f_category[i];
                switch (sw) //распределение по категориям
                {
                    case 1:
                        comboBox1.Items.Add(food_available.f_name[i]);
                        break;
                    case 2:
                        comboBox2.Items.Add(food_available.f_name[i]);
                        break;
                    case 3:
                        comboBox3.Items.Add(food_available.f_name[i]);
                        break;
                    case 4:
                        comboBox4.Items.Add(food_available.f_name[i]);
                        break;
                    default:
                        break;
                }
                if (sw > 0) //если данные не закончились
                {
                    sw--;
                    food_c[sw].f_name[si[sw]] = food_available.f_name[i];
                    food_c[sw].f_num[si[sw]] = food_available.f_num[i];
                    si[sw]++;
                    food_c[sw].f_max = si[sw];
                }

            }
        }


        private void changeSelectedFood(int num, ComboBox cmbBox, Label lblPortion)
        {
            if (cmbBox.SelectedItem.ToString() == "")
            {
                lblPortion.Text = "0";
                return;
            }
            for (int i = 0; i < food_c[num].f_max; i++)
            {
                if (cmbBox.SelectedItem.ToString() == food_c[num].f_name[i])
                {
                    lblPortion.Text = food_c[num].f_num[i].ToString();
                    break;
                }
            }
            return;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeSelectedFood(0, comboBox1, labelPortion1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeSelectedFood(1, comboBox2, labelPortion2);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeSelectedFood(2, comboBox3, labelPortion3);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeSelectedFood(3, comboBox4, labelPortion4);
        }

        private void buttonFeed_Click(object sender, EventArgs e)
        {
            string str = "Итак, вы выбрали: \n";
            bool first_food = true;
            if (Convert.ToInt32(labelPortion1.Text) > 0)
            {
                if (first_food)
                    first_food = false;
                else
                    str += ", ";
                str += comboBox1.SelectedItem.ToString();
            }
            if (Convert.ToInt32(labelPortion2.Text) > 0)
            {
                if (first_food)
                    first_food = false;
                else
                    str += ", ";
                str += comboBox2.SelectedItem.ToString();
            }
            if (Convert.ToInt32(labelPortion3.Text) > 0)
            {
                if (first_food)
                    first_food = false;
                else
                    str += ", ";
                str += comboBox3.SelectedItem.ToString();
            }
            if (Convert.ToInt32(labelPortion4.Text) > 0)
            {
                if (first_food)
                    first_food = false;
                else
                    str += ", ";
                str += comboBox4.SelectedItem.ToString();
            }
            str += ".";
            MessageBox.Show(str);
        }
    }
}
