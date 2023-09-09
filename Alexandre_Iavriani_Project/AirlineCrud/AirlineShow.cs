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
    public partial class AirlineShow : Form
    {
        public AirlineShow()
        {
            InitializeComponent();
        }
        Entities3 dbcontext = new Entities3();
        private void AirlineShow_Load(object sender, EventArgs e)
        {
            try
            {
                var res = dbcontext.Airline.Select(i => new
                {
                    Airline = i.airline_id,
                    AirlineName = i.name,
                    AirlinePhone= i.phone,


                });
                dataGridView_Airline.DataSource = res.ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
