using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan 
//Date: <Sept 15 - Sept 15> 
//Assigment: Float Calculations 
//Purpose: To solve basic math operations using the data type float and double  

namespace FloatCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            float Number1 = 12.5f;
            float Number2 = 6.8f;//Floating Point Percission is why the extra decimals values occured 
            double Number3 = 2.0d;
            double Answer = 0;
            Answer = Number1 + Number2;
            Console.WriteLine(Answer);
            Answer = (Number1 + Number2) * Number3;
            Console.WriteLine(Answer);
            Answer = Number1 * Number2 * Number3;
            Console.WriteLine(Answer);
            Answer = Number3 - Number2;
            Console.WriteLine(Answer);
            Console.ReadKey(); 
        }
    }
}
