using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
//
using System.IO;

namespace lab2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }
        /*void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            MessageBox.Show(selectedState);
        }*/

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(dlg.FileName, Encoding.Default);
                textBoxForOpen.Text = reader.ReadToEnd();
                reader.Close();
            }

            dlg.Dispose();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    writer.WriteLine((string)listBox2.Items[i]);
                }
                writer.Close();
            }

            dlg.Dispose();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ФИО: Разумов Д. Б.\nГруппа: ИП-811");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textBoxForOpen.Clear();
            textBoxSearch.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            //comboBox1.Text.;
            checkBoxSection1.Checked = false;
            checkBoxSection2.Checked = false;
            radioButtonAll.Checked = true;
            listBox3.Items.Clear();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox1.BeginUpdate();
            string[] strings = textBoxForOpen.Text.Split(new char[] { '\n', '\t', ' ' }, 
                StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in strings)
            {
                string str = s.Trim();
                if (str == String.Empty)
                    continue;
                if (radioButtonAll.Checked)
                {
                    listBox1.Items.Add(str);
                }
                if (radioButtonNumbers.Checked)
                {
                    if (Regex.IsMatch(str, @"\d"))
                        listBox1.Items.Add(str);
                }
                if (radioButtonEmail.Checked)
                {
                    if (Regex.IsMatch(str, @"\w+@\w+\.\w+"))
                        listBox1.Items.Add(str);
                }

            }
            listBox1.EndUpdate();
        }

        private void DeleteSelectedItems(ListBox lst)
        {
            lst.BeginUpdate();
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lst);
            selectedItems = lst.SelectedItems;
            if (lst.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    lst.Items.Remove(selectedItems[i]);
            }
            //else
                //MessageBox.Show("Ошибка. Кажется, вы сделали что-то не так.");
            lst.EndUpdate();
        }

        private void MoveSelectedItems(ListBox lstFrom, ListBox lstTo) //не кнопка
        {
            lstTo.BeginUpdate();
            //lstFrom.BeginUpdate();
            foreach (object item in lstFrom.SelectedItems)
            {
                lstTo.Items.Add(item);
                //lstFrom.Items.Remove(item);
            }
            lstTo.EndUpdate();

            DeleteSelectedItems(lstFrom);
        }
        private void MoveAllItems(ListBox lstFrom, ListBox lstTo) //не кнопка
        {
            lstTo.Items.AddRange(lstFrom.Items);
            lstFrom.Items.Clear();
        }

        private void buttonMoveSomeToright_Click(object sender, EventArgs e) //кнопка
        {
            MoveSelectedItems(listBox1, listBox2);
        }

        private void buttonMoveSomeToleft_Click(object sender, EventArgs e) //кнопка
        {
            MoveSelectedItems(listBox2, listBox1);
        }
        private void buttonMoveAllToright_Click(object sender, EventArgs e) //кнопка
        {
            MoveAllItems(listBox1, listBox2);
        }

        private void buttonMoveAllToleft_Click(object sender, EventArgs e)
        {
            MoveAllItems(listBox2, listBox1);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedItems(listBox1);
            DeleteSelectedItems(listBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.ShowDialog();
        }

        private int CompareStrings(string s1, string s2) 
        {
            int i=0;
            if (s1[i] > s2[i])
                return -1;
            else
                return 0;
        }
        private void InsertSort(ListBox list) //не работет
        { //сортировка прямым включением
            int i, u, n;
            string t1, t2;
            n = list.Items.Count;
            for (i = 1; i < n; i++)
            {
                t1 = list.Items[i].ToString(); 
                u = i - 1;
                t2 = list.Items[u].ToString();
                while (u >= 0 && String.Compare(t1, t2) <= 0)
                {
                    list.Items[u + 1] = list.Items[u];
                    u--;
                }
                list.Items[u + 1] = t1;
            }
        }
        private void SelectSort1(ListBox list)
        { //ñîðòèðîâêà ìåòîäîì ïðÿìîãî âûáîðà
            int i, min, p, u, n;
            string tu, tmin, ti;
            n = list.Items.Count;
            for (i = 0; i < n - 1; i++)
            {
                min = i;
                for (u = i + 1; u < n; u++)
                { 
                    tu = list.Items[u].ToString();
                    tmin = list.Items[min].ToString();
                    if (String.Compare(tu, tmin) < 0) min = u;
                }
                ti = list.Items[i].ToString();
                tmin = list.Items[min].ToString();
                if (String.Compare(ti, tmin) > 0)
                {
                    list.Items[i] = list.Items[min];
                    list.Items[min] = ti;
                }
            }
        }

        private void SelectSort2(ListBox list)
        { //ñîðòèðîâêà ìåòîäîì ïðÿìîãî âûáîðà
            int i, max, p, u, n;
            string tu, tmax, ti;
            n = list.Items.Count;
            for (i = 0; i < n - 1; i++)
            {
                max = i;
                for (u = i + 1; u < n; u++)
                {
                    tu = list.Items[u].ToString();
                    tmax = list.Items[max].ToString();
                    if (String.Compare(tu, tmax) > 0) max = u;
                }
                ti = list.Items[i].ToString();
                tmax = list.Items[max].ToString();
                if (String.Compare(ti, tmax) < 0)
                {
                    list.Items[i] = list.Items[max];
                    list.Items[max] = ti;
                }
            }
        }
        private void SelectSort3(ListBox list)
        { //ñîðòèðîâêà ìåòîäîì ïðÿìîãî âûáîðà
            int i, min, p, u, n;
            string tu, tmin, ti;
            n = list.Items.Count;
            for (i = 0; i < n - 1; i++)
            {
                min = i;
                for (u = i + 1; u < n; u++)
                {
                    tu = list.Items[u].ToString();
                    tmin = list.Items[min].ToString();
                    if (tu.Length < tmin.Length) min = u;
                }
                ti = list.Items[i].ToString();
                tmin = list.Items[min].ToString();
                if (ti.Length > tmin.Length)
                {
                    list.Items[i] = list.Items[min];
                    list.Items[min] = ti;
                }
            }
        }

        private void SelectSort4(ListBox list)
        { //ñîðòèðîâêà ìåòîäîì ïðÿìîãî âûáîðà
            int i, max, p, u, n;
            string tu, tmax, ti;
            n = list.Items.Count;
            for (i = 0; i < n - 1; i++)
            {
                max = i;
                for (u = i + 1; u < n; u++)
                {
                    tu = list.Items[u].ToString();
                    tmax = list.Items[max].ToString();
                    if (tu.Length > tmax.Length) max = u;
                }
                ti = list.Items[i].ToString();
                tmax = list.Items[max].ToString();
                if (ti.Length < tmax.Length)
                {
                    list.Items[i] = list.Items[max];
                    list.Items[max] = ti;
                }
            }
        }

        private void SortListBox(ListBox list, ComboBox box)
        {
            this.Cursor = Cursors.WaitCursor;
            
            if (box.SelectedItem == box.Items[0])
            {
                SelectSort1(list);
            }
            else if (box.SelectedItem == box.Items[1])
            {
                SelectSort2(list);
            }
            else if (box.SelectedItem == box.Items[2])
            {
                SelectSort3(list);
            }
            else if (box.SelectedItem == box.Items[3])
            {
                SelectSort4(list);
            }
            else
            {
                MessageBox.Show("Выберите критерий сортировки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Cursor = Cursors.Default;
        }

        private void buttonSort1_Click(object sender, EventArgs e)
        {
            SortListBox(listBox1, comboBox1);
        }

        private void buttonSort2_Click(object sender, EventArgs e)
        {
            SortListBox(listBox2, comboBox2);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            string textToFind = textBoxSearch.Text;

            if (checkBoxSection1.Checked)
            {
                foreach (string s in listBox1.Items)
                {
                    if (s.Contains(textToFind))
                        listBox3.Items.Add(s);
                }
            }

            if (checkBoxSection2.Checked)
            {
                foreach (string s in listBox2.Items)
                {
                    if (s.Contains(textToFind))
                        listBox3.Items.Add(s);
                }
            }
        }

        private void buttonClear1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void buttonClear2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

    }
}
