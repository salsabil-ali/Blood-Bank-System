using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BloodBankManagmentSystem.Presentation_Layer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // button1 = Donor Management
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 myf = new Form2();
            myf.Show();
        }

        // button2 = Donation / Blood Unit
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 myf = new Form3();
            myf.Show();
        }

        // button3 = Hospital Requests
        private void button3_Click(object sender, EventArgs e)
        {
            Form4 myf = new Form4();
            myf.Show();
        }

        // button4 = Inventory (Blood Units)
        private void button4_Click(object sender, EventArgs e)
        {
            Form5 myf = new Form5();
            myf.Show();
        }

        // button5 = Exit
        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

       
        

       

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
