using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Car_Rental_2
{
    public partial class payment : Form
    {
        private string vehicle;
        private string pickup;
        private string returnd;
        private string location;
        private string name;
        public payment(string veh,string pick,string ret,string loc,string nm)
        {
            vehicle = veh;
            pickup = pick;
            returnd = ret;
            location = loc;
            name = nm;
            InitializeComponent();
        }

        

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mastercard_Click(object sender, EventArgs e)
        {
            mastercard.Width = 98;
            mastercard.Height = 62;

            verve.Width = 89;
            verve.Height = 53;

            visa.Width = 89;
            visa.Height = 53;
        }

        private void verve_Click(object sender, EventArgs e)
        {
            mastercard.Width = 89;
            mastercard.Height = 53;

            verve.Width = 98;
            verve.Height = 62;

            visa.Width = 89;
            visa.Height = 53;
        }

        private void visa_Click(object sender, EventArgs e)
        {
            mastercard.Width = 89;
            mastercard.Height = 53;

            verve.Width = 89;
            verve.Height = 53;

            visa.Width = 98;
            visa.Height = 62;
        }

        private void cardname_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            
            
            this.Close();
        }

        private void mm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=edikan;database=car rental;";
            string query = "INSERT INTO rented VALUES('" + name + "','" + vehicle + "','" + pickup + "','" + returnd + "','"+location+"')";
            MySqlConnection databaseconnection = new MySqlConnection(connectionstring);
            MySqlCommand commanddatabase = new MySqlCommand(query, databaseconnection);
            commanddatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseconnection.Open();
                reader = commanddatabase.ExecuteReader();
                databaseconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
            
            MessageBox.Show("Transaction Successful", "RenalMatic");
        }

        private void cardname_OnValueChanged_1(object sender, EventArgs e)
        {
            
        }

        private void cvv_OnValueChanged(object sender, EventArgs e)
        {
            if (cardname.Text != "" || cardnumber.Text != "" || cvv.Text != "")
            {
                pay.Enabled = true;
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
