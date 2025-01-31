using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan 
//Date: <Nov 29 - Nov 29>
//Assignment: Lab11
//Purpose: resize array and then put elements in the new resized array 

namespace ResizeArrayV2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] marks = { 88, 77, 45, 67, 99 };
            int[] tempArray = new int[10];

            int input;
            int counter = 4;

            for (int i = 0; i < marks.Length; i++)
            {
                tempArray[i] = marks[i];
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Type your Mark: ");
                input = int.Parse(Console.ReadLine());
                counter++;
                tempArray[counter] = input;  
            }
            Console.WriteLine(" "); 
            Console.WriteLine("My Old Array: ");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write(marks[i] + " ");
            }

            Console.WriteLine("\n"+ "My New Array: "); 
            for (int i = 0; i < tempArray.Length; i++)
            {
                Console.Write(tempArray[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
