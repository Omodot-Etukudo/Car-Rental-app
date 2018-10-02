using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_2
{
    public partial class mainpage : Form
    {
        private string vehicle;
        

        
        public mainpage()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }
        
        //Animation
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            label4.Text = label2.Text;
            firstpanel.Visible = false;
            nextpanel.Visible = false;
            bunifuTransition1.ShowSync(nextpanel, false, null);
            
            
            

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

            nextpanel.Visible = false;
            
            bunifuTransition1.ShowSync(firstpanel, false, null);
            bunifuTransition2.ShowSync(nextpanel, false, null);

        }

        private void firstpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        
        //cars
        
        private void mercedes_Click_1(object sender, EventArgs e)
        {
            vehicle = mercedest.Text;
            this.desc.Text = "Model: 4Matic 2016 \nTransmission: Automatic \nMax. Passengers: 4 \nFuel Usage: 9-11 L/100km \nPrice: 5000 Naira/day \nAdditional Information: Air Conditioning, Audio System";
        }

        private void audi_Click(object sender, EventArgs e)
        {
            vehicle = audit.Text;
            this.desc.Text = "Model: A3 Saloon 2016 \nTransmission: Manual \nMax. Passengers: 4 \nFuel Usage: 10-13 L/100km \nPrice: 5000 Naira/day \nAdditional Information: Air Conditioning, Audio System";
        }
       

        private void bmw_Click_1(object sender, EventArgs e)
        {
            vehicle = bmwt.Text;
            this.desc.Text = "Model: M2 2015 \nTransmission: Automatic \nMax. Passengers: 4 \nFuel Usage: 9-11 L/100km \nPrice: 6000 Naira/day \nAdditional Information: Air Conditioning, Audio Surround System";
        }

        private void volkswagen_Click_1(object sender, EventArgs e)
        {
            vehicle = tiguant.Text;
            this.desc.Text = "Model: Tiguan 2013 \nTransmission: Automatic \nMax. Passengers: 4 \nFuel Usage: 8-10 L/100km \nPrice: 5500 Naira/day \nAdditional Information: Air Conditioning, Audio System, Cruise Control";
        }

        private void chevrolet_Click_1(object sender, EventArgs e)
        {
            vehicle = chevrolett.Text;
            this.desc.Text = "Model: Camaro 2010 \nTransmission: Manual \nMax. Passengers: 1 \nFuel Usage: 12-15 L/100km \nPrice: 9000 Naira/day \nAdditional Information: Air Conditioning, Audio System, Power Steering";
        }

        private void kia_Click(object sender, EventArgs e)
        {
            vehicle = kiat.Text;
            this.desc.Text = "Model: Rio 2017 \nTransmission: Automatic \nMax. Passengers: 3 \nFuel Usage: 7-10 L/100km \nPrice: 6000 Naira/day \nAdditional Information: Air Conditioning, Audio Surround System";
        }

        private void sienna_Click_1(object sender, EventArgs e)
        {
            vehicle = siennat.Text;
            this.desc.Text = "Model: Sienna 2016 \nTransmission: Automatic \nMax. Passengers: 6 \nFuel Usage: 11-13 L/100km \nPrice: 7500 Naira/day \nAdditional Information: Air Conditioning, Audio System, Central Locking";

        }

        private void tundra_Click_1(object sender, EventArgs e)
        {
            vehicle = tundrat.Text;
            this.desc.Text = "Model: Tundra 2017 \nTransmission: Manual \nMax. Passengers: 5 \nFuel Usage: 13-16 L/100km \nPrice: 7500 Naira/day \nAdditional Information: Air Conditioning, Audio System, 4 Wheel Drive, Power Steering";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            payment pm = new payment(vehicle, Convert.ToString(bunifuDatepicker1.Value), Convert.ToString(bunifuDatepicker2.Value), bunifuDropdown1.selectedValue, label2.Text);
            pm.Show();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = label2.Text;
        }

        private void bmwt_Click(object sender, EventArgs e)
        {

        }

        //Continuation

    }
}
