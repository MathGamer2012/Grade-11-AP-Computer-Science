using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Jan 6 - Jan 6> 
//Assignment: Lab12
//Purpose: To make a IP checker 

namespace CheckIP
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter your IP: ");
            string input = Console.ReadLine(); 
      
            string clear1;
            string clear2;
            string clear3;

            string part1;
            string part2;
            string part3;
            string part4;


            int num1;
            int num2;
            int num3;
            int num4; 

            //1st paramter is inclusive and 2nd is not 

            //123.34.255.233 (input) 

            part1 = input.Substring(0, input.IndexOf(".")); //123

            clear1 = input.Remove(0, input.IndexOf(".") + 1);  //clear is to remove the part that was saved from the IP so the other parts can be saved 

            part2 = clear1.Substring(0, clear1.IndexOf(".")); //34 

            clear2 = clear1.Remove(0, clear1.IndexOf(".") + 1); //255.233 (clear2) 

            part3 = clear2.Substring(0, clear2.IndexOf(".")); //255

            clear3 = clear2.Remove(0, clear2.IndexOf(".") + 1); 

            part4 = clear3;

            num1 = int.Parse(part1);
            num2 = int.Parse(part2);
            num3 = int.Parse(part3);
            num4 = int.Parse(part4);

            if (num1 > 255 || num2 > 255 || num3 > 255 || num4 > 255)
            {
                Console.WriteLine("Invalid IP");
            }

            else if (part1 == "0")
            {

                Console.WriteLine("Invalid IP");
            }

            else if (part4 == "255")
            {
                Console.WriteLine("Invalid IP");
            }

            else if (part1 == "255" && part2 == "255" && part3 == "255" && part4 == "255")
            {
                Console.WriteLine("Invalid IP");
            }

            else
            {
                Console.WriteLine("Valid IP"); 
            }
            
            Console.ReadKey();     
        }
    }
}
