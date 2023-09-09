using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandre_Iavriani_Project.AirlineCrud
{
    public partial class AirlineDelete : Form
    {
        public AirlineDelete()
        {
            InitializeComponent();
        }
        Entities3 dbcontext = new Entities3();
        private void button_CountryDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int airlineId = int.Parse(textBox_AirlineId.Text);
                Airline airline = dbcontext.Airline.Where(i => i.airline_id == airlineId).First();
                dbcontext.Airline.Remove(airline);
                dbcontext.SaveChanges();

                MessageBox.Show("Delete successfully");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.Message);

            }
        }

        private void textBox_AirlineId_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox_AirlineId.Text))
                {
                    int airlineId;
                    if (int.TryParse(textBox_AirlineId.Text, out airlineId))
                    {
                        Airline airline = dbcontext.Airline.Where(i => i.airline_id == airlineId).FirstOrDefault();
                        if (airline != null)
                        {
                            textBox_AirlineName.Text = airline.name;
                            textBox_AirlinePhone.Text = airline.phone;


                            textBox_AirlineId.ReadOnly = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
