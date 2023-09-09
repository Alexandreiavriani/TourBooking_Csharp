namespace Alexandre_Iavriani_Project.CountryCrud
{
    partial class CountryDelete
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_CountryPrice = new System.Windows.Forms.TextBox();
            this.textBox_countryName = new System.Windows.Forms.TextBox();
            this.textBox_CountryId = new System.Windows.Forms.TextBox();
            this.button_CountryDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(191, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(149, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(149, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(149, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_CountryPrice
            // 
            this.textBox_CountryPrice.Location = new System.Drawing.Point(237, 236);
            this.textBox_CountryPrice.Name = "textBox_CountryPrice";
            this.textBox_CountryPrice.Size = new System.Drawing.Size(100, 20);
            this.textBox_CountryPrice.TabIndex = 8;
            this.textBox_CountryPrice.TextChanged += new System.EventHandler(this.textBox_CountryPrice_TextChanged);
            // 
            // textBox_countryName
            // 
            this.textBox_countryName.Location = new System.Drawing.Point(237, 185);
            this.textBox_countryName.Name = "textBox_countryName";
            this.textBox_countryName.Size = new System.Drawing.Size(100, 20);
            this.textBox_countryName.TabIndex = 7;
            this.textBox_countryName.TextChanged += new System.EventHandler(this.textBox_countryName_TextChanged);
            // 
            // textBox_CountryId
            // 
            this.textBox_CountryId.Location = new System.Drawing.Point(237, 136);
            this.textBox_CountryId.Name = "textBox_CountryId";
            this.textBox_CountryId.Size = new System.Drawing.Size(100, 20);
            this.textBox_CountryId.TabIndex = 9;
            this.textBox_CountryId.TextChanged += new System.EventHandler(this.textBox_CountryId_TextChanged);
            this.textBox_CountryId.MouseLeave += new System.EventHandler(this.textBox_CountryId_MouseLeave);
            // 
            // button_CountryDelete
            // 
            this.button_CountryDelete.Location = new System.Drawing.Point(152, 319);
            this.button_CountryDelete.Name = "button_CountryDelete";
            this.button_CountryDelete.Size = new System.Drawing.Size(75, 23);
            this.button_CountryDelete.TabIndex = 10;
            this.button_CountryDelete.Text = "Delete";
            this.button_CountryDelete.UseVisualStyleBackColor = true;
            this.button_CountryDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // CountryDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.button_CountryDelete);
            this.Controls.Add(this.textBox_CountryId);
            this.Controls.Add(this.textBox_CountryPrice);
            this.Controls.Add(this.textBox_countryName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CountryDelete";
            this.Text = "CountryDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_CountryPrice;
        private System.Windows.Forms.TextBox textBox_countryName;
        private System.Windows.Forms.TextBox textBox_CountryId;
        private System.Windows.Forms.Button button_CountryDelete;
    }
}