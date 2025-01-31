using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal
//Date: <Sept 20 - Sept 21>
//Assignment: Lab4 
//Purpose: To calucalte quadratic formula   

namespace CalcQuadratic
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input1;
            string Input2;
            string Input3;
            double VarA;
            double VarB;
            double VarC;
            double AnsX1;
            double AnsX2;

            Console.Write("Type the value of a: ");
            Input1 = Console.ReadLine();

            Console.Write("Type the value of b: ");
            Input2 = Console.ReadLine();

            Console.Write("Type the value of c: ");
            Input3 = Console.ReadLine();

            VarA = double.Parse(Input1);
            VarB = double.Parse(Input2);
            VarC = double.Parse(Input3); 

            AnsX1 = Math.Round((-VarB+ Math.Sqrt(VarB * VarB - 4 * VarA * VarC)) / (2*VarA),2); // rounds to 2 decimal places 
            AnsX2 = Math.Round((-VarB - Math.Sqrt(VarB * VarB - 4 * VarA * VarC)) / (2 * VarA),2);

            Console.WriteLine("\n" + "The value of x1 is " + AnsX1); // I wrote "/n" to format the output to look more neat
            Console.WriteLine("The value of x2 is " + AnsX2); // Note: Math.Pow(5,1000) is the proper way to do expnonents this would do 5^1000
            Console.ReadKey(); 
        }
    }
}
