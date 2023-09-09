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
    public partial class ManagerUpdate : Form
    {
        public ManagerUpdate()
        {
            InitializeComponent();
        }

        Entities3 dbcontext = new Entities3();
        private void button_ManagerUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int managerId = int.Parse(textBox_ManagerId.Text);
                Manager manager = dbcontext.Manager.Where(i => i.manager_id == managerId).First();

                manager.name = textBox_managerName.Text;
                manager.lname = textBox_LastName.Text;
                manager.phone = textBox_managerPhone.Text;

                dbcontext.SaveChanges();

                MessageBox.Show("Edit successfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_ManagerId_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox_ManagerId.Text))
                {
                    int managerId;
                    if (int.TryParse(textBox_ManagerId.Text, out managerId))
                    {
                        Manager manager = dbcontext.Manager.Where(i => i.manager_id == managerId).FirstOrDefault();
                        if (manager != null)
                        {
                            textBox_managerName.Text = manager.name;
                            textBox_LastName.Text = manager.lname;
                            textBox_managerPhone.Text = manager.phone;




                            textBox_ManagerId.ReadOnly = true;
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
