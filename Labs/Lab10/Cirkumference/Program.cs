using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal
//Date: <Nov 12 - Nov 12> 
//Assignment: Lab10 
//Purpose: To return the area and circumference of a circle 

namespace Cirkumference
{
    class Program
    {
        static void Main(string[] args)
        {
            double input;
            string input2;

            while (true)
            {
                Console.Write("Enter the radius: ");
                input = double.Parse(Console.ReadLine());

                if (input > 0)
                {
                    continue;
                }

                else
                {
                    Console.WriteLine("Incorrect value, make sure the number is postive and not a string");
                    Console.Write("Enter the radius: ");
                    input = double.Parse(Console.ReadLine());
                }

                Console.WriteLine("The circumfrence of the circle is: " + circumference(input));
                Console.WriteLine("The area of the circle is: " + area(input));


                Console.WriteLine("Quit?");
                input2 = Console.ReadLine();

                input2.ToLower();

                if (input2 == "y")
                {
                    break;
                }

                else
                {
                    Console.Clear(); 
                }

            }
            Console.ReadKey(); 
            //ask what he means by the values for radius that don't make sense 
        }

        public static double circumference(double radius)
        {
            double circumference = 0;
            circumference = Math.Round(2 * Math.PI * radius, 2);
            return circumference; 
        }

        public static double area(double radius)
        {
            double area = 0;
            area = Math.Round(Math.PI * Math.Pow(radius, 2), 2); 
            return area;
        }

    }
}
