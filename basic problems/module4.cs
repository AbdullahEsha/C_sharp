using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{

    public struct Student
    {
        public string name;
        public string id;
        public string birthDate;

        public Student(string name, string id, string birthDate)
        {
            this.name = name;
            this.id = id;
            this.birthDate = birthDate;
        }
    }
    public struct Teacher
    {
        public string name;
        public string department;
        public string birthDate;

        public Teacher(string name, string department, string birthDate)
        {
            this.name = name;
            this.department = department;
            this.birthDate = birthDate;
        }
    }

    public struct uProgram
    {
        public string programName;
        public string departmentHead;
        public string degree;

        public uProgram(string programName, string departmentHead, string degree)
        {
            this.programName = programName;
            this.departmentHead = departmentHead;
            this.degree = degree;
        }
    }

    public struct Course
    {
        public string courseName;
        public float credits;
        public DateTime duration;
        public string teacherName;

        public Course(string courseName, float credits, DateTime duration, string teacherName)
        {
            this.courseName = courseName;
            this.credits = credits;
            this.duration = duration;
            this.teacherName = teacherName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentAr = new Student[5];
            Student st = new Student("Nirab", "18-37551-1", "05/06/1999");
            studentAr[0] = st;

            Console.WriteLine("Student Name: " + studentAr[0].name);
            Console.WriteLine("ID: " + studentAr[0].id);
            Console.WriteLine("Date of Birth: " + studentAr[0].birthDate);

        }
    }
}