using GPA_Calculator_Console_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator_Console_App.Implementation
{
    public class GradePoints
    {
        public static void CalculateGradePoints()
        {
            GetInputs getInputs = new();
            Console.WriteLine("Calculate");

            foreach (var item in getInputs.courses)
            {
                Console.WriteLine($"Title: {item?.CourseTitle} -- Grade: {item?.CourseScore}");
            }
        }
    }
}
