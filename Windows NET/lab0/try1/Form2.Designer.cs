namespace try1
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
            this.labelN = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxN = new System.Windows.Forms.NumericUpDown();
            this.textBoxM = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxM)).BeginInit();
            this.SuspendLayout();
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.Location = new System.Drawing.Point(32, 8);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(27, 25);
            this.labelN.TabIndex = 1;
            this.labelN.Text = "N";
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelM.Location = new System.Drawing.Point(32, 45);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(30, 25);
            this.labelM.TabIndex = 4;
            this.labelM.Text = "M";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(150, 91);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(65, 13);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(120, 22);
            this.textBoxN.TabIndex = 8;
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(65, 48);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(120, 22);
            this.textBoxM.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 126);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.labelN);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.textBoxN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.NumericUpDown textBoxN;
        private System.Windows.Forms.NumericUpDown textBoxM;
    }
}