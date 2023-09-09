using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandre_Iavriani_Project
{
    public partial class CountryShow : Form
    {
        public CountryShow()
        {
            InitializeComponent();
        }
        Entities3 dbcontext = new Entities3();

        private void CountryShow_Load(object sender, EventArgs e)
        {
            try
            {
                var res = dbcontext.Country.Select(i => new
                {
                    CountryId = i.country_id,
                    CountryName = i.name,
                    CountryPrice = i.price,


                });
                dataGridView_Country.DataSource = res.ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
