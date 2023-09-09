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
    public partial class ManagerCreate : Form
    {
        public ManagerCreate()
        {
            InitializeComponent();
        }
        Entities3 dbcontext = new Entities3();

        private void button_Create_Click(object sender, EventArgs e)
        {
            try
            {

                Manager manager = new Manager();

                manager.name = textBox_managerName.Text;
                manager.lname = textBox_managerName.Text;
                if(textBox_managerPhone.TextLength !=9)
                {
                    MessageBox.Show("Invalid phone");
                }
                else
                {
                    manager.phone = textBox_managerPhone.Text;
                    dbcontext.Manager.Add(manager);
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
