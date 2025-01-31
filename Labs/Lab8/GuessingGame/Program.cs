using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Oct 26 - Oct 26> 
//Assignment: Lab 8 
//Purpose: To ask the user their guess, and check if its correct to the random number 

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0; 
            Random rand = new Random();
            int number = rand.Next(1, 51);

            while (true)
            {
                Console.Write("Enter your guess: ");
                input = int.Parse(Console.ReadLine());

                if (input == number)
                {
                    Console.WriteLine("\n" + "You guessed the correct number!!");
                    break; 
                }

                else if (input > number)
                {
                    Console.WriteLine("\n" + "Your guess is too high!"); 
                }

                else
                {
                    Console.WriteLine("\n" + "Your guess is too low!");
                }
            }
            Console.ReadKey(); 
            
            
        }
    }
}
