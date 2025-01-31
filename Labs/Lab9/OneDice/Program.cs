using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Nov 2 - Nov 2> 
//Assignment: Lab9 
//Purpose: To simulate a dice 

namespace OneDice
{
    class Program
    {
        static void Main(string[] args)
        {             
            while (true)
            {
                Random rand = new Random();
                int dicNum = rand.Next(1, 7);
                string input;

                Console.WriteLine("You rolled a " + dicNum + "! Roll again (Y/N)");
                input = Console.ReadLine();
                input.ToLower(); 

                if (input == "n")
                {
                    break; 
                }
            }
            Console.ReadKey();

        }
    }
}
