
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
            char alphabet = Convert.ToChar(Console.ReadLine());
            if ((alphabet >= 'A' && alphabet <= 'Z') || (alphabet >= 'a' && alphabet <= 'z'))
            {
                switch (alphabet)
                {
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine(value: "This is a vowel");
                        break;
                    default:
                        Console.WriteLine("Consunant");
                        break;
                }
            }
            else Console.WriteLine("Not a latter");
        }
        
    }
}