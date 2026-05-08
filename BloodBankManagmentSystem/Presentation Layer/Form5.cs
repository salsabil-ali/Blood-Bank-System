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
            Form1 main = new Form1();
            main.Show();
            this.Close();
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

                // 3. Update Grid
                dataGridView2.DataSource = list;
                label8.Text = list.Count.ToString();

                label9.Text = list.Count(u => u.Status == "Available").ToString();
                label10.Text = list.Count(u => u.Status == "Used").ToString();
                label11.Text = list.Count(u => u.Status == "Reserved").ToString();

                // 4. Update the "Total Units" box for this specific search
                panel1.Text = list.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Shows all blood units and updates dashboard counters.
        private void button2_Click(object sender, EventArgs e)
        {
            

            try
            {
                BloodUnitService service = new BloodUnitService();
                var allData = service.GetAllUnits();

                // 1. Update the Grid
                dataGridView2.DataSource = allData;

                // 2. Update the Dashboard Boxes (This is the part you were missing)
                label8.Text = allData.Count.ToString();

                label9.Text = allData.Count(u => u.Status == "Available").ToString();
                label10.Text = allData.Count(u => u.Status == "Used").ToString();
                label11.Text = allData.Count(u => u.Status == "Reserved").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
