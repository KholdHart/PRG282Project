using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemsProject
{
    internal class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public Student(int studentID, string name, int age, string course)
        {
            this.StudentID = studentID;
            this.Name = name;
            this.Age = age;
            this.Course = course;
        }

        /*public int createStudentID()
        {
          
        }*/
        
    }
}
