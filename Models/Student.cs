using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator_Console_App.Models
{
    public class Student
    {
        public static string? FullName { get; set; }
        public static string? Department { get; set; }
        public static string? YearOfStudy { get; set; }
        //public int StudentId { get; set;}

        public Student(string FullName, string Department, string YearOfStudy)
        {
            FullName = FullName;
            Department = Department;
            YearOfStudy = YearOfStudy;
        }

        public Student()
        {
            
        }
    }
}
