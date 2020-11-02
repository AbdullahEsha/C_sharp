
using System;


namespace first
{
    public class student
    {
        string name;
        string id;
        Double cgpa;
        string department;
        public void getStudentInformation()
        {
            Console.Write("Enter student name: ");
            name = Console.ReadLine();
            Console.Write("Enter student id: ");
            id = Console.ReadLine();
            Console.Write("Enter student cgpa: ");
            bool check = Double.TryParse(Console.ReadLine(), out cgpa);
            if (!check) Console.WriteLine("Invalid input");
            Console.Write("Enter student department: ");
            department = Console.ReadLine();
        }
        public void printStudentDetails(string first, string second, string birthdate)
        {
            Console.WriteLine("{0} {1} was born on {2}", first, second, birthdate);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("CGPA: " + cgpa);
            Console.WriteLine("Department: " + department);
        }
        public void validateBirthDate()
        {
            try
            {
                NotImplementedException e = new NotImplementedException();
                throw e;
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("Birthdate can not be validate at current moment");
            }
        }
    }
    class second
    {
        
        static void Main(string[] args)
        {
            student s = new student();
            s.getStudentInformation();
            s.printStudentDetails("Abdullah", "Isha", "14 November, 1998");
            s.validateBirthDate();
        }
    }
}