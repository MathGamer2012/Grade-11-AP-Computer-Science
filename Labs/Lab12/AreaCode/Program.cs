using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Dec 7 - Dec 7>
//Assignment: Lab12 
//Purpose: To identify where the user's number is from 

namespace AreaCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            string number2; 

            Console.Write("Enter your phone number: ");
            number = Console.ReadLine();

            number2 = number.Substring(0, 3);

            if (number.Length == 10)
            {
                if (number2 == "416")
                {
                    Console.WriteLine("Your number is from Tornoto");
                }

                else if (number2 == "647")
                {
                    Console.WriteLine("Your number is from the GTA");
                }

                else if (number2 == "905")
                {
                    Console.WriteLine("Your number is from Mississaugua");
                }

                else if (number2 == "289")
                {
                    Console.WriteLine("Your number is from Southern Ontario");
                }

                else
                {
                    Console.WriteLine("Info not available");
                }
            }

            else
            {
                Console.WriteLine("Invalid request"); 
            }

            Console.ReadKey(); 

        }
    }
}
