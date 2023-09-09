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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Entities3 dbcontext = new Entities3();


        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {

                if (dbcontext.Users.Where(i => i.users_id==1 && i.name== textBox_userName.Text &&
                i.password == textBox_password.Text).Count()>0 )
                {
                    Create_Reservation create_reservation = new Create_Reservation();
                    create_reservation.Show();
                }
                else if (dbcontext.Users.Where(i => i.users_id == 2 && i.name == textBox_userName.Text &&
               i.password == textBox_password.Text).Count() > 0)
                {
                    AdminMenu admin = new AdminMenu();
                    admin.Show();
                    
                }
                else
                {
                    MessageBox.Show("INVALID USER");
                    textBox_userName.Clear();
                    textBox_password.Clear();
                }

            }
            catch (Exception)
            {

                throw;
            }


        }
        }
    }
