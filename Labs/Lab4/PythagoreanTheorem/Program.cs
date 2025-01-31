using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Sept 20 - Sept 20>
//Assignment: Lab4 
//Purpose: To Calculate the Hypotenuse  

namespace PythagoreanTheorem
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input;
            string Input2;
            double Side;
            double Side2;
            double Calc;
            double Hypotenuse; 

            Console.Write("Enter the value of the first Side: ");
            Input = Console.ReadLine();
            Console.Write("Enter the value of the second Side: ");
            Input2 = Console.ReadLine();

            Side = int.Parse(Input);
            Side2 = int.Parse(Input2);

            Calc = (Side * Side) + (Side2 * Side2);
            Hypotenuse = Math.Round(Math.Sqrt(Calc), 2);

            Console.WriteLine("The value of the Hypotenuse is " + Hypotenuse);
            Console.ReadKey(); 
        }
    }
}
