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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.рецептыTableAdapter.Fill(this.foodDataSet.Рецепты);
            this.продуктыTableAdapter.Fill(this.foodDataSet.продукты);
        }

        private int calculateServingsOfFood(string recipename)
        {
            string[] product = new string[3];
            int[] pr_need = new int[3];
            bool flag = true;
            for (int i = 0; i < dataGridRecipe.Rows.Count - 1; i++)
            {
                if (dataGridRecipe[1, i].Value.ToString() == recipename)
                {
                    flag = false;
                    product[0] = dataGridRecipe[3, i].Value.ToString();
                    product[1] = dataGridRecipe[5, i].Value.ToString();
                    product[2] = dataGridRecipe[7, i].Value.ToString();
                    pr_need[0] = Convert.ToInt32(dataGridRecipe[4, i].Value);
                    pr_need[1] = Convert.ToInt32(dataGridRecipe[6, i].Value);
                    pr_need[2] = Convert.ToInt32(dataGridRecipe[8, i].Value);
                    break;
                }
            }
            if (flag)
            {
                MessageBox.Show("Нет такого блюда");
                return 1;
            }
            int min = -1, temp = 0, pr_have, i_max = 3;
            if (product[2] == "") //подсчет кол-ва ингридиентов
                i_max--;
            if (product[1] == "")
                i_max--;

            for (int u = 0; u < dataGridFood.Rows.Count - 1; u++)
            { //проход по всем строкам левой таблицы
                for (int i = 0; i < i_max; i++)
                { //проход по всем ингридиентам
                    if (dataGridFood[1, u].Value.ToString() == product[i])
                    {
                        pr_have = Convert.ToInt32(dataGridFood[2, u].Value);
                        temp = pr_have / pr_need[i];
                        //если встретился первый ингридиент из рецепта 
                        //или новый меньше предыдущего 
                        if (min == -1 || temp < min)
                            min = temp;
                    }
                }
            }
            return min;
        }

        private void buttonCheckFood_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridRecipe.Rows.Count - 1; i++)
            {
                string re_name = dataGridRecipe[1, i].Value.ToString();
                int answ = calculateServingsOfFood(re_name);
                if (answ == 0) //answ = сколько раз можно приготовить блюдо
                {
                    dataGridRecipe.Rows.RemoveAt(i);
                    i--;
                }
            }
            dataGridRecipe.Refresh();
        }

        public class food_data
        {
            public int[] f_num;
            public string[] f_name;
            public int[] f_category;

            public food_data()
            {
                f_num = new int[20];
                f_name = new string[20];
                f_category = new int[20];
            }
        }

        private void buttonFeed_Click(object sender, EventArgs e)
        {
            food_data food_available = new food_data(); //класс для передачи в FormFeed

            for (int i = 0; i < dataGridRecipe.Rows.Count - 1; i++)
            {
                string re_name = dataGridRecipe[1, i].Value.ToString();
                int answ = calculateServingsOfFood(re_name);
                if (answ > 0) //если блюдо можно приготовить
                {
                    food_available.f_num[i] = answ;
                    food_available.f_name[i] = re_name;

                    if (dataGridRecipe[2, i].Value.ToString() == "первое блюдо")
                        food_available.f_category[i] = 1;
                    else if (dataGridRecipe[2, i].Value.ToString() == "второе блюдо")
                        food_available.f_category[i] = 2;
                    else if (dataGridRecipe[2, i].Value.ToString() == "закуска (салат)")
                        food_available.f_category[i] = 3;
                    else if (dataGridRecipe[2, i].Value.ToString() == "десерт (напиток)")
                        food_available.f_category[i] = 4;
                }
            }
            FormFeed newForm = new FormFeed(food_available);
            newForm.Show();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            string name = textBoxForSort.Text.ToString();
            for (int i = 0; i < dataGridRecipe.Rows.Count - 1; i++)
            {
                if (dataGridRecipe[2, i].Value.ToString() == name) //категория
                    continue;
                if (dataGridRecipe[3, i].Value.ToString() == name) //продукт 1
                    continue;
                if (dataGridRecipe[5, i].Value.ToString() == name) //продукт 2
                    continue;
                if (dataGridRecipe[7, i].Value.ToString() == name) //продукт 3
                    continue;
                dataGridRecipe.Rows.RemoveAt(i);
                i--;
            }
            dataGridRecipe.Refresh();
        }

        private void TSMenuReupload_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void TSMenuSaveProducts_Click(object sender, EventArgs e)
        {
            продуктыBindingSource.EndEdit();
            продуктыTableAdapter.Update(foodDataSet);
            MessageBox.Show("Изменения сохранены");
        }

        private void TSMenuHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Это программа отображает количество имеющихся продуктов и рецептов блюд. " +
                "Вы можете найти нужно блюдо по его категории или содержащемуся продукту, " +
                "введя нужное слово в текстовое поле и нажав на кнопку \"Сортировка " +
                "блюд\". Полученная информация появится в правой таблице. Вы можете " +
                "узнать, что можно приготовить из имеющихся продуктов (которые отображены " +
                "в таблице слева), для этого нажмите на кнопку \"Что можно приготовить?\" " +
                "Эти две кнопки можно комбинировать. Для восстановления рецептов блюд " +
                "нажмите на \"Загрузить БД заново\". Сохранить изменения в левой таблице " +
                "можно с помощью кнопки \"Сохранить изменения в 1-ой таблице\". Кнопка " +
                "\"Составить меню\" позволяет составить меню из отсортированных и доступых рецептов.");
        }
    }
}
