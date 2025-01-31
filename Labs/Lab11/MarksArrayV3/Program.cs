using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Dec 5 - Dec 5>
//Assignment: Lab11
//Purpose: To make an array of marks, get average, and calclate letter grade (A, B, C, D, F) 

namespace MarksArrayV3
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

            Console.WriteLine("\n" + "These are your marks: ");

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);

            }


            Console.WriteLine("\n" + "This is your average: " + getAverage(marks));

            Console.WriteLine("\n" + "These are your letter grades: ");

            for (int i = 0; i < getLetter(marks).Length; i++) {
                Console.WriteLine(getLetter(marks)[i]); 
            }

            Console.ReadKey();
        }

        public static int getAverage(int[] myMarks)
        {
            int total = 0;
            int average = 0;

            for (int i = 0; i < myMarks.Length; i++)
            {
                total += myMarks[i];
            }

            average = total / myMarks.Length;

            return average;
        }

        public static char[] getLetter(int[] myMarks)
        {
            int total = 0;
            int average = 0;

            char[] letter = new char[myMarks.Length];

            for (int i = 0; i < myMarks.Length; i++) {
                if (myMarks[i] >= 90)
                {
                    letter[i] = 'A';
                }

                else if (myMarks[i] >= 70)
                {
                    letter[i] = 'B';
                }

                else if (myMarks[i] >= 60)
                {
                    letter[i] = 'C';
                }

                else if (myMarks[i] >= 50)
                {
                    letter[i] = 'D';
                }

                else {
                    letter[i] = 'F'; 
                }
            }

            return letter;
        }


    }
}
