using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        enum userType
        {
            Admin,
            Student = 5,
            faculty
        }

        static void Main(string[] args)
        {
            string utype = userType.Student.ToString();
            string utype1 = userType.faculty.ToString();
            int utype2 = (int)userType.Admin;
            int utype3 = (int)userType.faculty;

            Console.WriteLine(utype);
            Console.WriteLine(utype2);
            Console.WriteLine(utype1);
            Console.WriteLine("supti:" + utype3);
        }
    }
}