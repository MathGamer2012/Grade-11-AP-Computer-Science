using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Name: Ishaan Mittal 
// Date: <Sept 30 - Sept 30> 
// Assigment: Assigment2 (Cosine Law) 
// Purpose: To calculate the missing side (sideC) using cosine forumla 

namespace CosineLaw
{
    class Program
    {
        static void Main(string[] args)
        {
            string input; // stores the user input 
            string input2; // same as above
            string input3; // same as above
            double sideA; // stores input1 to sideA to be used later in the program 
            double sideB; // stores input2 to sideB to be used later in the program 
            double angleC; // stores input3 to angleC to be used later in the program
            double sideC; // stores the answer to the cosine law equation 
            double cosC; // stores the value of the angle in radians x cos 

            Console.WriteLine("\t" + "\t" + "\t" + "\t" + "\t" + "Welcome to Cosine Calculator!"); // sets the title of the program
            Console.WriteLine(""); 

            Console.Write("Enter the length of side A: "); // asks the user for length of side A
            input = Console.ReadLine(); // saves input in "input"
            sideA = double.Parse(input); // stores userinput into varibale sideA

            Console.Write("Enter the length of side B: "); // asks the user for length of side B
            input2 = Console.ReadLine(); // saves input in "input2"
            sideB = double.Parse(input2); // stores userinput into varibale sideB

            Console.Write("Enter the angle (in degrees) of angle C: "); // asks the user for length of angle C
            input3 = Console.ReadLine(); // saves input in "input3"
            angleC = double.Parse(input3); // stores userinput into varibale angleC

            cosC = Math.Cos((angleC * (Math.PI)) / 180); // calculates the cosine of the radian's angle (angleC * (Math.PI) / 180 is done to convert the angle in degrees to angles in radians)
            sideC = Math.Round(Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2) - 2 * sideA * sideB * cosC), 1); // calculates sideC based on the forumla given in the assigment -> rounds to 1 decimal place

            Console.WriteLine("\n" + "The length of side C is: " + sideC + " units"); // informs the user the length of side C after calculations have taken place

            Console.WriteLine(""); // makes a triangle to provide the user with a visual of the output 
            Console.WriteLine("");
            Console.WriteLine("\t" + "\t" + "\t" + "*");
            Console.WriteLine("\t" + "\t" + "     " + "*" + "     " + "*");
            Console.WriteLine("\t" + "\t" + sideA + " " + "*" + "         " + "*" + "\t" + sideC);
            Console.WriteLine("\t" + "\t" + " " + "*" + "             " + "*");
            Console.WriteLine("\t" + "       " + "*" + "                 " + "*");
            Console.WriteLine("\t" + "     " + "*" + " * * * * * * * * * * * ");
            Console.WriteLine("\t" + "\t" + "\t" + sideB); 


            Console.ReadKey(); // Not Barry Allen 

            // https://www.calculatorsoup.com/calculators/geometry-plane/triangle-law-of-cosines.php -> This is the website I used to confirm that my output/calculations were right

            // Code Explanantion: 

            // Firstly I start off by declaring my varibales for storing input (input, input2, input3), transfering inputs (sideA, sideB, angleC), cosine calculation (cosC), and lastly the length of the missing side (sideC)
            // Then, I ask the user to input their values for side A, side B, and angle C -> and save it varibles (sideA, sideB, angleC)
            // After that, I do the cosine calculation where I find the radian angle of angleC and then multiply it by cos
            // Finally, I do the main calcualtion for sideC using the CosineLaw forumla provided and print the result to the console -> for the user
        }
    }
}
