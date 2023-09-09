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
    public partial class UserDelete : Form
    {
        public UserDelete()
        {
            InitializeComponent();
        }
        Entities3 dbcontext = new Entities3();
        private void button_DeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                int reservationId = int.Parse(textBox_UserId.Text);
                Reservation reservation = dbcontext.Reservation.Where(i => i.reservation_id == reservationId).First();
                dbcontext.Reservation.Remove(reservation);
                dbcontext.SaveChanges();

                MessageBox.Show("Delete successfully");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.Message);

            }
        }

        private void textBox_UserId_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox_UserId.Text))
                {
                    int reservationId;
                    if (int.TryParse(textBox_UserId.Text, out reservationId))
                    {
                        Reservation reservation = dbcontext.Reservation.Where(i => i.reservation_id == reservationId).FirstOrDefault();
                        if (reservation != null)
                        {
                            textBox_UserName.Text = reservation.name;
                            textBox_UserLname.Text = reservation.lname;
                            textBox_PersonalNumber.Text = reservation.personalNumber.ToString();
                            textBox_PhoneNumber.Text = reservation.phone;
                            textBox_countryid.Text = reservation.country_id.ToString();
                            textBox_managerid.Text = reservation.manager_id.ToString();
                            textBox_airlineid.Text = reservation.airline_id.ToString();


                            textBox_UserId.ReadOnly = true;
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
