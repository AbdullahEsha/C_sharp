

using System;

namespace Assignment
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("First Name: ");
            String firstName = Console.ReadLine();

            Console.WriteLine("Last Name: ");
            String lastName = Console.ReadLine();

            Console.WriteLine("Birth day ");
            String birthDay = Console.ReadLine();

            Console.WriteLine("Address Line 1 ");
            String addressLine1 = Console.ReadLine();

            Console.WriteLine("Address Line 2 ");
            String addressLine2 = Console.ReadLine();

            Console.WriteLine("City ");
            String city = Console.ReadLine();

            Console.WriteLine("State ");
            String state = Console.ReadLine();

            Console.WriteLine("Zip Code ");
            String zip = Console.ReadLine();
            double zipCode = double.Parse(zip);


            Console.WriteLine("Country ");
            String country = Console.ReadLine();
            
           
                Console.WriteLine("firstName: " + firstName);
                Console.WriteLine("lastName: " + lastName);
                Console.WriteLine("birthDay: " + birthDay);
                Console.WriteLine("addressLine1: " + addressLine1);
                Console.WriteLine("addressLine2: " + addressLine2);
                Console.WriteLine("city: " + city);
                Console.WriteLine("state: " + state);
                Console.WriteLine("Zip Code: " + zipCode);
                Console.WriteLine("country: " + country);
        }
    }
}