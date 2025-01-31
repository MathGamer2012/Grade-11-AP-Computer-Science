using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Dec 2 - Dec2>
//Assignment: Lab11
//Purpose: To make an array of marks and get average 

namespace MarksArrayV2
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

            for (int i = 0; i < input; i++)
            {
                Console.Write("Type your mark: ");
                grade = int.Parse(Console.ReadLine());
                marks[i] = grade;

            }

            Console.WriteLine("These are your marks: ");

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);

            }


            Console.WriteLine("This is your average: " + getAverage(marks)); 

            Console.ReadKey();
        }

        public static int getAverage(int[] myMarks) {
            int total = 0;
            int average = 0; 

            for (int i = 0; i < myMarks.Length; i++) {
                total += myMarks[i]; 
            }

            average = total / myMarks.Length;

            return average;
        }
    }
}
