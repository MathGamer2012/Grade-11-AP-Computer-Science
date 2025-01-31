using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Nov 9 - Nov 9> 
//Assignment: Lab10 
//Purpose: Generates a random number based on user input 

namespace RandomNumber_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;

            Console.Write("Write the value for high: ");
            input = int.Parse(Console.ReadLine());
            Console.WriteLine(randNum(input));
            Console.ReadKey();
        }

        public static int randNum(int high)
        {
            Random rand = new Random();
            int num = rand.Next(1, high);

            return num;
        }
    }
}

