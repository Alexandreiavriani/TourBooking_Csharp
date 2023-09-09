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
    public partial class AirlineCreate : Form
    {
        public AirlineCreate()
        {
            InitializeComponent();
        }
        Entities3 dbcontext = new Entities3();
        private void button_CreateAirline_Click(object sender, EventArgs e)
        {
            try
            {

                Airline airline = new Airline();
                airline.name = textBox_airlineName.Text;
            
                if (textBox_airlinePhone.TextLength != 9)
                {
                    MessageBox.Show("Invalid phone");
                }
                else
                {
                    airline.phone = textBox_airlinePhone.Text;
                    dbcontext.Airline.Add(airline);
                    dbcontext.SaveChanges();

                    MessageBox.Show("Add success");
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("Error");
            }
        }
    }
}
