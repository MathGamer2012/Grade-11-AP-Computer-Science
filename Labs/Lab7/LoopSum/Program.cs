using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal
//Date: <Oct 12 - Oct 12> 
//Assigment: Lab 7 
//Purpose: To calculate the sum of the first 5 numbers  

namespace LoopSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                int input;
               ;
       
                Console.Write("Enter the number: ");
                input = int.Parse(Console.ReadLine());

                sum += input;



                if (i == 4)
                {
                    Console.WriteLine("The total is: " + sum);
                }


            }
            Console.ReadKey(); 
        }
    }
}
