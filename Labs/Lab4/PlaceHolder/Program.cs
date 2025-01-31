using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Sept 20 - Sept 20>
//Assignment: Lab4 
//Purpose: To test placeholder

namespace PlaceHolder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is an example of formatting an output for currency: {0:C}.", 25);
            // {0:C} - 0 is a place holder and C is the indicator that you are 
            //formatting currency value, the output of this is $25.00
            Console.WriteLine("This is an example of formatting an output of a number with 4 decimal place {0:F4}.", 25.456789);
            // {0:F4} - 0 is a place holder and F is the indicator that you are 
            //formatting fraction, the output of this is 25.4568, C# is smart enough to 
            //round the numbers up
            Console.WriteLine("This is an example of formatting with percent: {0:P10}.",1.0411112345678);
            /* {0:P10} - 0 is a place holder and P is the indicator that you are 
            formatting percentage, 10 is the 10 decimal points.
            * the output of this is 104.11111234568, C# is smart enough to round up and 
            added % at the end*/
            Console.WriteLine("This is an example of formatting with commas and decimals: {0:N2}.", 2345678.345678);
            /* {0:N2} - 0 is a place holder and N is the indicator that you are 
            formatting numbers, 2 is the 2 decimal points. The output of this is 
            2,345,678.35 */
            Console.WriteLine("This is an example of displaying two numbers using placeholder method: {0} and {1}.", 232, 233);
            //first {0} is for the first data, 2nd placeholder {1} is for the second data
            Console.WriteLine("This is an example of displaying two strings using placeholder method: {0} and {1} ", "Hello", "Again");
            //the same thing but with strings instead of number

            Console.ReadKey(); 
        }
    }
}
