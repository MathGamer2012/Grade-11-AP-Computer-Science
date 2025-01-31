using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Dec 2 - Dec2>
//Assignment: Lab11
//Purpose: To make an array of marks 

namespace MarksArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            int grade; 

            Console.Write("Type the number of marks you want to enter: ");
            input = int.Parse(Console.ReadLine());

            int[] marks = new int[input];

            for (int i = 0; i < input; i++) {
                Console.Write("Type your mark: ");
                grade = int.Parse(Console.ReadLine());
                marks[i] = grade;

            }

            Console.WriteLine("These are your marks: ");

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]); 

            }

            Console.ReadKey(); 

        }
    }
}
