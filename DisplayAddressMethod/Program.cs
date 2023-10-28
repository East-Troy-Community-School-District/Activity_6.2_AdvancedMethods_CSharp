/*
 * Display Address Method
 * Pawelski
 * 10/28/2023
 * Developing Desktop Applications
 * 
 * Instructions:
 * Answer the following questions...
 * 1. What are the rules for breaking up long lines?
 * 2. How do named arguments work?
 * 3. How are named arguments used in this code to make
 *    it easier to understand?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayAddressMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayAddress("3853 Sunsent Drive", "Stevens Point", 
                "WI", "54482");
            Console.WriteLine();
            DisplayAddress("1835 Division Street", "East Troy",
                "WI", "53120", "M2");
            Console.WriteLine();
            DisplayAddress(street: "123 Hudson Way", apartmentNumber: "5",
                city: "Anywhere", state: "MN", zip: "55555");
        }

        /// <summary>
        /// Displays the address to the console formatted correctly.
        /// </summary>
        /// <param name="street">Street for the address.</param>
        /// <param name="city">City for the address.</param>
        /// <param name="state">State for the address.</param>
        /// <param name="zip">Zip for the address.</param>
        /// <param name="apartmentNumber">Apartment number for the address. Optional.</param>
        private static void DisplayAddress(string street, 
            string city, string state, string zip, 
            string apartmentNumber = "")
        {
            if (apartmentNumber != "")
            {
                Console.WriteLine(street + ", Apt. " 
                    + apartmentNumber);
            }
            else
            {
                Console.WriteLine(street);
            }
            Console.WriteLine(city + ", " + state + ", " + zip);
        }
    }
}
