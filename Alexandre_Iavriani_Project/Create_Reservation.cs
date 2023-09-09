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
    public partial class Create_Reservation : Form
    {
        public Create_Reservation()
        {
            InitializeComponent();
        }

        Entities3 dbcontext = new Entities3();
        private void button_Reservation_Click(object sender, EventArgs e)
        {
            try
            {
                
                Reservation reservation = new Reservation();
             
                reservation.name = textBox_Name.Text;
                reservation.lname = textBox_LastName.Text;
                reservation.personalNumber = Convert.ToInt64(textBox_PersonalNumber.Text);
                reservation.phone = textBox_Phone.Text;
                reservation.country_id = Convert.ToInt32(label9.Text);
                reservation.manager_id = Convert.ToInt32(label10.Text);
                reservation.airline_id= Convert.ToInt32(label11.Text);

                if (textBox_PersonalNumber.TextLength != 11)
                {
                    MessageBox.Show("Invalid PersonalNumber");
                }
                else if (textBox_Phone.TextLength != 9)
                {
                    MessageBox.Show("Invalid Phone");
                }
                else
                {
                    dbcontext.Reservation.Add(reservation);
                    dbcontext.SaveChanges();

                    MessageBox.Show("Add success");
                }
                

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.InnerException.Message);
                MessageBox.Show("Invalid Value");
            }
        }

        private void Create_Reservation_Load(object sender, EventArgs e)
        {
           

        }
      
        private void Create_Reservation_Load_1(object sender, EventArgs e)
        {



            comboBox_Country.DataSource = dbcontext.Country.ToList();
            comboBox_Country.ValueMember = "country_id";
            comboBox_Country.DisplayMember = "name";

            comboBox_Manager.DataSource = dbcontext.Manager.ToList();
            comboBox_Manager.ValueMember = "manager_id";
            comboBox_Manager.DisplayMember = "name";

            comboBox_Airline.DataSource = dbcontext.Airline.ToList();
            comboBox_Airline.ValueMember = "airline_id";
            comboBox_Airline.DisplayMember = "name";

        }


        private void comboBox_Country_SelectedValueChanged(object sender, EventArgs e)
        {
            label9.Text = comboBox_Country.SelectedValue.ToString();
            label9.Hide();
        }

        private void comboBox_Manager_SelectedValueChanged(object sender, EventArgs e)
        {
            label10.Text = comboBox_Manager.SelectedValue.ToString();
            label10.Hide();

        }

        private void comboBox_Airline_SelectedValueChanged(object sender, EventArgs e)
        {
            label11.Text = comboBox_Airline.SelectedValue.ToString();
            label11.Hide();
        }
    }
}
