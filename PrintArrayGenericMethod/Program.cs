/*
 * Print Array Generic Method
 * Pawelski
 * 10/28/2023
 * Developing Desktop Applications
 * 
 * Instructions:
 * Look at the PrintArray() method, which is overloaded
 * so that we can print arrays that store int, double,
 * and string values. Is there a lot of similarity
 * between these methods?
 * 
 * Together, let's modify this program by eliminating 
 * all copies of the PrintArray() method except one. 
 * Have this method use a type parameter to specify 
 * the type of the array passed into the method. After
 * we have finished modifying the code, let's discuss
 * the following questions...
 * 1. How did we use a type parameter? Is there any other
 *    way to use a type parameter within a method?
 * 2. Do the original method calls still work? Is there
 *    another way to write the method calls?
 * 3. How many type parameters can a method have?
 * 4. When should you use a generic method instead of
 *    overloading?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintArrayGenericMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sample1 = { 4, 7, 2, 9};
            double[] sample2 = { 5.6, 2.3, 6.9, -1.2 };
            string[] sample3 = { "a", "b", "c", "d" };

            PrintArray(sample1);
            PrintArray(sample2);
            PrintArray(sample3);
        }

        /// <summary>
        /// Displays the contents of the array.
        /// </summary>
        /// <param name="arr">Array of type int.</param>
        private static void PrintArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Displays the contents of the array.
        /// </summary>
        /// <param name="arr">Array of type double.</param>
        private static void PrintArray(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Displays the contents of the array.
        /// </summary>
        /// <param name="arr">Array of type string.</param>
        private static void PrintArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
