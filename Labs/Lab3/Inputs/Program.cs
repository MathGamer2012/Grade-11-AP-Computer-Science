using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Sept 19 - Sept 19>
//Assignment: Inputs 
//Purpose: To make inputs 

namespace Inputs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            string input = Console.ReadLine();
            int value = int.Parse(input);
            value = value * 3;
            Console.WriteLine(input + " x 3 = " + value);
            Console.ReadKey(); 
        }
    }
}
