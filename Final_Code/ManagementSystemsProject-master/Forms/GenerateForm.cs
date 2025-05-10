using ManagementSystemsProject.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystemsProject.Forms
{
    public partial class GenerateForm : Form
    {

        public GenerateForm()
        {
            InitializeComponent();

            dgvTotal.Columns.Add("Description", "Description");
            dgvTotal.Columns.Add("Value", "Value");

       
            dgvAverage.Columns.Add("Description", "Description");
            dgvAverage.Columns.Add("Value", "Value");
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            string path = @"students.txt";
            try
            {
                ReportSummary summary = new ReportSummary(path);

                int totalStudents = summary.TotalStudents();
                dgvTotal.Rows.Add("TotalStudents", totalStudents);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAvgAge_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvTotal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAvgAge_Click_1(object sender, EventArgs e)
        {
            string path = @"students.txt";

            try
            {
                ReportSummary summary = new ReportSummary(path);

                dgvAverage.Rows.Clear();

                double avgAge = summary.AvgAge();
                dgvAverage.Rows.Add("Average age", avgAge.ToString("F2"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
