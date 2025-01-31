using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan 
//Date: Dec 13 - Jan 9 
//Assignment: Lab 12 
//Purpose: To clean up any duplicates 

namespace KleenUp
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            string input2; 
            int counter = 0; 

            Console.Write("How many inputs would you like to enter: ");
            input = int.Parse(Console.ReadLine());

            while (true) {
                if (counter == input)
                {
                    break; 
                }

                Console.Write("Enter your input: ");
                input2 = Console.ReadLine();

                Clean(input2);
                counter++; 
            }

            Console.ReadKey();

        }

        public static void Clean(string input) {

            string check = "";

            int counter = 0;

            check += input[0];
            counter++;


            for (int i = 0; i < input.Length; i++)
            {

                if (counter == input.Length)
                {
                    break;
                }

                if (check.Contains(input[counter]))
                {
                    counter++;
                    continue;

                }

                else
                {
                    check += input[counter];
                    counter++;
                }
            }
            Console.WriteLine("This is your cleared input: " + check);
        }
    }
}
