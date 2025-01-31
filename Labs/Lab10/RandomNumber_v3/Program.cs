using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Nov 9 - Nov 9> 
//Assignment: Lab10 
//Purpose: Generates a number based on user input of min, max, step

namespace RandomNumber_v3
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            int input2;
            int input3; 

            Console.Write("Write the value for min: ");
            input = int.Parse(Console.ReadLine());

            Console.Write("Write the value for max: ");
            input2 = int.Parse(Console.ReadLine());

            Console.Write("Write the value for step: ");
            input3 = int.Parse(Console.ReadLine());

            Console.WriteLine(randNum(input, input2, input3));
            Console.ReadKey();
        }

        public static int randNum(int min, int max, int step)
        {
            Random rand = new Random();
            int num = rand.Next(min, max); // ask how to put step into this 
            num += step;
            return num;
        }
    }
}
