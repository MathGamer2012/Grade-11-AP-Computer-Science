using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Nov 2 - Nov 2> 
//Assignment: Lab9 
//Purpose: To simulate 2 dice and add them up 

namespace TwoDice
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random rand = new Random();
                int dicNum1 = rand.Next(1, 7);
                int dicNum2 = rand.Next(1, 7);

                int dicTot; 

                string input = "";
                dicTot = dicNum1 + dicNum2;

                printDic(dicNum1, dicNum2, dicTot);

                Console.Write(" Roll again? (Y/N): ");
                input = Console.ReadLine();
                input.ToLower();

                if (input == "n")
                {
                    break;
                }

            }

            Console.ReadKey();
        }

        public static void printDic(int dicNum1, int dicNum2, int dicTot) // fix this 
        {
            Console.Write("\n" + "You rolled a " + dicNum1 + " and " + dicNum2 + "! Your Total is: " + dicTot);
            
        } 
    }


}
