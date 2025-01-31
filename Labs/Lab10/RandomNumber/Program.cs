using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Nov 9 - Nov 9> 
//Assignment: Lab10 
//Purpose: Generates a random number 

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(randNum());
            Console.ReadKey(); 

        }

        public static int randNum()
        {
            Random rand = new Random();
            int num = rand.Next(1, 7);

            return num; 
        }
    }
}
