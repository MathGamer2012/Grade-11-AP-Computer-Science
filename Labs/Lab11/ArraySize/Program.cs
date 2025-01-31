using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal
//Date: <Nov 28 - Nov 28>
//Assignment: Lab11
//Purpose: To get size of data type

namespace ArraySize
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            long[] arr2 = new long[3];
            double[] arr3 = new double[10];
            short[] arr4 = new short[8];


            Console.WriteLine("The size of int array is: " + (arr1.Length * sizeof(int)));
            Console.WriteLine("The size of long array is: " + (arr2.Length * sizeof(long)));
            Console.WriteLine("The size of double array is: " + (arr3.Length * sizeof(double)));
            Console.WriteLine("The size of short array is: " + (arr4.Length * sizeof(short)));

            Console.ReadKey(); 

        }
    }
}
