using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Nov 23 - Nov 23> 
//Assigment: Lab11 
//Purpose: To check user input for student number and print the persons name and age  

namespace ParallelArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = {1234, 3234, 3288, 2345, 3875};
            string[] name = { "Sam", "Elisa", "John", "Janet", "Frank" };
            int[] age = { 33, 45, 23, 35, 51 };

            int input;
            Console.Write("Enter student number: "); 
            input = int.Parse(Console.ReadLine());

            for (int i = 0; i < number.Length; i++) {
                if (input == number[i]) {
                    Console.WriteLine("Name is: " + name[i]);
                    Console.WriteLine("Age is: " + age[i]);
                }
            }

            Console.ReadKey(); 
        }
    }
}
