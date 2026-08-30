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
        // Form to manage donations and blood units; handles adding donations and filtering/searching units.
        public Form3()
        {
            InitializeComponent();
            UITheme.Apply(this);
            label1.ForeColor = UITheme.HeaderAccent;

            // Load the current blood units right away instead of showing an empty
            // grid until the user touches the filter.
            RefreshBloodUnits();
        }
        private DonationService donationService = new DonationService();

        // Form load handler: refreshes displayed blood units when the form opens.
        private void Form5_Load(object sender, EventArgs e)
        {
            RefreshBloodUnits();
        }

        // Reloads blood units from the service and binds them to the grid.
        private void RefreshBloodUnits()
        {
            try
            {
                // This fills the grid on the right of image_60d881.png
                dataGridView1.DataSource = donationService.GetAllBloodUnits();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }



        // Placeholder for button1 click handler; reserved for future functionality.
        private void button1_Click(object sender, EventArgs e)
        {

        }



        // Placeholder for button2 click handler; reserved for future functionality.
        private void button2_Click(object sender, EventArgs e)
        {

        }

        // Navigates back to the main form when the back button is clicked.
        private void but6_Click(object sender, EventArgs e)
        {
            AppNavigator.ReturnToMenu(this);
        }

        // Event handler for blood type selection change; currently unused.
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Applies the selected blood type filter and updates the grid with matching units.
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

        // Handles Add Donation button: validates inputs, creates Donation model and saves it.
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

        // Click handler for label5; currently unused.
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}