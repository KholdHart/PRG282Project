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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void LoadStudentData()
        {
            List<Student> students = FileHandler.GetAllStudents();
            dataGridView1.DataSource = students;  // Bind student list to the DataGridView
        }


        // Event handler: Load selected student details into text boxes
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Ensure only one row is selected
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                textBox1.Text = row.Cells["StudentID"].Value.ToString(); // Student ID (read-only)
                textBox2.Text = row.Cells["Name"].Value.ToString();
                textBox5.Text = row.Cells["Age"].Value.ToString();
                textBox3.Text = row.Cells["Course"].Value.ToString();
            }

        }




        private void btnUpdate1_Click(object sender, EventArgs e)
        {

            try
            {
                // Create updated student object from input fields
                var updatedStudent = new Student(int.Parse(textBox1.Text), textBox2.Text, int.Parse(textBox5.Text), textBox3.Text);
                // Update student in file
                FileHandler.UpdateStudent(updatedStudent);

                // Refresh DataGridView with updated data
                LoadStudentData();
                MessageBox.Show("Student details updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ConfigureDataGridView()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Select the full row
            dataGridView1.MultiSelect = false; // Disable multi-row selection
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged; // Handle selection change event
        }

        private void UpdateForm_Load_1(object sender, EventArgs e)
        {
            LoadStudentData();
            FileHandler.ViewStudent();
            ConfigureDataGridView();
        }

        private void btncBack_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
        }
    }
}
