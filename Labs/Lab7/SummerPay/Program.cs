using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal
//Date: <Oct 12 - Oct 12> 
//Assigment: Lab 7 
//Purpose: To calculate Anne's total pay and average pay 

namespace SummerPay
{
    class Program
    {
        static void Main(string[] args) // memorize 
        {
            double wage = 9.50;
            int weeks;
            int hours;
            int totalHours = 0;
            double totalPay;
            double avgPay; 
            int counter = 1; 

            Console.Write("Enter the number of weeks you worked: ");
            weeks = int.Parse(Console.ReadLine());

            int end = weeks - 1; // ask if its fine, im doing this bc counting starts off with 0 


            for (int i = 0; i < weeks; i++)
            {
                Console.Write("Enter the number of hours you worked for Week " + counter + ": ");
                hours = int.Parse(Console.ReadLine());

                totalHours += hours;
                totalPay = Math.Round(wage * totalHours, 2);

                avgPay = Math.Round(totalPay / weeks, 2); 

                counter += 1;

                if (i == end) {
                
                Console.WriteLine("\n" + "Your total pay for the summer is: $" + totalPay);
                Console.WriteLine("Your average pay per week is: $" + avgPay);

                }

            }

            Console.ReadKey(); 

        }
    }
}
