using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Nov 16 - Nov 16>
//Assignment: Lab 11 
//Purpose: To find the sum of the numbers  

namespace ArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 0, 1, 2, 3, 4, 5 };
            int sum = 0; 

            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }

            Console.WriteLine("Sum is: " + sum);
            Console.ReadKey(); 
        }
    }
}
