using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Nov 16 - Nov 16> 
//Assigment: Lab11 
//Purpose: To crete an arraylist to store 10 mark values and find the average 

namespace Marks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[11];
            int input;
            int average = 0;
            int sum = 0; 

            for (int i = 0; i < 10; i++) {
                int check = i;
                Console.Write("Enter Mark # " + (check + 1) + ": ");
                input = int.Parse(Console.ReadLine());
                marks[i] = input; 
            }

            for (int i = 0; i < (marks.Length - 1); i++) {
                sum += marks[i];
                average = sum / (marks.Length - 1); 
            }

            Console.WriteLine("Your average is: " + average + " (Rounded to the nearest whole number)"); 

            Console.ReadKey(); 




        }
    }
}
