using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal
//Date: <Nov 28 - Nov 28>
//Assignment: Lab11
//Purpose: To copy an array propely 

namespace CopyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] origMarks = { 88, 77, 45, 67, 99 };
            int[] copyMarks = new int [origMarks.Length];

            for (int i = 0; i < origMarks.Length; i++) {

                copyMarks[i] = origMarks[i];
                Console.WriteLine(origMarks[i]); 
                Console.WriteLine(copyMarks[i]); 
            }

            copyMarks[3] = 2;

            for (int i = 0; i < origMarks.Length; i++) {
                Console.WriteLine(origMarks[i]);
                Console.WriteLine(copyMarks[i]);

            }

            Console.ReadKey(); 

            

        }
    }
}
