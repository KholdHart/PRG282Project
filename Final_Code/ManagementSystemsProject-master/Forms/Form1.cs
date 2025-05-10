using ManagementSystemsProject.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ManagementSystemsProject.Forms;
using ManagementSystemsProject.DataLayer;

namespace ManagementSystemsProject
{
    public partial class frmMain : Form
    {
        FileHandler handler = new FileHandler();
        
        public frmMain()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlProject_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlCore_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd add = new frmAdd();
            add.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewForm viewForm = new ViewForm();
            viewForm.Show();

            FileHandler.ViewStudent();
            
           
        }

        private void btnGenerate_Click_1(object sender, EventArgs e)
        {
            GenerateForm generate = new GenerateForm();
            generate.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();
            updateForm.Show();
        }
    }
}
