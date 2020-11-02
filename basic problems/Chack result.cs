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
            int marks;

            //bool b = Int32.TryParse(Console.ReadLine(), out width);
            if (Int32.TryParse(Console.ReadLine(), out marks))
            {
                if ( marks>=94 && marks<=100)
                    Console.WriteLine("A+");
                else if( marks>=90 && marks<=93)
                    Console.WriteLine("A");
                else if (marks >= 85 && marks <= 89)
                    Console.WriteLine("A-");
                else if (marks >= 80 && marks <= 84)
                    Console.WriteLine("B+");
                else if (marks >= 75 && marks <= 79)
                    Console.WriteLine("B");
                else if (marks >= 0 && marks <= 74)
                    Console.WriteLine("F");
                else
                    Console.WriteLine("out of range");
            }
            else
         
                Console.WriteLine("Input is invalide");
            
        }
        
    }
}