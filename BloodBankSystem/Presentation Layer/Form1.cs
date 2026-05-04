using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BloodBankSystem.Models;           // Connects to your Donor class
using BloodBankSystem.DataAccessLayer;
namespace BloodBankSystem.Presentation_Layer

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

    }
    private void btnTest_Click(object sender, EventArgs e)
    {
        try
        {
            DonorDAL dal = new DonorDAL();
            List<Donor> donors = dal.GetAllDonors();

            // If you have a DataGridView named dgDonors
            dgDonors.DataSource = donors;

            MessageBox.Show($"Success! Retrieved {donors.Count} donors from Hemo Globe Database.");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
