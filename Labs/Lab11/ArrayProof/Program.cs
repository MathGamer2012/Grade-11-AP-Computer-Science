using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Nov 28 - Nov 28> 
//Assignment: Lab11
//Purpose: To check if you can copy array by setting them equal  

namespace ArrayProof
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] original = { 1, 2, 3, 4, 5 };
            int[] copy = new int[original.Length];

            copy = original;

            for (int i = 0; i < copy.Length; i++) {
                Console.WriteLine(copy[i]); 

            }

            copy[3] = 100;

            for (int i = 0; i < original.Length; i++)
            {
                Console.WriteLine(original[i]);

            }

            Console.ReadKey(); 

        }
    }
}
