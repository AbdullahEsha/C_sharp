
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, c;

            Console.WriteLine("Enter 1st value. ");

            if (Int32.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Enter 2nd value. ");

                if (Int32.TryParse(Console.ReadLine(), out b))
                {

                    Console.WriteLine("Enter 1 to Addition.");
                    Console.WriteLine("Enter 2 to Subtraction.");
                    Console.WriteLine("Enter 3 to Division.");
                    Console.WriteLine("Enter 4 to Multiplicaion.");

                    switch (Int32.TryParse(Console.ReadLine(), out c))
                    {
                        case 1:
                            Console.WriteLine("Addition Of Two Numbers : " + (a + b));
                            break;
                        case 2:
                            Console.WriteLine("Subtraction Of Two Numbers : " + (a - b));
                            break;
                        case 3:
                            Console.WriteLine("Division Of Two Numbers : " + (a / b));
                            break;
                        case 4:
                            Console.WriteLine("Multiplicaion Of Two Numbers : " + (a * b));
                            break;

                        default:
                            Console.WriteLine("Choose Only 1 To 4 ");
                            break;
                    }
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
}