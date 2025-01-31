using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Nov 5 - Nov 5> 
//Assignment: Lab9 
//Purpose: To swap values using methods

namespace OutputTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int Val3 = 8;
            int Val4 = 10;
            Swap(Val3, Val4);
            Console.WriteLine("Val3 = " + Val3 + " and Val4 = " + Val4);
            Console.ReadKey(); 
        }

        public static void Swap(int Val1, int Val2)
        {
            int temp = Val1;
            Val1 = Val2; // Val1 = 10             Console.WriteLine(Val1); 
            Val2 = temp; // Val2 = 8 

            //Just switches order by saying one number val into a diff varbale (temp)S

            //Output is the same values as no variales from this method are returned 
        }

    }
}
