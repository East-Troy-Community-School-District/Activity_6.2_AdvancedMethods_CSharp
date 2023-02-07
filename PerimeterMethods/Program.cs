/*
 * Perimeter Methods
 * 2/6/2023
 * C#.NET I
 * 
 * Instructions:
 * Answer the following questions...
 * 1. How many versions of the Perimeter() method are there?
 * 2. What must be different about each version of the
 *    Perimeter() method? Why?
 * 3. Based on this example, when should you use overloading?
 * 4. Why can you not add another version of the Perimeter()
 *    method with the following header...
 *    
 *    private static void Perimeter(double side)
 *   
 * Finally, modify the program by adding another version of the
 * Perimeter() method that calculates the perimeter of a triangle
 * given the length of the 3 sides. Test your method by calling
 * it in the Main() method.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimeterMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Perimeter(4);
            Perimeter(4.5);
            Perimeter(3, 4);
        }

        /// <summary>
        /// Calculates the perimeter of a square.
        /// </summary>
        /// <param name="side">Length of the square's sides.</param>
        private static void Perimeter(int side)
        {
            double area = Math.Pow(side, 2);
            Console.WriteLine(area);
        }

        /// <summary>
        /// Calculates the circumference (perimeter) of a circle.
        /// </summary>
        /// <param name="radius">Radius of the circle.</param>
        private static void Perimeter(double radius)
        {
            double area = 2 * Math.PI * radius;
            Console.WriteLine(area);
        }

        /// <summary>
        /// Calculates the perimeter of a rectangle.
        /// </summary>
        /// <param name="length">Length of the rectangle.</param>
        /// <param name="width">Width of the rectangle.</param>
        private static void Perimeter(int length, int width)
        {
            double area = length * width;
            Console.WriteLine(area);
        }
    }
}
