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
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void bunifuTextbox2_OnTextChange(object sender, EventArgs e)
        {

            if (usernamel.text != "" || passwordl.text != "")
            {
                login.Enabled = true;
            }

        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }






        private void bunifuTileButton1_Click_2(object sender, EventArgs e)
        {
            string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=edikan;database=car rental;";
            string query = "SELECT * FROM signup WHERE username='" + this.usernamel.text + "' AND password= '" + this.passwordl.text + "'";
            MySqlConnection databaseconnection = new MySqlConnection(connectionstring);
            MySqlCommand commanddatabase = new MySqlCommand(query, databaseconnection);
            commanddatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseconnection.Open();
                reader = commanddatabase.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        
                        mainpage fm = new mainpage();
                        fm.Show();
                        this.Hide();

                        fm.label2.Text = reader.GetString(0);
                        databaseconnection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username/Password", "Login");
                }
                }

                
            catch
            {

            }
            


        } 

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=edikan;database=car rental;";
            string query = "INSERT INTO signup VALUES('" + this.usernames.text + "','" + this.passwords.text + "','" + this.email.text + "')";
            MySqlConnection databaseconnection = new MySqlConnection(connectionstring);
            MySqlCommand commanddatabase = new MySqlCommand(query, databaseconnection);
            commanddatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try{
                databaseconnection.Open();
                reader = commanddatabase.ExecuteReader();
                databaseconnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void usernamel_OnTextChange(object sender, EventArgs e)
        {
            if (usernamel.text != "" && passwordl.text != "")
            {
                login.Enabled = true;
            }
        }

        private void passwords_OnTextChange(object sender, EventArgs e)
        {
            if (usernames.text != "" && passwords.text != ""&& email.text!="")
            {
                signup.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel9_Click(object sender, EventArgs e)
        {

        }
    }
}
