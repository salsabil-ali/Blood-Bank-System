using BloodBankManagmentSystem.Business_Logic_Layer;
using BloodBankManagmentSystem.Data_Access_Layer;
using BloodBankManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BloodBankManagmentSystem.Presentation_Layer
{
    public partial class Form2 : Form
    {
        // Form used to manage Donors: add, update, delete, search and display donor records.
        // Loads donors from the service and binds them to the DataGridView.
        private void DisplayDonors()
        {
            try
            {
                // 1. Call the BLL instead of the DAL
                DonorService service = new DonorService();
                var list = service.GetAllDonors();

                // 2. Bind the list to the Grid
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                }
                else
                {
                    MessageBox.Show("No data returned from the Service.");
                }
            }
            catch (Exception ex)
            {
                // This will catch any DB connection issues or logic errors
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Initializes the form and loads donor list on startup.
        public Form2()
        {
            InitializeComponent();
            DisplayDonors();
        }

        // Event handler for changes in the ID textbox; currently unused.
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        // Click handler for label2; currently unused.
        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Click handler for label8; currently unused.
        private void label8_Click(object sender, EventArgs e)
        {

        }

        // Grid cell content click handler; reserved for future logic.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Event handler for donor name textbox changes; currently unused.
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        // Click handler for label9; currently unused.
        private void label9_Click(object sender, EventArgs e)
        {

        }

        // Form load event for Form2; currently unused (initialization done in constructor).
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Close();
        }

        // Alternate grid cell content click handler; currently unused.
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Handles custom formatting for grid cells; currently empty.
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Leave this empty or add your logic here
        }

        // Handles the Update button click: maps UI to model and calls service to update donor.
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Donor donor = new Donor
                {
                    Donor_ID = int.Parse(textBox2.Text),
                    Name = textBox3.Text,
                    Phone_Number = textBox4.Text,
                    Address = textBox5.Text,
                    Gender = comboBox1.SelectedItem?.ToString() // Get gender from UI
                };

                DonorService service = new DonorService();
                service.UpdateDonor(donor);

                MessageBox.Show("Donor updated successfully!");
                LoadDonorsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Failed: " + ex.Message);
            }
        }

        // Handles Clear operation: clears donor data in DB and resets UI fields.
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBox2.Text, out int id))
                {
                    // 1. Clear in Database using your Service function
                    DonorService service = new DonorService();
                    service.ClearDonor(id);

                    // 2. Clear in UI
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    comboBox1.SelectedIndex = -1;
                    comboBox2.SelectedIndex = -1;
                    dateTimePicker1.Value = DateTime.Now;

                    // 3. Refresh Grid
                    LoadDonorsList();
                    MessageBox.Show("Donor data cleared from database.");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        
        }

        // Handles Add operation: maps UI fields to Donor model and creates a new donor via service.
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Map UI to Model
                Donor donor = new Donor
                {
                    Donor_ID = int.Parse(textBox2.Text),
                    Name = textBox3.Text,
                    Gender = comboBox1.SelectedItem?.ToString(),
                    Date_of_Birth = dateTimePicker1.Value,
                    Blood_Type = comboBox2.SelectedItem?.ToString(),
                    Phone_Number = textBox4.Text,
                    Address = textBox5.Text
                };

                // 2. Call Service
                DonorService service = new DonorService();
                service.AddDonor(donor);

                MessageBox.Show("Donor added successfully!");

                // 3. Fix: Refresh the grid correctly
                LoadDonorsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Add this helper method to your Form class
        // Reloads the donor list from service and binds it to the grid.
        private void LoadDonorsList()
        {
            DonorService service = new DonorService();
            dataGridView1.DataSource = service.GetAllDonors();
        }

        // Handles Delete operation: deletes donor after confirmation.
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Confirm the ID is valid
                if (int.TryParse(textBox2.Text, out int id))
                {
                    // Optional: Add a confirmation box so they don't delete by mistake
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this donor?",
                                                        "Confirm Delete", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        DonorService service = new DonorService();
                        service.DeleteDonor(id);

                        MessageBox.Show("Donor deleted successfully.");

                        
                        LoadDonorsList();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid Donor ID to delete.");
                }
            }
            catch (Exception ex)
            {
                // This will trigger if a donor has active donations (Foreign Key error)
                MessageBox.Show("Delete Failed: " + ex.Message);
            }
        }

        // Handles Search operation: looks up donor by ID and populates UI with results.
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBox6.Text, out int id)) // The box next to the glass
                {
                    DonorService service = new DonorService();
                    var donor = service.SearchDonor(id);

                    if (donor != null)
                    {
                        // Fill the textboxes on the left
                        textBox2.Text = donor.Donor_ID.ToString();
                        textBox3.Text = donor.Name;
                        comboBox1.Text = donor.Gender;
                        dateTimePicker1.Value = donor.Date_of_Birth;
                        comboBox2.Text = donor.Blood_Type;
                        textBox4.Text = donor.Phone_Number;
                        textBox5.Text = donor.Address;

                        // Show just this donor in the grid
                        dataGridView1.DataSource = new List<Donor> { donor };
                    }
                    else
                    {
                        MessageBox.Show("Donor not found.");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        // Shows all donors in the grid and clears the search box.
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                DonorService service = new DonorService();
                var allDonors= service.GetAllDonors();

                // 1. Update the grid
                dataGridView1.DataSource = allDonors ;

                // 2. Optional: Clear the search textbox if you have one
                textBox6.Clear();

                // 3. Optional: If you want to show a count
                // MessageBox.Show($"Showing all {allHospitals.Count} hospitals.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Donors: " + ex.Message);
            }
        }

        // Event handler for the search textbox; currently unused.
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
