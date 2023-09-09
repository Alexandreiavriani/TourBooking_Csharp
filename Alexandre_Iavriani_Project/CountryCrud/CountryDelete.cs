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
    public partial class CountryDelete : Form
    {
        public CountryDelete()
        {
            InitializeComponent();
        }
        Entities3 dbcontext = new Entities3();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int countryId = int.Parse(textBox_CountryId.Text);
                Country country = dbcontext.Country.Where(i => i.country_id == countryId).First();
                dbcontext.Country.Remove(country);
                dbcontext.SaveChanges();

                MessageBox.Show("Delete successfully");

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.Message);

            }
        }

        private void textBox_CountryId_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox_CountryId.Text))
                {
                    int countryId;
                    if (int.TryParse(textBox_CountryId.Text, out countryId))
                    {
                        Country country = dbcontext.Country.Where(i => i.country_id == countryId).FirstOrDefault();
                        if (country != null)
                        {

                            textBox_countryName.Text = country.name;
                            textBox_CountryPrice.Text = country.price.ToString();



                            textBox_CountryId.ReadOnly = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_CountryId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_CountryPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_countryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
