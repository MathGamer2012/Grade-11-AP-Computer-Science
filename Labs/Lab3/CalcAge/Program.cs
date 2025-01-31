using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Sept 19 - Sept 19>
//Assignment: Inputs 
//Purpose: To calculate age 

namespace CalcAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int days;
            int hours;
            int min;
            int sec;
            int value;
            string input;


            Console.Write("Enter the number of seconds: ");
            input = Console.ReadLine();
            value = int.Parse(input);

            days = value / 86400;
            value = value - days * 86400;

            Console.WriteLine("Days: " + days);

            hours = value / 3600;
            value = value - hours * 3600;

            Console.WriteLine("Hours: " + hours);

            min = value / 60;
            value = value - min * 60;

            Console.WriteLine("Minutes: " + min);

            sec = value; 

            Console.WriteLine("Seconds: " + sec); 

          
            Console.ReadKey(); 

        }
    }
}
