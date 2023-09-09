using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alexandre_Iavriani_Project.CountryCrud;
using Alexandre_Iavriani_Project.ManagerCrud;
using Alexandre_Iavriani_Project.AirlineCrud;

namespace Alexandre_Iavriani_Project
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }
        Entities3 dbcontext = new Entities3();

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CountryShow show = new CountryShow();
            show.Show();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CountryCreate create = new CountryCreate();
            create.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CountryDelete delete = new CountryDelete();
            delete.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CountryUpdate update = new CountryUpdate();
            update.Show();
        }


        //manager


        private void showToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManagerShow show = new ManagerShow();
            show.Show();
        }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManagerCreate create = new ManagerCreate();
            create.Show();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManagerDelete delete = new ManagerDelete();
            delete.Show();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManagerUpdate update = new ManagerUpdate();
            update.Show();
        }


        //Airline

        private void showToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AirlineShow show = new AirlineShow();
            show.Show();
        }

        private void createToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AirlineCreate create = new AirlineCreate();
            create.Show();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AirlineDelete delete =new  AirlineDelete();
            delete.Show();
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AirlineUpdate update = new AirlineUpdate();
            update.Show();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            try
            {


                var res = dbcontext.Reservation.Select(i => new
                {
                    UserId = i.reservation_id,
                    Name = i.name,
                    LastName=i.lname,
                    PersonalNumber=i.personalNumber,
                    Phone=i.phone,
                    CountryId=i.country_id,
                    ManagerId=i.manager_id,
                    AirlineId=i.airline_id
                    
                   

                });

               

                if (string.IsNullOrEmpty(textBox_searchUsers.Text))
                {
                    dataGridView_Search.DataSource = res.ToList();
                  
                }
                else
                {
                    var search = res.Where(i => i.Name.Contains(textBox_searchUsers.Text) ||
                     i.LastName.Contains(textBox_searchUsers.Text) || i.PersonalNumber.ToString().Contains(textBox_searchUsers.Text)).ToList();
                    dataGridView_Search.DataSource = search;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_DeleteUser_Click(object sender, EventArgs e)
        {
            UserDelete delete = new UserDelete();
            delete.Show();
        }
    }
    }

