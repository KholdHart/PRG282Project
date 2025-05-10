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
using ManagementSystemsProject.DataLayer;

namespace ManagementSystemsProject.Forms
{
    public partial class Delete : Form
    {

        public static readonly string filepath = @"students.txt";
        public Delete()
        {
            InitializeComponent();
        }


        private void LoadStudentData()
        {
            var students = FileHandler.GetAllStudents();
            dataGridView1.DataSource = students;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                textBox1.Text = selectedRow.Cells["StudentID"].Value.ToString();
            }
        }



        private void btnUpdate1_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox1.Text, out int studentId))
            {
                // Confirm before deletion
                var result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Delete the student from the file
                        FileHandler.DeleteStudent(studentId);
                        MessageBox.Show("Student deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh DataGridView
                        LoadStudentData();

                        // Clear the text box after deletion
                        textBox1.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Student ID. Please select a student to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btncBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }
    }
    
}