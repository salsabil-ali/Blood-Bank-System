using BloodBankManagmentSystem.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Windows.Forms;

namespace BloodBankManagmentSystem.Presentation_Layer
{
    public partial class Form5 : Form
    {
        // Form for filtering and viewing blood units, and displaying summary statistics.
        public Form5()
        {
            InitializeComponent();
            UITheme.Apply(this);
            label1.ForeColor = UITheme.HeaderAccent;

            // Populate the dashboard immediately instead of showing an empty grid
            // and zeroed-out stat cards until "Show All" is clicked.
            LoadAllUnits();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        // Navigates back to the main menu (Form1).
        private void button3_Click(object sender, EventArgs e)
        {
            AppNavigator.ReturnToMenu(this);
        }

        // Executes filtering based on selected blood type and status, updates grid and stats.
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Get values from the two dropdowns
                string selectedType = comboBox1.SelectedItem?.ToString();
                string selectedStatus = comboBox2.SelectedItem?.ToString();

                // 2. Call the BLL
                BloodUnitService service = new BloodUnitService();
                var list = service.GetFilteredUnits(selectedType, selectedStatus);

                // 3. Update Grid and dashboard cards
                UpdateDashboard(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Shows all blood units and updates dashboard counters.
        private void button2_Click(object sender, EventArgs e)
        {
            LoadAllUnits();
        }

        // Loads every blood unit and refreshes the grid + stat cards. Shared by the
        // constructor (so the page isn't blank on open) and the "Show All" button.
        private void LoadAllUnits()
        {
            try
            {
                BloodUnitService service = new BloodUnitService();
                var allData = service.GetAllUnits();
                UpdateDashboard(allData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Refreshes the grid and the four dashboard cards (Total / Available / Used / Expired)
        // from a given list of blood units.
        private void UpdateDashboard(List<BloodBankManagmentSystem.Models.BloodUnit> list)
        {
            dataGridView2.DataSource = list;
            label8.Text = list.Count.ToString();

            label9.Text = list.Count(u => u.Status == "Available").ToString();
            label10.Text = list.Count(u => u.Status == "Used").ToString();
            // The "Expired" card was previously computed from a "Reserved" status that
            // doesn't exist in the data model (BloodUnit.Status is Available/Used/Expired).
            label11.Text = list.Count(u => u.Status == "Expired").ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}