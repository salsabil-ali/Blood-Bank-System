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

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form2 myf = new Form2();
            myf.Show();
            this.Hide();

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Form3 myf = new Form3();
            myf.Show();
            this.Hide();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Form4 myf = new Form4();
            myf.Show();
            this.Hide();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Form5 myf = new Form5();
            myf.Show();
            this.Hide();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       


    }
}
