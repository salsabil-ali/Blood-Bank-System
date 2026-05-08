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
        public Form4()
        {
            InitializeComponent();
        }

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Handles Add Request button: maps UI fields to model and creates a new request via service.
        private void button2_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                // Check which textbox is which based on your Form Design!
                // Based on your UI order: Request ID, Date, Hospital ID, Blood Type, Qty
                BloodRequest req = new BloodRequest
                {
                    Request_ID = int.Parse(textBox1.Text),         // The first box
                    Request_Date = dateTimePicker1.Value,          // The DatePicker
                    Hospital_ID = int.Parse(textBox2.Text),        // The Hospital ID box
                    Blood_Type = comboBox2.Text,                   // The dropdown
                    Quantity_Requested = int.Parse(textBox3.Text)  // The Quantity box
                };

                RequestService service = new RequestService();
                service.CreateRequest(req);

                MessageBox.Show("Request added successfully!");
                dataGridView1.DataSource = service.GetAllRequests(); // Refresh list
            }
            catch (Exception ex) { MessageBox.Show("Check your inputs: " + ex.Message); }
        }
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        // Handles Search Request button: searches by ID and displays the result in the grid.
        private void button6_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox6.Text, out int id))
            {
                var result = new RequestService().SearchRequest(id);
                if (result != null)
                {
                    // Put the single found result into a list so it shows in the grid
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
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    int id = int.Parse(textBox1.Text);
                    var confirm = MessageBox.Show("Delete this request?", "Confirm", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        RequestService service = new RequestService();
                        // Call the correct DAL method for the Request
                        service.DeleteRequest(id);

                        MessageBox.Show("Deleted!");
                        dataGridView1.DataSource = service.GetAllRequests();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
       
        // Resets the request form input fields and clears details grid.
        private void button5_Click_1(object sender, EventArgs e)
        {
            // Just reset the UI controls
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox6.Clear(); // Search box
            comboBox2.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;

            // Clear the bottom details grid too
            dataGridView2.DataSource = null;
        }
        

        // Shows all requests in the grid and clears the search textbox.
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                RequestService service = new RequestService();
                dataGridView1.DataSource = service.GetAllRequests();

                // Optional: clear the search box
                textBox6.Clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // Loads and displays the details (allocated units) for the selected request in the bottom grid.
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // 1. Get the Request ID from the row you just clicked
                if (e.RowIndex >= 0)
                {
                    int selectedRequestId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Request_ID"].Value);

                    // 2. Fetch the details for this specific request
                    RequestService service = new RequestService();
                    var details = service.GetRequestDetails(selectedRequestId);

                    // 3. Put them in the BOTTOM grid (image_705517.png)
                    dataGridView2.DataSource = details;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading details: " + ex.Message); }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Approves a request by updating its status and refreshing the request list.
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Get the Request ID from your UI (textBox1)
                if (int.TryParse(textBox1.Text, out int requestId))
                {
                    // 2. Define the new status (could also come from a ComboBox)
                    string newStatus = "Approved";

                    // 3. Call the Service Layer
                    RequestService service = new RequestService();
                    service.UpdateStatus(requestId, newStatus);

                    MessageBox.Show("Request status updated to " + newStatus);

                    // 4. Refresh the grid to show the change
                    dataGridView1.DataSource = service.GetAllRequests();
                }
                else
                {
                    MessageBox.Show("Please enter a valid Request ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Error: " + ex.Message);
            }
        }
    }
}
