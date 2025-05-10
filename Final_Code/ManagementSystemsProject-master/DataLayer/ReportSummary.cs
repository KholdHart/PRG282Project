using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ManagementSystemsProject.Forms;
using ManagementSystemsProject.DataLayer;
using System.IO.Ports;

namespace ManagementSystemsProject.DataLayer
{
    public class ReportSummary
    {
        private string path;

        public ReportSummary(string path = @"students.txt")
        {
            this.path = path;
            FileExists();
        }

        private void FileExists()
        {
            try
            {
                string directoryPath = Path.GetDirectoryName(path);
                if (Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                if (!File.Exists(path))
                {
                    Console.WriteLine("File does not exist. New one will be created.");
                    File.Create(path).Close();

                    File.WriteAllText(path, "StudentID, Name, Age, Course");
                }
            } 
            catch (Exception ex) 
            {
                Console.WriteLine("Error creating file: " + ex.Message);
            }
        }

        public int TotalStudents()
        {
            try
            {
                string[] lines = File.ReadAllLines(path).Skip(1).ToArray();
                return lines.Length;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error calculating total number of students: " + ex.Message);
                return 0;

            }
        }

        public double AvgAge()
        {
            try
            {
                string[] lines = File.ReadAllLines (path).Skip(1).ToArray();

                List<int> ages = new List<int>();

                foreach (string line in lines)
                {
                    if(string.IsNullOrWhiteSpace(line)) continue;

                    string[] parts = line.Split(',');

                    if (parts.Length < 4 || !int.TryParse(parts[2], out int age))
                    {
                        Console.WriteLine("Skipping line: " + line);
                        continue;
                    }
                    ages.Add(age);
                }

                return ages.Any() ? ages.Average() : 0;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("An error occurred while calculating the average age: " + ex.Message);
                return 0;
            }
        }
    }

}
