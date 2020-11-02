
using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;

            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 8; j++)
                {
                    if ((i+j)%2==0)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("O");
                    }

                }
                Console.WriteLine(" ");
            }
        }
    }
}