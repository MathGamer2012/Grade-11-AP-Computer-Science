using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan 
//Date: <Sept 15 - Sept 15> 
//Assigment: Integer Calculations 
//Purpose: To solve basic math operations using the data type int 

//Input - I
//Processing - P 
//Output - O
//Storage - S

//When doing integer division the decimal value after gets dropped
//% = Modules Operator -> Remainder 
namespace IntCalcs
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber = 17;
            int SecondNumber = 12;
            int Answer = 0;
            Answer = FirstNumber + SecondNumber;
            Console.WriteLine(Answer);
            Answer = FirstNumber - SecondNumber;
            Console.WriteLine(Answer);
            Answer = FirstNumber * SecondNumber;
            Console.WriteLine(Answer);
            Answer = FirstNumber / SecondNumber;
            Console.WriteLine(Answer);
            Answer = (FirstNumber + SecondNumber) * 2;
            Console.WriteLine(Answer);
            Console.ReadKey(); 
        }
    }
}
