using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Nov 23 - Nov 23> 
//Assigment: Lab11 
//Purpose: To x2 the list 

namespace TwoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 13, -4, 82, 17 };
            int[] twice = arr; 
            int timesTwo; 


            //test by mr.m

            for (int i = 0; i<twice.Length;i++)
            {
                Console.WriteLine(twice[i]);
            }
            Console.WriteLine("Orginal Array: ");

            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i]); 
            }

            Console.WriteLine("This is my new array: ");

            for (int i = 0; i < twice.Length; i++)
            {
                timesTwo = twice[i] * 2; 
                Console.WriteLine(timesTwo);
            }
            Console.ReadKey(); 
        }
    }
}
