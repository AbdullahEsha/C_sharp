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
            int length, width, area;
            //bool b = Int32.TryParse(Console.ReadLine(), out width);
            if (Int32.TryParse(Console.ReadLine(), out length))
            {
               //b = Int32.TryParse(Console.ReadLine(), out width);
                if (Int32.TryParse(Console.ReadLine(), out width))
                {
                    area = length * width;
                    Console.WriteLine("The area of the rectangle : " + area + "\nLength = " + length + " and Width = " + width);

                }
                else
                {
                    Console.WriteLine("Second input is invalide");
                }
            }
            else
            {
                Console.WriteLine("First input is invalide");
            }
        }
    }
}s