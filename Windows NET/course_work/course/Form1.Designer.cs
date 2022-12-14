namespace course
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
            this.dataGridFood = new System.Windows.Forms.DataGridView();
            this.продуктыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodDataSet = new course.foodDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMenuReupload = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuSaveProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.labelProducts = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridRecipe = new System.Windows.Forms.DataGridView();
            this.рецептыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFeed = new System.Windows.Forms.Button();
            this.buttonCheckFood = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.продуктыTableAdapter = new course.foodDataSetTableAdapters.продуктыTableAdapter();
            this.рецептыTableAdapter = new course.foodDataSetTableAdapters.РецептыTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxForSort = new System.Windows.Forms.TextBox();
            this.numericUpDownStudents = new System.Windows.Forms.NumericUpDown();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаИзмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеБлюдаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продукт1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоПродукта1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продукт2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоПродукта2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продукт3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоПродукта3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рецептыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridFood
            // 
            this.dataGridFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridFood.AutoGenerateColumns = false;
            this.dataGridFood.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.названиеПродуктаDataGridViewTextBoxColumn,
            this.количествоПродуктаDataGridViewTextBoxColumn,
            this.единицаИзмеренияDataGridViewTextBoxColumn});
            this.dataGridFood.DataSource = this.продуктыBindingSource;
            this.dataGridFood.Location = new System.Drawing.Point(3, 27);
            this.dataGridFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridFood.Name = "dataGridFood";
            this.dataGridFood.RowHeadersWidth = 51;
            this.dataGridFood.RowTemplate.Height = 24;
            this.dataGridFood.Size = new System.Drawing.Size(284, 289);
            this.dataGridFood.TabIndex = 1;
            // 
            // продуктыBindingSource
            // 
            this.продуктыBindingSource.DataMember = "продукты";
            this.продуктыBindingSource.DataSource = this.foodDataSet;
            // 
            // foodDataSet
            // 
            this.foodDataSet.DataSetName = "foodDataSet";
            this.foodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenuReupload,
            this.TSMenuSaveProducts,
            this.TSMenuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(997, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMenuReupload
            // 
            this.TSMenuReupload.Name = "TSMenuReupload";
            this.TSMenuReupload.Size = new System.Drawing.Size(168, 24);
            this.TSMenuReupload.Text = "Загрузить БД заново";
            this.TSMenuReupload.Click += new System.EventHandler(this.TSMenuReupload_Click);
            // 
            // TSMenuSaveProducts
            // 
            this.TSMenuSaveProducts.Name = "TSMenuSaveProducts";
            this.TSMenuSaveProducts.Size = new System.Drawing.Size(292, 24);
            this.TSMenuSaveProducts.Text = "Сохранить изменения в 1-ой таблице ";
            this.TSMenuSaveProducts.Click += new System.EventHandler(this.TSMenuSaveProducts_Click);
            // 
            // TSMenuHelp
            // 
            this.TSMenuHelp.Name = "TSMenuHelp";
            this.TSMenuHelp.Size = new System.Drawing.Size(83, 24);
            this.TSMenuHelp.Text = "Помощь";
            this.TSMenuHelp.Click += new System.EventHandler(this.TSMenuHelp_Click);
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelProducts.Location = new System.Drawing.Point(3, 0);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(152, 18);
            this.labelProducts.TabIndex = 3;
            this.labelProducts.Text = "Продукты на складе";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridRecipe, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridFood, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelProducts, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 146);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(968, 318);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // dataGridRecipe
            // 
            this.dataGridRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridRecipe.AutoGenerateColumns = false;
            this.dataGridRecipe.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRecipe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn1,
            this.названиеБлюдаDataGridViewTextBoxColumn,
            this.категорияDataGridViewTextBoxColumn,
            this.продукт1DataGridViewTextBoxColumn,
            this.количествоПродукта1DataGridViewTextBoxColumn,
            this.продукт2DataGridViewTextBoxColumn,
            this.количествоПродукта2DataGridViewTextBoxColumn,
            this.продукт3DataGridViewTextBoxColumn,
            this.количествоПродукта3DataGridViewTextBoxColumn});
            this.dataGridRecipe.DataSource = this.рецептыBindingSource;
            this.dataGridRecipe.Location = new System.Drawing.Point(293, 27);
            this.dataGridRecipe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridRecipe.Name = "dataGridRecipe";
            this.dataGridRecipe.RowHeadersWidth = 51;
            this.dataGridRecipe.RowTemplate.Height = 24;
            this.dataGridRecipe.Size = new System.Drawing.Size(672, 289);
            this.dataGridRecipe.TabIndex = 5;
            // 
            // рецептыBindingSource
            // 
            this.рецептыBindingSource.DataMember = "Рецепты";
            this.рецептыBindingSource.DataSource = this.foodDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(293, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Рецепты блюд";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Количество студентов: ";
            // 
            // buttonFeed
            // 
            this.buttonFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFeed.Location = new System.Drawing.Point(16, 70);
            this.buttonFeed.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFeed.Name = "buttonFeed";
            this.buttonFeed.Size = new System.Drawing.Size(317, 44);
            this.buttonFeed.TabIndex = 13;
            this.buttonFeed.Text = "Составить меню";
            this.buttonFeed.UseVisualStyleBackColor = true;
            this.buttonFeed.Click += new System.EventHandler(this.buttonFeed_Click);
            // 
            // buttonCheckFood
            // 
            this.buttonCheckFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheckFood.Location = new System.Drawing.Point(368, 39);
            this.buttonCheckFood.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCheckFood.Name = "buttonCheckFood";
            this.buttonCheckFood.Size = new System.Drawing.Size(147, 75);
            this.buttonCheckFood.TabIndex = 14;
            this.buttonCheckFood.Text = "Что можно приготовить?";
            this.buttonCheckFood.UseVisualStyleBackColor = true;
            this.buttonCheckFood.Click += new System.EventHandler(this.buttonCheckFood_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSort.Location = new System.Drawing.Point(547, 70);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSort.Size = new System.Drawing.Size(349, 44);
            this.buttonSort.TabIndex = 15;
            this.buttonSort.Text = "Сортировка блюд";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // продуктыTableAdapter
            // 
            this.продуктыTableAdapter.ClearBeforeFill = true;
            // 
            // рецептыTableAdapter
            // 
            this.рецептыTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(544, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Категория или продукт:";
            // 
            // textBoxForSort
            // 
            this.textBoxForSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxForSort.Location = new System.Drawing.Point(739, 36);
            this.textBoxForSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxForSort.Name = "textBoxForSort";
            this.textBoxForSort.Size = new System.Drawing.Size(157, 24);
            this.textBoxForSort.TabIndex = 20;
            // 
            // numericUpDownStudents
            // 
            this.numericUpDownStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numericUpDownStudents.Location = new System.Drawing.Point(213, 37);
            this.numericUpDownStudents.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownStudents.Name = "numericUpDownStudents";
            this.numericUpDownStudents.Size = new System.Drawing.Size(120, 24);
            this.numericUpDownStudents.TabIndex = 21;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Width = 50;
            // 
            // названиеПродуктаDataGridViewTextBoxColumn
            // 
            this.названиеПродуктаDataGridViewTextBoxColumn.DataPropertyName = "название продукта";
            this.названиеПродуктаDataGridViewTextBoxColumn.HeaderText = "название продукта";
            this.названиеПродуктаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеПродуктаDataGridViewTextBoxColumn.Name = "названиеПродуктаDataGridViewTextBoxColumn";
            // 
            // количествоПродуктаDataGridViewTextBoxColumn
            // 
            this.количествоПродуктаDataGridViewTextBoxColumn.DataPropertyName = "количество продукта";
            this.количествоПродуктаDataGridViewTextBoxColumn.HeaderText = "количество продукта";
            this.количествоПродуктаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоПродуктаDataGridViewTextBoxColumn.Name = "количествоПродуктаDataGridViewTextBoxColumn";
            this.количествоПродуктаDataGridViewTextBoxColumn.Width = 75;
            // 
            // единицаИзмеренияDataGridViewTextBoxColumn
            // 
            this.единицаИзмеренияDataGridViewTextBoxColumn.DataPropertyName = "единица измерения";
            this.единицаИзмеренияDataGridViewTextBoxColumn.HeaderText = "единица измерения";
            this.единицаИзмеренияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.единицаИзмеренияDataGridViewTextBoxColumn.Name = "единицаИзмеренияDataGridViewTextBoxColumn";
            this.единицаИзмеренияDataGridViewTextBoxColumn.Width = 75;
            // 
            // кодDataGridViewTextBoxColumn1
            // 
            this.кодDataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn1.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.кодDataGridViewTextBoxColumn1.Name = "кодDataGridViewTextBoxColumn1";
            this.кодDataGridViewTextBoxColumn1.Width = 40;
            // 
            // названиеБлюдаDataGridViewTextBoxColumn
            // 
            this.названиеБлюдаDataGridViewTextBoxColumn.DataPropertyName = "название блюда";
            this.названиеБлюдаDataGridViewTextBoxColumn.HeaderText = "название блюда";
            this.названиеБлюдаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеБлюдаDataGridViewTextBoxColumn.Name = "названиеБлюдаDataGridViewTextBoxColumn";
            this.названиеБлюдаDataGridViewTextBoxColumn.Width = 125;
            // 
            // категорияDataGridViewTextBoxColumn
            // 
            this.категорияDataGridViewTextBoxColumn.DataPropertyName = "категория";
            this.категорияDataGridViewTextBoxColumn.HeaderText = "категория";
            this.категорияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.категорияDataGridViewTextBoxColumn.Name = "категорияDataGridViewTextBoxColumn";
            this.категорияDataGridViewTextBoxColumn.Width = 110;
            // 
            // продукт1DataGridViewTextBoxColumn
            // 
            this.продукт1DataGridViewTextBoxColumn.DataPropertyName = "продукт 1";
            this.продукт1DataGridViewTextBoxColumn.HeaderText = "продукт 1";
            this.продукт1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.продукт1DataGridViewTextBoxColumn.Name = "продукт1DataGridViewTextBoxColumn";
            // 
            // количествоПродукта1DataGridViewTextBoxColumn
            // 
            this.количествоПродукта1DataGridViewTextBoxColumn.DataPropertyName = "количество продукта 1";
            this.количествоПродукта1DataGridViewTextBoxColumn.HeaderText = "количество продукта 1";
            this.количествоПродукта1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоПродукта1DataGridViewTextBoxColumn.Name = "количествоПродукта1DataGridViewTextBoxColumn";
            this.количествоПродукта1DataGridViewTextBoxColumn.Width = 80;
            // 
            // продукт2DataGridViewTextBoxColumn
            // 
            this.продукт2DataGridViewTextBoxColumn.DataPropertyName = "продукт 2";
            this.продукт2DataGridViewTextBoxColumn.HeaderText = "продукт 2";
            this.продукт2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.продукт2DataGridViewTextBoxColumn.Name = "продукт2DataGridViewTextBoxColumn";
            // 
            // количествоПродукта2DataGridViewTextBoxColumn
            // 
            this.количествоПродукта2DataGridViewTextBoxColumn.DataPropertyName = "количество продукта 2";
            this.количествоПродукта2DataGridViewTextBoxColumn.HeaderText = "количество продукта 2";
            this.количествоПродукта2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоПродукта2DataGridViewTextBoxColumn.Name = "количествоПродукта2DataGridViewTextBoxColumn";
            this.количествоПродукта2DataGridViewTextBoxColumn.Width = 80;
            // 
            // продукт3DataGridViewTextBoxColumn
            // 
            this.продукт3DataGridViewTextBoxColumn.DataPropertyName = "продукт 3";
            this.продукт3DataGridViewTextBoxColumn.HeaderText = "продукт 3";
            this.продукт3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.продукт3DataGridViewTextBoxColumn.Name = "продукт3DataGridViewTextBoxColumn";
            // 
            // количествоПродукта3DataGridViewTextBoxColumn
            // 
            this.количествоПродукта3DataGridViewTextBoxColumn.DataPropertyName = "количество продукта 3";
            this.количествоПродукта3DataGridViewTextBoxColumn.HeaderText = "количество продукта 3";
            this.количествоПродукта3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоПродукта3DataGridViewTextBoxColumn.Name = "количествоПродукта3DataGridViewTextBoxColumn";
            this.количествоПродукта3DataGridViewTextBoxColumn.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(997, 476);
            this.Controls.Add(this.numericUpDownStudents);
            this.Controls.Add(this.textBoxForSort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonCheckFood);
            this.Controls.Add(this.buttonFeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Составление меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рецептыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMenuReupload;
        private System.Windows.Forms.Label labelProducts;
        private foodDataSet foodDataSet;
        private System.Windows.Forms.BindingSource продуктыBindingSource;
        private foodDataSetTableAdapters.продуктыTableAdapter продуктыTableAdapter;
        private System.Windows.Forms.BindingSource рецептыBindingSource;
        private foodDataSetTableAdapters.РецептыTableAdapter рецептыTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFeed;
        private System.Windows.Forms.Button buttonCheckFood;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxForSort;
        private System.Windows.Forms.ToolStripMenuItem TSMenuSaveProducts;
        private System.Windows.Forms.ToolStripMenuItem TSMenuHelp;
        public System.Windows.Forms.DataGridView dataGridFood;
        public System.Windows.Forms.DataGridView dataGridRecipe;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеПродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоПродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаИзмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеБлюдаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn продукт1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоПродукта1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn продукт2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоПродукта2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn продукт3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоПродукта3DataGridViewTextBoxColumn;
    }
}

