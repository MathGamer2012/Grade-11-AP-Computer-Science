using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Nov 16 - Nov 16> 
//Assigment: Lab11 
//Purpose: To crete an arraylist to store top 10 snacks and then print them 

namespace FaveSnacks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] snacks = new string[11];

            Console.WriteLine("What are your favourite snacks?");
            string input; 

            for (int i = 1; i < 11; i++) {
                Console.Write("Snack # " + i + ": ");
                input = Console.ReadLine();

                snacks[i - 1] = input;
            }

            Console.WriteLine("Your Top 10 Snacks are: "); 
            
            for (int i = 0; i < (snacks.Length - 1); i++) {
                int check = i;
                Console.WriteLine("Snack #" + (check + 1) + ": " + snacks[i]); 
            }

            Console.ReadKey();

        }
    }
}
