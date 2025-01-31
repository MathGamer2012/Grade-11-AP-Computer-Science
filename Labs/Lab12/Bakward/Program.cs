using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan
//Date: <Dec 12 - Dec 12>
//Assignment: Lab 12
//Purpose: TO output number backwards 

namespace Bakward
{
    class Program
    {
        static void Main(string[] args)
        {

            int Boo = 0;

            string input = "123456";

            Console.WriteLine(isBackward(input)); 
            Console.ReadKey();
        }

        public static string isBackward(string val) {
            string output = ""; 

            for (int i = (val.Length - 1); i >= 0; i--)
            {
                output += val[i]; 
            }

            return output;  
        }
    }
}
