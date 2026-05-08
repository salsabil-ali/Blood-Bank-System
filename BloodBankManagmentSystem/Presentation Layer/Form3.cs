using BloodBankManagmentSystem.Business_Logic_Layer;
using BloodBankManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BloodBankManagmentSystem.Presentation_Layer
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private DonationService donationService = new DonationService();

        private void Form5_Load(object sender, EventArgs e)
        {
            RefreshBloodUnits();
        }

        private void RefreshBloodUnits()
        {
            try
            {
                // This fills the grid on the right of image_60d881.png
                dataGridView1.DataSource = donationService.GetAllBloodUnits();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }



        private void button1_Click(object sender, EventArgs e)
        {
           
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void but6_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            string selectedType = comboBox2.Text;
            DonationService service = new DonationService();

            if (selectedType == "ALL")
            {
                // Now that the DAL is fixed, this will show the Status too!
                dataGridView1.DataSource = service.GetAllBloodUnits();
            }
            else
            {
                dataGridView1.DataSource = service.SearchBloodUnits(selectedType);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
            try
            {
                Donation newDonation = new Donation
                {
                    Donation_ID = int.Parse(textBox1.Text),
                    Donation_Date = dateTimePicker1.Value,
                    Quantity = int.Parse(textBox2.Text),
                    Donor_ID = int.Parse(textBox3.Text)
                };

                donationService.AddDonation(newDonation);
                MessageBox.Show("Donation added successfully!");

                RefreshBloodUnits(); // Refresh to see the new blood unit
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
