using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Sept 20 - Sept 20>
//Assignment: Lab4 
//Purpose: To calculate circumfrecne and Area of circle  

namespace CircleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input;
            double Radius;
            double Circumfrence;
            double Area;

            Console.Write("Enter the Radius of the circle: ");
            Input = Console.ReadLine();

            Radius = double.Parse(Input);

            Circumfrence = Math.Round((2 * Math.PI * Radius),2); //rounds to the nearest hundereth (2 decimal places)
            Area = Math.Round(Math.PI * (Radius * Radius),2);

            Console.WriteLine("The Circumfrence is " + Circumfrence);
            Console.WriteLine("The Area is " + Area);
            Console.ReadKey(); 

        }
    }
}
