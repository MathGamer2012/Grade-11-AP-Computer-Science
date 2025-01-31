using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Sept 20 - Sept 20>
//Assignment: Lab4 
//Purpose: To calucalte Area of triAngle using sin  

namespace AreaCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input;
            string Input2;
            string Input3;
            double Side1;
            double Side2;
            int Angle;
            double Radians; 
            double Area;

            Console.Write("Enter the value of the first Side: ");
            Input = Console.ReadLine();
            Console.Write("Enter the value of the second Side: ");
            Input2 = Console.ReadLine();
            Console.Write("Enter the value of the Angle: ");
            Input3 = Console.ReadLine();

            Side1 = int.Parse(Input);
            Side2 = int.Parse(Input2);
            Angle = int.Parse(Input3);

            Radians = Angle * (Math.PI / 180); //ask what this does  


            Area = Math.Round((Side1 * Side2 * Math.Sin(Radians)) / 2, 2);
            Console.WriteLine("The Area of the triAngle is: " + Area);
            Console.ReadKey(); 
        }
    }
}
