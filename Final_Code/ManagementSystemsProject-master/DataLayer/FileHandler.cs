using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Data;


namespace ManagementSystemsProject.DataLayer
{
    internal class FileHandler
    {
       
        public FileHandler() 
        {}

        // "C:\\Users\\{Your windows username}\\source\\repos\\ManagementSystemsProject\\DataLayer\\students.txt";

        public static readonly string filePath = @"students.txt";

        public void AddStudent(Student student) 
        {
            //Error Handling Section
            if (student.Age <= 0)
            {
                MessageBox.Show("Invalid age. Please enter a positive number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check for duplicate StudentID
            if (IsStudentIdDuplicate(student.StudentID))
            {
                MessageBox.Show("A student with this ID already exists. Please use a unique Student ID.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Proceed to add the student
            FileStream fs = new FileStream(filePath, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);


            sw.WriteLine(student.StudentID + "," + student.Name + "," + student.Age + "," + student.Course);

            sw.Close();
            fs.Close();




            try
            {
                MessageBox.Show("Added Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }  
        }

        public static List<Student> GetAllStudents()
        {
            var students = new List<Student>();

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');

                    if (parts.Length == 4)
                    {
                        var student = new Student(int.Parse(parts[0]), parts[1], int.Parse(parts[2]), parts[3]);
                        students.Add(student);
                    }
                }
            }
            else
            {
                throw new FileNotFoundException("The students.txt file was not found.");
            }

            return students;
        }


        public static DataTable ViewStudent()
        {
            DataTable table = new DataTable();

            table.Columns.Add("StudentID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Age", typeof(int));
            table.Columns.Add("Course", typeof(string));

           // dataGridView3.DataSource = table;


            if (File.Exists(filePath))
            {

                //string[] lines = File.ReadAllLines(filePath);

                /*string[] values;

                for (int i = 0; i < lines.Length; i++)
                {
                    values = lines[i].ToString().Split(',');
                    string[] row = new string[values.Length];

                    for (int j = 0; j < values.Length; j++)
                    {
                        row[j] = values[j].Trim();
                    }
                    table.Rows.Add(row);
                }*/
                /*foreach (string line in lines)
                {
                    string[] values = line.Split(',');

                    if (values.Length == table.Columns.Count)
                    {
                        DataRow row = table.NewRow();

                        for(int j = 0; j< values.Length; j++)
                        {
                            row[j] = values[j].Trim();
                        }
                        table.Rows.Add(row);
                    }
                }*/
                FileStream fs = new FileStream(filePath, FileMode.Open);

                StreamReader sr = new StreamReader(fs);
                string line;

                while((line = sr.ReadLine()) != null)
                {
                    /*string id = line.Substring(0, line.IndexOf(",")-1);
                    line.Remove(0, line.IndexOf(","));

                    string name = line.Substring(0, line.IndexOf(",") - 1);
                    line.Remove(0, line.IndexOf(","));

                    string age = line.Substring(0, line.IndexOf(",") - 1);
                    line.Remove(0, line.IndexOf(","));

                    string course = line;

                    DataRow dr = table.NewRow();

                    for(int i = 0; i < 4; i++)
                    {
                        dr
                    }*/

                    string[] fields = line.Split(',');

                    if (fields.Length == 4)
                    {
                        DataRow row = table.NewRow();
                        row["StudentID"] = int.Parse(fields[0].Trim());
                        row["Name"] = fields[1].Trim();
                        row["Age"] = int.Parse(fields[2].Trim());
                        row["Course"] = fields[3].Trim();

                        table.Rows.Add(row);
                    }


                    

                }
                sr.Close();
                fs.Close();

            }
            else
            {
                throw new FileNotFoundException("The students.txt file was not found.");
            }

            return table;
        }

        public static void UpdateStudent(Student updatedStudent)
        {
            if (!File.Exists(filePath)) throw new FileNotFoundException("The students.txt file was not found.");

            var lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                var parts = lines[i].Split(',');
                if (int.Parse(parts[0]) == updatedStudent.StudentID)
                {
                    // Update line with new student details
                    lines[i] = $"{updatedStudent.StudentID},{updatedStudent.Name},{updatedStudent.Age},{updatedStudent.Course}";
                    break;
                }
            }

            // Write updated data back to the file
            File.WriteAllLines(filePath, lines);
        }

        private bool IsStudentIdDuplicate(int studentId)
        {
            if (!File.Exists(filePath))
            {
                return false; // No file exists yet, so no duplicates are possible
            }

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length > 0 && int.TryParse(parts[0], out int existingId) && existingId == studentId)
                {
                    return true; // Duplicate found
                }
            }

            return false; // No duplicate found
        }
        public static void DeleteStudent(int studentId)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("The students.txt file was not found.");
            }

            // Read all lines and filter out the line with the matching student ID
            var lines = File.ReadAllLines(filePath).ToList();
            bool studentFound = false;

            for (int i = 0; i < lines.Count; i++)
            {
                var parts = lines[i].Split(',');
                if (parts.Length == 4 && int.TryParse(parts[0], out int id) && id == studentId)
                {
                    lines.RemoveAt(i); // Remove the line with the matching StudentID
                    studentFound = true;
                    break;
                }
            }

            // Rewrite the file without the deleted student
            if (studentFound)
            {
                File.WriteAllLines(filePath, lines);
            }
            else
            {
                throw new ArgumentException($"Student with ID {studentId} not found.");
            }
        }
    }
}
