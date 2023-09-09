namespace Alexandre_Iavriani_Project.ManagerCrud
{
    partial class ManagerDelete
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
            this.button_ManagerDelete = new System.Windows.Forms.Button();
            this.textBox_ManagerId = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_managerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_managerPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_ManagerDelete
            // 
            this.button_ManagerDelete.Location = new System.Drawing.Point(161, 355);
            this.button_ManagerDelete.Name = "button_ManagerDelete";
            this.button_ManagerDelete.Size = new System.Drawing.Size(75, 23);
            this.button_ManagerDelete.TabIndex = 18;
            this.button_ManagerDelete.Text = "Delete";
            this.button_ManagerDelete.UseVisualStyleBackColor = true;
            this.button_ManagerDelete.Click += new System.EventHandler(this.button_ManagerDelete_Click);
            // 
            // textBox_ManagerId
            // 
            this.textBox_ManagerId.Location = new System.Drawing.Point(277, 131);
            this.textBox_ManagerId.Name = "textBox_ManagerId";
            this.textBox_ManagerId.Size = new System.Drawing.Size(100, 20);
            this.textBox_ManagerId.TabIndex = 17;
            this.textBox_ManagerId.MouseLeave += new System.EventHandler(this.textBox_ManagerId_MouseLeave);
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(277, 232);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(100, 20);
            this.textBox_LastName.TabIndex = 16;
            // 
            // textBox_managerName
            // 
            this.textBox_managerName.Location = new System.Drawing.Point(277, 180);
            this.textBox_managerName.Name = "textBox_managerName";
            this.textBox_managerName.Size = new System.Drawing.Size(100, 20);
            this.textBox_managerName.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(157, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(157, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "LastName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(157, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(199, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Delete";
            // 
            // textBox_managerPhone
            // 
            this.textBox_managerPhone.Location = new System.Drawing.Point(277, 287);
            this.textBox_managerPhone.Name = "textBox_managerPhone";
            this.textBox_managerPhone.Size = new System.Drawing.Size(100, 20);
            this.textBox_managerPhone.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(157, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Phone";
            // 
            // ManagerDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.textBox_managerPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_ManagerDelete);
            this.Controls.Add(this.textBox_ManagerId);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_managerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManagerDelete";
            this.Text = "ManagerDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ManagerDelete;
        private System.Windows.Forms.TextBox textBox_ManagerId;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_managerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_managerPhone;
        private System.Windows.Forms.Label label5;
    }
}