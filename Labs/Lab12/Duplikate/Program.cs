using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan 
//Date: Jan 10 - Jan 10
//Assignment: Lab 12 
//Purpose: To find any duplicates 

namespace Duplikate
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            int input2;

            int counter = 0; 

            Console.Write("How many inputs would you like to enter: ");
            input2 = int.Parse(Console.ReadLine());

            while (true)
            {
                if (counter == input2)
                {
                    break;
                }

                Console.Write("Enter your input: ");
                input = Console.ReadLine();

                Dup(input);
                counter++;
            }

            Console.ReadKey();
        }

        public static void Dup(string input) {
            string check = "";

            int counter3 = 0;
            int counter = 0;

            check += input[0];
            counter3++;


            for (int i = 0; i < input.Length; i++) //clean up all the duplicates 
            {

                if (counter3 == input.Length)
                {
                    break;
                }

                if (check.Contains(input[counter3]))
                {
                    counter3++;
                    continue;

                }

                else
                {
                    check += input[counter3];
                    counter3++;
                }
            }
            Console.WriteLine("There are the amount of duplicates repeated in your input: ");

            for (int count = 0; count < check.Length; count++)
            { //from the string that has the cleaned up input check for each chratcter that is in the first input string  
                for (int i = 0; i < input.Length; i++)
                {
                    if (check[count] == input[i])
                    {
                        counter++;
                    }
                }

                if (counter > 1)
                {
                    Console.WriteLine(check[count] + ":" + counter);
                }
                counter = 0;
            }
        }
    }
}
