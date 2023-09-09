namespace Alexandre_Iavriani_Project.AirlineCrud
{
    partial class AirlineUpdate
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
            this.textBox_AirlineId = new System.Windows.Forms.TextBox();
            this.textBox_AirlinePhone = new System.Windows.Forms.TextBox();
            this.textBox_AirlineName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_CountryUpdate
            // 
            this.button_CountryUpdate.Location = new System.Drawing.Point(153, 324);
            this.button_CountryUpdate.Name = "button_CountryUpdate";
            this.button_CountryUpdate.Size = new System.Drawing.Size(75, 23);
            this.button_CountryUpdate.TabIndex = 26;
            this.button_CountryUpdate.Text = "Update";
            this.button_CountryUpdate.UseVisualStyleBackColor = true;
            this.button_CountryUpdate.Click += new System.EventHandler(this.button_CountryUpdate_Click);
            // 
            // textBox_AirlineId
            // 
            this.textBox_AirlineId.Location = new System.Drawing.Point(238, 141);
            this.textBox_AirlineId.Name = "textBox_AirlineId";
            this.textBox_AirlineId.Size = new System.Drawing.Size(100, 20);
            this.textBox_AirlineId.TabIndex = 25;
            this.textBox_AirlineId.MouseLeave += new System.EventHandler(this.textBox_AirlineId_MouseLeave);
            // 
            // textBox_AirlinePhone
            // 
            this.textBox_AirlinePhone.Location = new System.Drawing.Point(238, 241);
            this.textBox_AirlinePhone.Name = "textBox_AirlinePhone";
            this.textBox_AirlinePhone.Size = new System.Drawing.Size(100, 20);
            this.textBox_AirlinePhone.TabIndex = 24;
            // 
            // textBox_AirlineName
            // 
            this.textBox_AirlineName.Location = new System.Drawing.Point(238, 190);
            this.textBox_AirlineName.Name = "textBox_AirlineName";
            this.textBox_AirlineName.Size = new System.Drawing.Size(100, 20);
            this.textBox_AirlineName.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(150, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(150, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(150, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(192, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Update";
            // 
            // AirlineUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.button_CountryUpdate);
            this.Controls.Add(this.textBox_AirlineId);
            this.Controls.Add(this.textBox_AirlinePhone);
            this.Controls.Add(this.textBox_AirlineName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AirlineUpdate";
            this.Text = "AirlineUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CountryUpdate;
        private System.Windows.Forms.TextBox textBox_AirlineId;
        private System.Windows.Forms.TextBox textBox_AirlinePhone;
        private System.Windows.Forms.TextBox textBox_AirlineName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}