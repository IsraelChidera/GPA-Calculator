using GPA_Calculator_Console_App.Interfaces;
using GPA_Calculator_Console_App.Models;
using GPA_Calculator_Console_App.Utils;
using System.ComponentModel;
using System.Text;

namespace GPA_Calculator_Console_App.Implementation
{
    public class GetInputs : IStudentInterface
    {
        public List<Course> courses;
        StringBuilder sb = new StringBuilder();
        Course course = new();

        public void HomeHeaders()
        {
            Utils.Utils.Line();
            Console.WriteLine("I.C. GPA Calculator");
            Utils.Utils.Line();
        }

        public void GetStudentInfo()
        {
            sb.AppendLine("Want to know how far your GPA has been\n" +
                "Get to know today!\nBefore you proceed, Let us get your " +
                "information");

            Console.WriteLine($"{sb}");
            //Student.FullName = Console.ReadLine();



            while (true)
            {
                Console.Write("Enter your full name: ");
                Student.FullName = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(Student.FullName) && Student.FullName.Length >= 3)
                {
                    break;
                }

                Utils.Utils.Error("Invalid inputs...\nInput length should be 3 or more... \nTry again");
            }

            while (true)
            {
                Console.Write("Enter department: ");
                Student.Department = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(Student.Department) && Student.Department.Length >= 3)
                {
                    break;
                }
                Utils.Utils.Error("Invalid inputs...\nDepartment length should be 3 or more... \nTry again");
            }

            
            while (true)
            {
                Console.Write("Enter year of study(in numbers): ");
                Student.YearOfStudy = Console.ReadLine();                
                int numOfYear;

                if (!String.IsNullOrWhiteSpace(Student.YearOfStudy) && int.TryParse(Student.YearOfStudy, out numOfYear) )
                {
                    break;
                }
                Utils.Utils.Error("Invalid inputs...\nYear of study has incorrect inputs... \nTry again");
            }

            Console.Clear();
            Utils.Utils.Success("Congratulations...\nProfile added successfully!");

        }

        public void GetCourseInfo()
        {
            Console.WriteLine("Start adding the courses and scores you have had");
            

            while (true)
            {                
                Console.Write("Enter course title (eg: Bio 101): ");
                course.CourseTitle = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(course.CourseTitle))
                {
                    break;
                }

                Utils.Utils.Error("Invalid inputs...\nInput length should be 3 or more... \nTry again");
            }

            while (true)
            {
                Console.Write($"Enter score gotten in {course.CourseTitle}: ");
                course.CourseScore = Console.ReadLine();                
                int score;

                if (!String.IsNullOrWhiteSpace(course.CourseScore) && int.TryParse(course.CourseScore, out score) && score<=100 )
                {
                    break;
                }
                Utils.Utils.Error("Invalid inputs...\nCourse scores has incorrect inputs... \nTry again");
            }

        }

        public void AddCourses()
        {
            StringBuilder sb2 = new StringBuilder();
             courses = new List<Course>()
            {
                new Course(){CourseTitle = course.CourseTitle, CourseScore= course.CourseScore},
            };

            Utils.Utils.Success("Course record added successfully!");

            while (true)
            {                
                Start: sb2.AppendLine("Do you want to add more course record\nor do " +
                    "you want to go straight to check the grade points\n\nType " +
                    "1: To continue adding courses\nType 0: To check your grade point " +
                    "average");

                Console.WriteLine(sb2);

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        GetCourseInfo();
                        AddCourses();
                        break;
                    case "0":
                        GradePoints.CalculateGradePoints();
                        break;
                    default:
                        Console.WriteLine("Invalid inputs");
                        goto Start;
                }

                break;
            }
            
        }

      




    }
}
