using BloodBankManagmentSystem.Business_Logic_Layer;
using BloodBankManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagmentSystem.Presentation_Layer
{
    public partial class Form6 : Form
    {
        // Form handling hospital UI interactions: add, update, delete, search and display hospitals.
        public Form6()
        {
            InitializeComponent();
        }

        // Handles changes to the address textbox; currently unused but reserved for future validation.
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        // Event fired when the hospital information group box receives focus.
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // Click handler for the Add button: validates input, creates a Hospital and saves via service.
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validation: Make sure the ID is a number and fields aren't empty
                if (!int.TryParse(textBox2.Text, out int id))
                {
                    MessageBox.Show("Please enter a valid numeric Hospital ID.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("Hospital Name is required.");
                    return;
                }

                // 2. Create the Hospital object from the TextBoxes
                Hospital newHospital = new Hospital
                {
                    Hospital_ID = id,
                    Hospital_Name = textBox3.Text,
                    Phone_Number = textBox4.Text,
                    Address = textBox5.Text
                };

                // 3. Call the Service to save to Database
                HospitalService service = new HospitalService();
                service.AddHospital(newHospital);

                // 4. Success feedback and Refresh the Grid
                MessageBox.Show("Hospital added successfully!");

                // Clear the boxes for the next entry
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();

                // Refresh the DataGrid
                LoadHospitalData();
            }
            catch (Exception ex)
            {
                // This will catch things like Duplicate ID errors from SQL
                MessageBox.Show("Add Failed: " + ex.Message);
            }
        }

        // Handles changes to the search textbox for hospitals; currently unused.
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        // Click handler for Update button: builds Hospital object and calls service to update.
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Hospital h = new Hospital
                {
                    Hospital_ID = int.Parse(textBox2.Text),
                    Hospital_Name = textBox3.Text,
                    Phone_Number = textBox4.Text,
                    Address = textBox5.Text
                };

                HospitalService service = new HospitalService();
                service.UpdateHospital(h);
                MessageBox.Show("Hospital updated successfully!");

                // Fix: Call the helper method below
                LoadHospitalData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Failed: " + ex.Message);
            }
        }

        // Add this helper method to your Form class
        private void LoadHospitalData()
        {
            HospitalService service = new HospitalService();
            // This refreshes the grid with the latest data from the database
            dataGridView1.DataSource = service.GetAllHospitals();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
            private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Check if the Hospital ID box has a valid number
                if (int.TryParse(textBox2.Text, out int id))
                {
                    HospitalService service = new HospitalService();
                    service.ClearHospitalData(id);

                    // 2. Clear the UI boxes
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();

                    // 3. Refresh the grid
                    LoadHospitalData();

                    MessageBox.Show("Hospital record data cleared in database.");
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric Hospital ID first.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Clear failed: " + ex.Message);
            }
        }
       

        // Click handler for the search button: searches for a hospital by ID and updates UI.
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validate the ID input
                if (string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    MessageBox.Show("Please enter a Hospital ID to search.");
                    return;
                }

                int id = int.Parse(textBox6.Text);
                HospitalService service = new HospitalService();

                // 2. Get the hospital object
                var h = service.SearchHospital(id);

                if (h != null)
                {
                    // 3. Update the TextBoxes
                    //textBox2.Text = h.Hospital_ID;
                    textBox3.Text = h.Hospital_Name;
                    textBox4.Text = h.Phone_Number;
                    textBox5.Text = h.Address;

                    // 4. Update the Grid (Wrap the single object in a List)
                    List<Hospital> searchResult = new List<Hospital> { h };
                    dataGridView1.DataSource = searchResult;
                }
                else
                {
                    MessageBox.Show("Hospital not found.");
                    // Optional: Clear grid if nothing is found
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message);
            }
        }

        // Click handler for Show All button: loads and displays all hospitals.
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                HospitalService service = new HospitalService();
                var allHospitals = service.GetAllHospitals();

                // 1. Update the grid
                dataGridView1.DataSource = allHospitals;

                // 2. Optional: Clear the search textbox if you have one
                textBox6.Clear();

                // 3. Optional: If you want to show a count
                // MessageBox.Show($"Showing all {allHospitals.Count} hospitals.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading hospitals: " + ex.Message);
            }
        }

        // Navigates back to the main menu (Form1).
        private void button5_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Close();
        }
    }
}
