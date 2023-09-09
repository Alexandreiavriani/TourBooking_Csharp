using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandre_Iavriani_Project.CountryCrud
{
    public partial class CountryCreate : Form
    {
        public CountryCreate()
        {
            InitializeComponent();
        }
        Entities3 dbcontext = new Entities3();
        private void button_Create_Click(object sender, EventArgs e)
        {
            try
            {

                Country country = new Country();

                country.name = textBox_countryName.Text;
                country.price = Convert.ToDecimal(textBox_CountryPrice.Text);



                dbcontext.Country.Add(country);
                dbcontext.SaveChanges();

                MessageBox.Show("Add success");

            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Error");
            }
        }
    }
}
