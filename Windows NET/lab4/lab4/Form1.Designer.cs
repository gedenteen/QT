namespace lab4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Name_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelUpper = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.ExtensionСomboBox1 = new System.Windows.Forms.ComboBox();
            this.labelTypeFiles = new System.Windows.Forms.Label();
            this.DriveComboBox1 = new System.Windows.Forms.ComboBox();
            this.labelDrive = new System.Windows.Forms.Label();
            this.panelLower = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.textBoxNameSize = new System.Windows.Forms.TextBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.panelRight = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelUpper.SuspendLayout();
            this.panelLower.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "document.png");
            // 
            // panelMiddle
            // 
            this.panelMiddle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMiddle.Controls.Add(this.splitContainer1);
            this.panelMiddle.Location = new System.Drawing.Point(0, 37);
            this.panelMiddle.Margin = new System.Windows.Forms.Padding(2);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(618, 356);
            this.panelMiddle.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(616, 354);
            this.splitContainer1.SplitterDistance = 285;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(283, 354);
            this.treeView1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name_,
            this.Type,
            this.LastModified});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(330, 355);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Name_
            // 
            this.Name_.Text = "Имя";
            this.Name_.Width = 124;
            // 
            // Type
            // 
            this.Type.Text = "Тип";
            this.Type.Width = 85;
            // 
            // LastModified
            // 
            this.LastModified.Text = "Последнее изменение";
            this.LastModified.Width = 167;
            // 
            // panelUpper
            // 
            this.panelUpper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUpper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUpper.Controls.Add(this.radioButton1);
            this.panelUpper.Controls.Add(this.ExtensionСomboBox1);
            this.panelUpper.Controls.Add(this.labelTypeFiles);
            this.panelUpper.Controls.Add(this.DriveComboBox1);
            this.panelUpper.Controls.Add(this.labelDrive);
            this.panelUpper.Location = new System.Drawing.Point(0, 0);
            this.panelUpper.Margin = new System.Windows.Forms.Padding(2);
            this.panelUpper.Name = "panelUpper";
            this.panelUpper.Size = new System.Drawing.Size(1014, 39);
            this.panelUpper.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.Image = global::lab4.Properties.Resources.time26x26;
            this.radioButton1.Location = new System.Drawing.Point(959, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(33, 32);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ExtensionСomboBox1
            // 
            this.ExtensionСomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExtensionСomboBox1.FormattingEnabled = true;
            this.ExtensionСomboBox1.Items.AddRange(new object[] {
            "Все файлы (*.*)",
            "PNG (*.png)",
            "JPEG (*.jpg, *.jpeg)",
            "BMP (*.bmp)"});
            this.ExtensionСomboBox1.Location = new System.Drawing.Point(266, 6);
            this.ExtensionСomboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.ExtensionСomboBox1.Name = "ExtensionСomboBox1";
            this.ExtensionСomboBox1.Size = new System.Drawing.Size(131, 21);
            this.ExtensionСomboBox1.TabIndex = 3;
            this.ExtensionСomboBox1.SelectedIndexChanged += new System.EventHandler(this.ExtensionСomboBox1_SelectedIndexChanged);
            // 
            // labelTypeFiles
            // 
            this.labelTypeFiles.AutoSize = true;
            this.labelTypeFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelTypeFiles.Location = new System.Drawing.Point(166, 6);
            this.labelTypeFiles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTypeFiles.Name = "labelTypeFiles";
            this.labelTypeFiles.Size = new System.Drawing.Size(96, 18);
            this.labelTypeFiles.TabIndex = 2;
            this.labelTypeFiles.Text = "Тип файлов:";
            // 
            // DriveComboBox1
            // 
            this.DriveComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DriveComboBox1.FormattingEnabled = true;
            this.DriveComboBox1.Items.AddRange(new object[] {
            "Диск C",
            "Диск D",
            "Диск E",
            "Диск F",
            "Диск G"});
            this.DriveComboBox1.Location = new System.Drawing.Point(60, 6);
            this.DriveComboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.DriveComboBox1.Name = "DriveComboBox1";
            this.DriveComboBox1.Size = new System.Drawing.Size(92, 21);
            this.DriveComboBox1.TabIndex = 1;
            this.DriveComboBox1.SelectedIndexChanged += new System.EventHandler(this.DriveComboBox1_SelectedIndexChanged);
            // 
            // labelDrive
            // 
            this.labelDrive.AutoSize = true;
            this.labelDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelDrive.Location = new System.Drawing.Point(8, 6);
            this.labelDrive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDrive.Name = "labelDrive";
            this.labelDrive.Size = new System.Drawing.Size(48, 18);
            this.labelDrive.TabIndex = 0;
            this.labelDrive.Text = "Диск:";
            // 
            // panelLower
            // 
            this.panelLower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLower.Controls.Add(this.labelTime);
            this.panelLower.Controls.Add(this.textBoxNameSize);
            this.panelLower.Controls.Add(this.textBoxPath);
            this.panelLower.Location = new System.Drawing.Point(0, 390);
            this.panelLower.Margin = new System.Windows.Forms.Padding(2);
            this.panelLower.Name = "panelLower";
            this.panelLower.Size = new System.Drawing.Size(1014, 41);
            this.panelLower.TabIndex = 2;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelTime.Location = new System.Drawing.Point(956, 13);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(36, 18);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "time";
            // 
            // textBoxNameSize
            // 
            this.textBoxNameSize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxNameSize.Location = new System.Drawing.Point(572, 11);
            this.textBoxNameSize.Name = "textBoxNameSize";
            this.textBoxNameSize.ReadOnly = true;
            this.textBoxNameSize.Size = new System.Drawing.Size(369, 20);
            this.textBoxNameSize.TabIndex = 3;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.Location = new System.Drawing.Point(11, 11);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(555, 20);
            this.textBoxPath.TabIndex = 2;
            // 
            // panelRight
            // 
            this.panelRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight.AutoScroll = true;
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.pictureBox1);
            this.panelRight.Location = new System.Drawing.Point(623, 37);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(391, 355);
            this.panelRight.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 431);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.panelLower);
            this.Controls.Add(this.panelUpper);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMiddle.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelUpper.ResumeLayout(false);
            this.panelUpper.PerformLayout();
            this.panelLower.ResumeLayout(false);
            this.panelLower.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Name_;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader LastModified;
        private System.Windows.Forms.Panel panelUpper;
        private System.Windows.Forms.Panel panelLower;
        private System.Windows.Forms.Label labelDrive;
        private System.Windows.Forms.ComboBox DriveComboBox1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label labelTypeFiles;
        private System.Windows.Forms.ComboBox ExtensionСomboBox1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.TextBox textBoxNameSize;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

