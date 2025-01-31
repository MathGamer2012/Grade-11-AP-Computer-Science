using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Nov 9 - Nov 9> 
//Assignment: Lab10 
//Purpose: To Check for multiple different factors such as isdivisbe, GCD, or isprime

namespace Funktions
{
    class Program
    {
        static void Main(string[] args)
        {
            double input;
            double input2;

            int input3;
            int input4;

            char input5; 

            Console.Write("Enter a number: ");
            input = double.Parse(Console.ReadLine());

            Console.Write("Enter a number: ");
            input2 = double.Parse(Console.ReadLine());

            input3 = int.Parse(input.ToString());
            input4 = int.Parse(input2.ToString());

            Console.Write("Enter a Letter: ");
            input5 = char.Parse(Console.ReadLine()); 


            Console.WriteLine("The larger number is " + largest(input, input2));
            Console.WriteLine("The GCD of " + input3 + " and " + input4 + " is " + greatCommDiv(input3, input4));
            Console.WriteLine(isDivisble(input3, input4));
            Console.WriteLine(isPrime(input3));
            Console.WriteLine(isLetter(input5)); 




            Console.ReadKey(); 
        }

        public static double largest(double num1, double num2)
        {
            if (num1 > num2)
            {
                return num1;
            }

            else
            {
                return num2; 
            }
        }

        public static int greatCommDiv(int num1, int num2) //ask how
        {
            int gcd = 0; 
           
            for (int i = 0; num1 <= i && num2 <= i; i++) {

                if (num1 % i == 0 && num2 % i == 0) {
                    gcd += i;
                    
                }
            }

            return gcd;
        }

        public static bool isDivisble(int num1, int num2)
        {
            if (num1 % num2 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static bool isPrime(int num1)
        {
            if (num1 == 2)
            {
                return true;
            }

            else if (num1 % 2 == 0)
            {
                return false; 
            }

            else
            {
                return true;
            }
        }

        public static bool isLetter(char letter)
        {
            if (letter >= 'a' && letter <= 'z' || letter >= 'A' && letter <= 'Z')
            {
                return true;
            }

            else
            {
                return false; 

            }

        }
    }
}
