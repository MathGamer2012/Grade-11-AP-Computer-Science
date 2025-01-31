using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan 
//Date: <Dec 12 - Dec 12> 
//Assignment: Lab 12 
//Purpose: To check if output is a palindrome 

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.Write("Enter your value: ");
            input = Console.ReadLine(); 

            if (isPalindrome(input) == true)
            {
                Console.WriteLine("The input is a Palindrome");
            }

            else {
                Console.WriteLine("The input is not a Palindrome"); 
            }
            Console.ReadKey();
        }

        public static bool isPalindrome(string value)
        {
            string word = value;
            string word2 = "";


            for (int i = (value.Length - 1); i >= 0; i--)
            {
                word2 += value[i]; 
            }

            word.ToLower();
            word2.ToLower();

            if (word == word2)
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
