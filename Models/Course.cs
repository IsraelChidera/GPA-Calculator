using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator_Console_App.Models
{
    public class Course
    {        
        public string? CourseTitle { get; set; }
        public string? CourseScore { get; set; }

        public Course(string CourseTitle, string CourseScore)
        {
            CourseTitle = CourseTitle;
            CourseScore = CourseScore;
        }

        public Course()
        {

        }
    }
}
