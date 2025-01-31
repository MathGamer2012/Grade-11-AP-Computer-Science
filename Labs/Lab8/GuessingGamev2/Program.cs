using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Oct 26 - Oct 26> 
//Assignment: Lab 8 
//Purpose: To ask the user their guess, and check if its correct to the random number 

namespace GuessingGamev2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            string check = ""; 
            int lowest;
            int highest;

            Console.Write("Enter the lowest range: ");
            lowest = int.Parse(Console.ReadLine());

            Console.Write("Enter the highest range: ");
            highest = int.Parse(Console.ReadLine());

            Random rand = new Random();
            int number = rand.Next(lowest, highest);
            Console.WriteLine(number);

            while (true)
            {
                Console.Write("Enter your guess (type quit if you wanna leave): ");
                check = Console.ReadLine();
                check.ToLower();

                if (check == "quit")
                {
                    break;
                }

                else
                {
                    input = int.Parse(check); 
                }

                if (input == number)
                {
                    Console.WriteLine("\n" + "You guessed the correct number!!");
                    break;
                }

                else if (input == (number - 3) || input == (number - 2) || input == (number - 1)) // ask if fine
                {
                    Console.WriteLine("\n" + "Sorry the number is too low, but close though!");
                }

                else if (input == (number + 3) || input == (number + 2) || input == (number + 1)) // ask if fine
                {
                    Console.WriteLine("\n" + "Sorry the number is too high, but close though!");
                }

                else if (input > number)
                {
                    Console.WriteLine("\n" + "Your guess is too high and way off!");
                }

                else
                {
                    Console.WriteLine("\n" + "Your guess is too low and way off!");
                }
            }
            Console.ReadKey();
        }
    }
}
