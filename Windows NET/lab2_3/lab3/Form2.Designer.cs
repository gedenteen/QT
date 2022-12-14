namespace lab3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hsbRed = new System.Windows.Forms.HScrollBar();
            this.nudRed = new System.Windows.Forms.NumericUpDown();
            this.hsbGreen = new System.Windows.Forms.HScrollBar();
            this.hsbBlue = new System.Windows.Forms.HScrollBar();
            this.nudGreen = new System.Windows.Forms.NumericUpDown();
            this.nudBlue = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blue";
            // 
            // hsbRed
            // 
            this.hsbRed.LargeChange = 1;
            this.hsbRed.Location = new System.Drawing.Point(87, 9);
            this.hsbRed.Maximum = 255;
            this.hsbRed.Name = "hsbRed";
            this.hsbRed.Size = new System.Drawing.Size(212, 22);
            this.hsbRed.TabIndex = 3;
            this.hsbRed.Value = 255;
            this.hsbRed.ValueChanged += new System.EventHandler(this.hsbRed_ValueChanged);
            // 
            // nudRed
            // 
            this.nudRed.Location = new System.Drawing.Point(326, 9);
            this.nudRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRed.Name = "nudRed";
            this.nudRed.Size = new System.Drawing.Size(79, 22);
            this.nudRed.TabIndex = 6;
            this.nudRed.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRed.ValueChanged += new System.EventHandler(this.nudRed_ValueChanged);
            // 
            // hsbGreen
            // 
            this.hsbGreen.LargeChange = 1;
            this.hsbGreen.Location = new System.Drawing.Point(87, 38);
            this.hsbGreen.Maximum = 255;
            this.hsbGreen.Name = "hsbGreen";
            this.hsbGreen.Size = new System.Drawing.Size(212, 22);
            this.hsbGreen.TabIndex = 9;
            this.hsbGreen.Value = 255;
            this.hsbGreen.ValueChanged += new System.EventHandler(this.hsbGreen_ValueChanged);
            // 
            // hsbBlue
            // 
            this.hsbBlue.LargeChange = 1;
            this.hsbBlue.Location = new System.Drawing.Point(87, 66);
            this.hsbBlue.Maximum = 255;
            this.hsbBlue.Name = "hsbBlue";
            this.hsbBlue.Size = new System.Drawing.Size(212, 22);
            this.hsbBlue.TabIndex = 10;
            this.hsbBlue.Value = 255;
            this.hsbBlue.ValueChanged += new System.EventHandler(this.hsbBlue_ValueChanged);
            // 
            // nudGreen
            // 
            this.nudGreen.Location = new System.Drawing.Point(326, 38);
            this.nudGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGreen.Name = "nudGreen";
            this.nudGreen.Size = new System.Drawing.Size(79, 22);
            this.nudGreen.TabIndex = 11;
            this.nudGreen.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGreen.ValueChanged += new System.EventHandler(this.nudGreen_ValueChanged);
            // 
            // nudBlue
            // 
            this.nudBlue.Location = new System.Drawing.Point(326, 66);
            this.nudBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBlue.Name = "nudBlue";
            this.nudBlue.Size = new System.Drawing.Size(79, 22);
            this.nudBlue.TabIndex = 12;
            this.nudBlue.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBlue.ValueChanged += new System.EventHandler(this.nudBlue_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(427, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 79);
            this.panel1.TabIndex = 13;
            this.panel1.Layout += new System.Windows.Forms.LayoutEventHandler(this.panel1_Layout);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(353, 114);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 26);
            this.buttonOk.TabIndex = 14;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(434, 114);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 26);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(537, 145);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nudBlue);
            this.Controls.Add(this.nudGreen);
            this.Controls.Add(this.hsbBlue);
            this.Controls.Add(this.hsbGreen);
            this.Controls.Add(this.nudRed);
            this.Controls.Add(this.hsbRed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar hsbRed;
        private System.Windows.Forms.NumericUpDown nudRed;
        private System.Windows.Forms.HScrollBar hsbGreen;
        private System.Windows.Forms.HScrollBar hsbBlue;
        private System.Windows.Forms.NumericUpDown nudGreen;
        private System.Windows.Forms.NumericUpDown nudBlue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}