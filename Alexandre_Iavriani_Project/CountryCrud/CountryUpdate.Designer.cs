namespace Alexandre_Iavriani_Project.CountryCrud
{
    partial class CountryUpdate
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
            this.button_CountryUpdate = new System.Windows.Forms.Button();
            this.textBox_CountryId = new System.Windows.Forms.TextBox();
            this.textBox_CountryPrice = new System.Windows.Forms.TextBox();
            this.textBox_countryName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_CountryUpdate
            // 
            this.button_CountryUpdate.Location = new System.Drawing.Point(149, 331);
            this.button_CountryUpdate.Name = "button_CountryUpdate";
            this.button_CountryUpdate.Size = new System.Drawing.Size(75, 23);
            this.button_CountryUpdate.TabIndex = 18;
            this.button_CountryUpdate.Text = "Update";
            this.button_CountryUpdate.UseVisualStyleBackColor = true;
            this.button_CountryUpdate.Click += new System.EventHandler(this.button_CountryUpdate_Click);
            // 
            // textBox_CountryId
            // 
            this.textBox_CountryId.Location = new System.Drawing.Point(234, 148);
            this.textBox_CountryId.Name = "textBox_CountryId";
            this.textBox_CountryId.Size = new System.Drawing.Size(100, 20);
            this.textBox_CountryId.TabIndex = 17;
            this.textBox_CountryId.MouseLeave += new System.EventHandler(this.textBox_CountryId_MouseLeave);
            // 
            // textBox_CountryPrice
            // 
            this.textBox_CountryPrice.Location = new System.Drawing.Point(234, 248);
            this.textBox_CountryPrice.Name = "textBox_CountryPrice";
            this.textBox_CountryPrice.Size = new System.Drawing.Size(100, 20);
            this.textBox_CountryPrice.TabIndex = 16;
            // 
            // textBox_countryName
            // 
            this.textBox_countryName.Location = new System.Drawing.Point(234, 197);
            this.textBox_countryName.Name = "textBox_countryName";
            this.textBox_countryName.Size = new System.Drawing.Size(100, 20);
            this.textBox_countryName.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(146, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(146, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(146, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(175, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Update";
            // 
            // CountryUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.button_CountryUpdate);
            this.Controls.Add(this.textBox_CountryId);
            this.Controls.Add(this.textBox_CountryPrice);
            this.Controls.Add(this.textBox_countryName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CountryUpdate";
            this.Text = "CountryUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CountryUpdate;
        private System.Windows.Forms.TextBox textBox_CountryId;
        private System.Windows.Forms.TextBox textBox_CountryPrice;
        private System.Windows.Forms.TextBox textBox_countryName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}