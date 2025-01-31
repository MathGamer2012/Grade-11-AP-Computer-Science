using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal
//Date: <Nov 12 - Nov 12> 
//Assignment: Lab10 
//Purpose: To return the factorial of the number the user inputs 

namespace Faktorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            long check;

            bool valid = false;

            while (valid == false) { 
            Console.Write("Type the number you want the factorial for: ");
            input = Console.ReadLine();

            if (long.TryParse(input, out check) && check > 0)
            {
                Console.WriteLine(factorial(check));
                valid = true;
            }
     
            else
            {
                Console.WriteLine("Sorry, " + input + " is not a valid integer.");
                valid = false; 
            }

            }

            Console.ReadKey(); 
        }

        public static long factorial(long number)
        {
            long product = number;
            long result = number; 
            long final; 


            for (long i = 0; i < number; i++) {
                product -= 1;
                if (product > 0)
                { 
                    result *= product;
                }
            }

            final = result;
            return final; 
            
        }


    }
}
