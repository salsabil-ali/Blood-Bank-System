using BloodBankManagmentSystem.Business_Logic_Layer;
using BloodBankManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace BloodBankManagmentSystem.Presentation_Layer
{
    public partial class Form4 : Form
    {
        // Form for managing blood requests: create, search, delete, approve and view details.
        // 1. Declare the service at the class level
        private RequestService requestService = new RequestService();
        public Form4()
        {
            InitializeComponent();
            UITheme.Apply(this);
            label7.ForeColor = UITheme.HeaderAccent;

            // Add this line here to manually link the event
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);

            // Also ensure this property is set so you can select the whole row
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;

            // Load the current requests right away instead of showing an empty grid
            // until the user searches or presses "Show All".
            LoadAllRequests();
        }

        // Loads every request into the top grid. Shared by the constructor and "Show All".
        private void LoadAllRequests()
        {
            try
            {
                dataGridView1.DataSource = requestService.GetAllRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading requests: " + ex.Message);
            }
        }

        // Data loading now happens in the constructor via LoadAllRequests(), so the
        // form doesn't open with an empty grid. These Load handlers are kept only
        // because the designer still references one of them.
        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Check if the user clicked a valid row (not the header)
                if (e.RowIndex >= 0)
                {
                    // 1. Get the Request ID from the selected row in the TOP grid
                    // Note: Make sure "Request_ID" matches the property name in your BloodRequest model
                    var selectedIdValue = dataGridView1.Rows[e.RowIndex].Cells["Request_ID"].Value;

                    if (selectedIdValue != null)
                    {
                        int selectedRequestId = Convert.ToInt32(selectedIdValue);

                        // 2. Sync the ID to the textbox (so you can Delete or Approve easily)
                        textBox3.Text = selectedRequestId.ToString();

                        // 3. Fetch the allocation details for this specific request
                        var details = requestService.GetRequestDetails(selectedRequestId);

                        // 4. Bind the details to the BOTTOM grid
                        dataGridView2.DataSource = null; // Clear old data first
                        dataGridView2.DataSource = details;

                        if (details == null || details.Count == 0)
                        {
                            MessageBox.Show("No specific units have been allocated to this request yet.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading allocation details: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AppNavigator.ReturnToMenu(this);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Handles Add Request button: maps UI fields to model and creates a new request via service.
        // NOTE: Request ID lives in textBox3 and Hospital ID lives in textBox1 (matching the
        // visible label layout and the Search handler below) - these were previously swapped,
        // which silently saved every new request with Request ID and Hospital ID reversed.
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                BloodRequest req = new BloodRequest
                {
                    Request_ID = int.Parse(textBox3.Text),
                    Request_Date = dateTimePicker1.Value,
                    Blood_Type = comboBox2.Text,
                    Quantity_Requested = int.Parse(textBox2.Text),
                    Hospital_ID = int.Parse(textBox1.Text)
                };

                requestService.CreateRequest(req);
                MessageBox.Show("Blood Request added successfully!");

                // Refresh main grid
                LoadAllRequests();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        // Handles Search Request button: searches by ID and displays the result in the grid.
        private void button6_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox6.Text, out int id))
            {
                var result = requestService.SearchRequest(id);
                if (result != null)
                {
                    // Sync TextBoxes with found data
                    textBox3.Text = result.Request_ID.ToString();
                    textBox2.Text = result.Quantity_Requested.ToString();
                    textBox1.Text = result.Hospital_ID.ToString();
                    comboBox2.Text = result.Blood_Type;
                    dateTimePicker1.Value = result.Request_Date;

                    dataGridView1.DataSource = new List<BloodRequest> { result };
                }
                else
                {
                    MessageBox.Show("No request found with that ID.");
                }
            }
        }

        // Handles Delete Request button: deletes a request after confirmation and refreshes the list.
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBox3.Text, out int id))
                {
                    MessageBox.Show("Please enter or select a valid Request ID to delete.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this request?",
                    "Confirm Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    requestService.DeleteRequest(id);

                    ClearRequestFields();
                    LoadAllRequests();
                    MessageBox.Show("Request deleted successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Failed: " + ex.Message);
            }
        }

        // Resets the request form input fields and clears details grid.
        private void button5_Click_1(object sender, EventArgs e)
        {
            ClearRequestFields();
        }

        private void ClearRequestFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox2.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            dataGridView2.DataSource = null;
        }


        // Shows all requests in the grid and clears the search textbox.
        private void button7_Click(object sender, EventArgs e)
        {
            LoadAllRequests();
            textBox6.Clear();
        }

        // Triggered whenever a row is selected in the TOP grid
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Get the row
                    DataGridViewRow row = dataGridView1.SelectedRows[0];

                    // Get ID from the first cell (index 0) if "Request_ID" name is missing
                    var idValue = row.Cells[0].Value;

                    if (idValue != null)
                    {
                        int selectedId = Convert.ToInt32(idValue);
                        textBox3.Text = selectedId.ToString();

                        // Fetch and Load
                        var details = requestService.GetRequestDetails(selectedId);
                        dataGridView2.DataSource = null;
                        dataGridView2.DataSource = details;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        // Loads and displays the details (allocated units) for the selected request in the bottom grid.
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Get ID from the clicked row
                    int selectedRequestId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Request_ID"].Value);

                    // Update TextBoxes for editing
                    textBox3.Text = selectedRequestId.ToString();

                    // Fill the BOTTOM grid with unit allocation details
                    var details = requestService.GetRequestDetails(selectedRequestId);
                    dataGridView2.DataSource = details;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading allocation details: " + ex.Message); }
        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }





        private void Form4_Load_1(object sender, EventArgs e)
        {

        }
    }
}