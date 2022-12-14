using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            treeView1.BeforeSelect += treeView1_BeforeSelect;
            treeView1.BeforeExpand += treeView1_BeforeExpand;
            ExtensionСomboBox1.SelectedIndex = 0;
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        // событие перед раскрытием узла
        void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;
            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                            FillTreeNode(dirNode, dirs[i]);
                            e.Node.Nodes.Add(dirNode);
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        // добавление файлов в listView1
        TreeViewCancelEventArgs tree_temp;
        void listView1_Update(TreeViewCancelEventArgs e)
        {
            if (e == null)
                return;

            tree_temp = e;
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = new DirectoryInfo(e.Node.FullPath);
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            try
            {
                foreach (FileInfo file in nodeDirInfo.GetFiles())
                {
                    bool skip = true;
                    switch (ExtensionСomboBox1.SelectedIndex)
                    {
                        case 0:
                            skip = false;
                            break;
                        case 1:
                            if (file.Extension == ".png")
                                skip = false;
                            break;
                        case 2:
                            if (file.Extension == ".jpg" || file.Extension == ".jpeg")
                                skip = false;
                            break;
                        case 3:
                            if (file.Extension == ".bmp")
                                skip = false;
                            break;
                        default:
                            break;
                    }
                    if (skip)
                        continue;
                    item = new ListViewItem(file.Name, 1);
                    subItems = new ListViewItem.ListViewSubItem[]
                        { new ListViewItem.ListViewSubItem(item, "File"),
                        new ListViewItem.ListViewSubItem(item,
                        file.LastAccessTime.ToShortDateString())};
                    item.SubItems.AddRange(subItems);
                    listView1.Items.Add(item);
                }
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch
            {
                MessageBox.Show("Отказано в доступе");
            }
        }

        // событие перед выделением узла
        void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;
            listView1_Update(e);
            try
            {
                textBoxPath.Text = e.Node.FullPath;
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                            FillTreeNode(dirNode, dirs[i]);
                            e.Node.Nodes.Add(dirNode);
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        // получение дисков компьютера
        private void FillDriveNodes(string d)
        {
            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    if (drive.Name == d)
                    {
                        TreeNode driveNode = new TreeNode { Text = drive.Name };
                        FillTreeNode(driveNode, drive.Name);
                        treeView1.Nodes.Add(driveNode);
                    }
                }
            }
            catch (Exception ex) { }
        }
        // получаем дочерние узлы для определенного узла
        private void FillTreeNode(TreeNode driveNode, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    TreeNode dirNode = new TreeNode();
                    dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                    driveNode.Nodes.Add(dirNode);
                }
            }
            catch (Exception ex) { }
        }

        private void DriveComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            if (DriveComboBox1.SelectedItem == DriveComboBox1.Items[0])
                FillDriveNodes("C:\\");
            else if (DriveComboBox1.SelectedItem == DriveComboBox1.Items[1])
                FillDriveNodes("D:\\");
            else if (DriveComboBox1.SelectedItem == DriveComboBox1.Items[2])
                FillDriveNodes("E:\\");
            else if (DriveComboBox1.SelectedItem == DriveComboBox1.Items[3])
                FillDriveNodes("F:\\");
            else if (DriveComboBox1.SelectedItem == DriveComboBox1.Items[4])
                FillDriveNodes("G:\\");
        }

        private void ExtensionСomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1_Update(tree_temp);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            foreach (ListViewItem lvi in listView1.SelectedItems)
            {
                i++;
                if (i > 1)
                {
                    MessageBox.Show("Можно вывести только одно изображение");
                    return;
                }
                FileInfo file = new  FileInfo(textBoxPath.Text + '\\' + lvi.Text);
                if (file.Extension == ".png" || file.Extension == ".jpg" ||
                    file.Extension == ".jpeg" || file.Extension == ".bmp")
                {
                    pictureBox1.Image = Image.FromFile(file.FullName);
                    textBoxNameSize.Text = file.Name + " " + file.Length + " байт";
                }
                else
                {
                    MessageBox.Show("Можно вывести только изображения с расширениями " +
                        ".png .jpg .jpeg .bmp");
                    return;
                }
            }
        }

        bool time_upd = true;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time_upd)
                labelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (time_upd)
                time_upd = false;
        }
    }
}
