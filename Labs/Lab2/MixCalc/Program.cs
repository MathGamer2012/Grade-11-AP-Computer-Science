using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan 
//Date: <Sept 15 - Sept 15> 
//Assigment: Mix Calculations 
//Purpose: To solve basic math operations using a combination of data types  

namespace MixCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int Three = 3;
            int Two = 2;
            double Result = 0;
            Result = 1.5 + (double) Three / Two; //prints the actual answer of 3 instead of the rounded answer 2.5 
            Console.WriteLine(Result); //(double) converts the int data types into double types thus the answer of 3 - this is called "casting"
            Console.ReadKey();// Convert.ToDouble also does the same thing (exsists in C# and Java) -> When doinng Convert.ToInt do Convert.ToInt16
            //Parse is used convert String to any other data type
            //Console.ReadLine(); 
        }
    }
}
