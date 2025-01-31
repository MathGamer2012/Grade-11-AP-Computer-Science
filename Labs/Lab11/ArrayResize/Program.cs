using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan 
//Date: <Nov 29 - Nov 29> 
//Assignment: Lab11
//Purpose: To resize an array 

namespace ArrayResize
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Marks = { 88, 77, 45, 67, 99 };

            Console.WriteLine("Here is my original array: ");
            for (int i = 0; i < Marks.Length; i++) {
                Console.WriteLine(Marks[i] + " "); 
            }

            Array.Resize(ref Marks, 10);
            Console.WriteLine("\n");
            Console.WriteLine("Here is my array after resize: ");

            for (int i = 0; i < Marks.Length; i++) {
                Console.WriteLine(Marks[i] + " "); 
            }

            Console.ReadKey();
        }
    }
}
