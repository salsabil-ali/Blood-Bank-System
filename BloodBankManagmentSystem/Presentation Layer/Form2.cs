using BloodBankManagmentSystem.Business_Logic_Layer;
using BloodBankManagmentSystem.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BloodBankManagmentSystem.Presentation_Layer
{
    public partial class Form2 : Form
    {
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
        public Form2()
        {
            InitializeComponent();
            DisplayDonors();
        }


        
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



        private void button5_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Leave this empty or add your logic here
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
