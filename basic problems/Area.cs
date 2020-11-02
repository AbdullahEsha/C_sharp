using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*String sName = Console.ReadLine();
            Console.WriteLine("Name: " + sName);

            String sId = Console.ReadLine();
            Console.WriteLine("Student ID : " + sId);*/

            /*Console.Write("first number: ");
            string numberOne = Console.ReadLine();
            double One = double.Parse(numberOne);

            Console.Write("second number: ");
            string numberTwo = Console.ReadLine();
            double Two = double.Parse(numberTwo);

            Console.Write("third number: ");
            string numberThree = Console.ReadLine();
            double Three = double.Parse(numberThree);
            
            Console.WriteLine("The sum of the three numbers is: " + (One + Two + Three));*/

            Console.Write("Length : ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Width : ");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;

            Console.WriteLine("The area of the rectangle : " + area + "\nLength = " + length + " and Width = " + width);
        }
    }
}