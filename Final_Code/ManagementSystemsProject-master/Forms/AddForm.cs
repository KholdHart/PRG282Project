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


namespace ManagementSystemsProject
{
    public partial class frmAdd : Form
    {
       

        FileHandler handler = new FileHandler();
        

        public frmAdd()
        {
            InitializeComponent();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            int StudentID = int.Parse(txtID.Text);
            string Name = txtName.Text;
            int Age = int.Parse(txtAge.Text);
            string Course = txtCourse.Text;

            Student student = new Student(StudentID, Name, Age, Course);

            handler.AddStudent(student);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
