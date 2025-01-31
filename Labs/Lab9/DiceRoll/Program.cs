using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Nov 5 - Nov 5> 
//Assignment: Lab9 
//Purpose: To make a program that can simulate multiple dice rolls 

namespace DiceRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;

            Console.Write("Type the Number of Rolls: ");
            input = int.Parse(Console.ReadLine());
            Console.WriteLine(""); 

            RollDice(input);
            Console.ReadKey(); 
        }

        public static void RollDice(int numRoll)
        {

            for (int i = 1; i <= numRoll; i++)
            {
                Random rand = new Random();
                int dicNum1 = rand.Next(1, 7);
                Console.WriteLine("Roll " + i + " is a " + dicNum1); 
         
            }
        } 
    }
}
