using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator_Console_App.Implementation
{
    public class Application
    {
        public void Run()
        {
            GetInputs headers = new GetInputs();
            headers.HomeHeaders();
            headers.GetStudentInfo();
            headers.GetCourseInfo();
            headers.AddCourses();
        }
    }
}
