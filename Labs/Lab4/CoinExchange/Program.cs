using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal
//Date: <Sept 21 - Sept 21>
//Assignment: Lab4 
//Purpose: To calculate coin exchanges with Quarters, Dimes, Nickels, and Pennies 

namespace CoinExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input;
            int Value;
            int Quarters;
            int Dimes;
            int Nickels;
            int Pennies;

            Console.WriteLine("Enter change in cents: ");
            Input = Console.ReadLine(); 
            Value = int.Parse(Input);

            Quarters = Value / 25;
            Value = Value - Quarters * 25;

            Dimes = Value / 10;
            Value = Value - Dimes * 10;

            Nickels = Value / 5;
            Value = Value - Nickels * 5;

            Pennies = Value;

            Console.WriteLine("Quarters: " + Quarters);
            Console.WriteLine("Dimes: " + Dimes);
            Console.WriteLine("Nickels: " + Nickels);
            Console.WriteLine("Pennies: " + Pennies); 

            Console.ReadKey(); 

            //Note for 
            //to get level 4++ u need to animate into square form 
            // frame each draw -> moves by frames 

            //Challeneg 2: 
            // Eneter the name of the iteam 
            // Make a welcome page 
            // The cost of the item is: 
            // Name Cost Quantit
            //The quntty of the item is: 
            //the taes (13%) on the Value: 
        }
    }
}
