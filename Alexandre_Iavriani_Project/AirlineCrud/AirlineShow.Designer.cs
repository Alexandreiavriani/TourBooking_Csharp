namespace Alexandre_Iavriani_Project.AirlineCrud
{
    partial class AirlineShow
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
            this.dataGridView_Airline = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Airline)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Airline
            // 
            this.dataGridView_Airline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Airline.Location = new System.Drawing.Point(87, 161);
            this.dataGridView_Airline.Name = "dataGridView_Airline";
            this.dataGridView_Airline.Size = new System.Drawing.Size(457, 195);
            this.dataGridView_Airline.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(278, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Airlines";
            // 
            // AirlineShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.dataGridView_Airline);
            this.Controls.Add(this.label1);
            this.Name = "AirlineShow";
            this.Text = "AirlineShow";
            this.Load += new System.EventHandler(this.AirlineShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Airline)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Airline;
        private System.Windows.Forms.Label label1;
    }
}