using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator_Console_App.Utils
{
    public class Utils
    {
        public static void Error(string msg)
        {
            Console.Error.WriteLine($"{msg}\n");            
        }

        public static void Success(string msg)
        {
            Console.WriteLine($"{msg}\n");
        }

        public static void Line()
        {
            Console.WriteLine("****************" +
                "**********************");
        }
    }
}
