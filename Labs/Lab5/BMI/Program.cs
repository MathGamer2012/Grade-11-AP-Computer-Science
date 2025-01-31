using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Sept 29 - Sept 29>
//Assigment: BMI 
//Purpose: To tell the user if they are over, under or normal weight based on their BMI (weight and height) 

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string input2;
            double weight;
            double height;
            double BMI; 
        
            Console.WriteLine("Enter your weight (in kilograms): ");
            input = Console.ReadLine();
            weight = double.Parse(input);

            Console.WriteLine("Enter your height (in meters): ");
            input2 = Console.ReadLine();
            height = double.Parse(input2);

            BMI = Math.Round(weight / (height * height), 2); 

            if (BMI > 25)
            {
                Console.WriteLine("BMI is " + BMI + ". You are Overweight");    
            }

            if (BMI > 18.5 || BMI <= 25)
            {
                Console.WriteLine("BMI is " + BMI + ". You are Normal Weight");
            }

            else if (BMI <= 18.5)
            {
                Console.WriteLine("BMI is " + BMI + ". You are Under Weight");
            }

            Console.ReadKey(); 
        }
    }
}
