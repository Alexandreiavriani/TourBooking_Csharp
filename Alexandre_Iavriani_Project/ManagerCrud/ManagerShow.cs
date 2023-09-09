using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandre_Iavriani_Project.ManagerCrud
{
    public partial class ManagerShow : Form
    {
        public ManagerShow()
        {
            InitializeComponent();
        }
        Entities3 dbcontext = new Entities3();
        private void ManagerShow_Load(object sender, EventArgs e)
        {
            try
            {

                var res = dbcontext.Manager.Select(i => new
                {
                    ManagerId = i.manager_id,
                    ManagerName = i.name,
                    ManagerLastName = i.lname,
                    ManagerPhone = i.phone



                });
                dataGridView_Manager.DataSource = res.ToList();
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

