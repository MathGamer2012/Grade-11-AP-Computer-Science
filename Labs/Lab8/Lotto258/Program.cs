using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Oct 26 - Oct 26> 
//Assignment: Lab 8 
//Purpose: To make random lottery ticket numbers 

namespace Lotto258
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "y"; 
            while (input == "y")
            {
                Random rand = new Random();
                int number = rand.Next(1000000, 9999999);
                Console.WriteLine("\n" + "The winning number is: " + number);
                Console.WriteLine("Again? ");
                input = Console.ReadLine();
                input.ToLower();
            }

            Console.ReadKey();
        }
    }
}
