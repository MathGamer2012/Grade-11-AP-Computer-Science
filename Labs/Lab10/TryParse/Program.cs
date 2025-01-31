using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal
//Date: <Nov 12 - Nov 12> 
//Assignment: Lab10 
//Purpose: Testing program to validate input 

namespace TryParse
{
    class Program
    {
        static void Main(string[] args) //Catch negative value //Catch string values //Catch decimal values 
        {
            int x;
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out x))
            {
                Console.WriteLine("Success! You entered: " + x);
            }
            else
            {
                Console.WriteLine("Sorry, " + input + " is not a valid integer.");
            }
            Console.ReadKey();

        }
    }
}
