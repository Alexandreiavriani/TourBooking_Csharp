namespace Alexandre_Iavriani_Project.AirlineCrud
{
    partial class AirlineCreate
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
            this.button_CreateAirline = new System.Windows.Forms.Button();
            this.textBox_airlinePhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_airlineName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_CreateAirline
            // 
            this.button_CreateAirline.Location = new System.Drawing.Point(176, 238);
            this.button_CreateAirline.Name = "button_CreateAirline";
            this.button_CreateAirline.Size = new System.Drawing.Size(75, 23);
            this.button_CreateAirline.TabIndex = 11;
            this.button_CreateAirline.Text = "Create";
            this.button_CreateAirline.UseVisualStyleBackColor = true;
            this.button_CreateAirline.Click += new System.EventHandler(this.button_CreateAirline_Click);
            // 
            // textBox_airlinePhone
            // 
            this.textBox_airlinePhone.Location = new System.Drawing.Point(255, 178);
            this.textBox_airlinePhone.Name = "textBox_airlinePhone";
            this.textBox_airlinePhone.Size = new System.Drawing.Size(100, 20);
            this.textBox_airlinePhone.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(172, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(172, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Phone";
            // 
            // textBox_airlineName
            // 
            this.textBox_airlineName.Location = new System.Drawing.Point(255, 127);
            this.textBox_airlineName.Name = "textBox_airlineName";
            this.textBox_airlineName.Size = new System.Drawing.Size(100, 20);
            this.textBox_airlineName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(222, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Create";
            // 
            // AirlineCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 334);
            this.Controls.Add(this.button_CreateAirline);
            this.Controls.Add(this.textBox_airlinePhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_airlineName);
            this.Controls.Add(this.label1);
            this.Name = "AirlineCreate";
            this.Text = "AirlineCreate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CreateAirline;
        private System.Windows.Forms.TextBox textBox_airlinePhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_airlineName;
        private System.Windows.Forms.Label label1;
    }
}