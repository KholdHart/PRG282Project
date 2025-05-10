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
    public partial class ViewForm : Form
    {

        public ViewForm()
        {
            InitializeComponent();
        }

        /*private void LoadStudentData()
        {
            try
            {
                List<Student> students = FileHandler.GetAllStudents();
                dataGridView3.DataSource = students;  // Bind the list of students to the DataGridView
            }
            catch (Exception ex)
            {

            }
        }*/
            private void btnBack2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DataTable table = new DataTable();
        private void ViewForm_Load(object sender, EventArgs e)
        {
            //LoadStudentData();
            /*table.Columns.Add("StudentID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Age", typeof(int));
            table.Columns.Add("Course", typeof(string));*/

            dataGridView3.DataSource = FileHandler.ViewStudent();


        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
