using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Name: Ishaan Mittal 
// Date: <Sept 30 - Sept 30> 
// Assigment: Assigment2 (Easter Calculator) 
// Purpose: To create an easter calculator that tells the user the day and month of easter based on the year inputted

namespace EasterCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input; // declare variable to be used to store user input 
            int year; // declear to be used to store the value from "string input" 
            string answer = "y"; // sets answer to "y" so the loop continues to repeat until answer is changed 

            Console.WriteLine("\t" + "\t" + "\t" + "\t" + "\t" + "Welcome to Easter Calculator!"); // sets the title of the program
            Console.WriteLine("");
            while (answer == "y") // given by Mr.Moniaga 
            {
                Console.Write("Enter the year: "); // asks the user for year 
                input = Console.ReadLine(); // reads the input and saves it to input
                year = int.Parse(input); // parses the input into a int type instead of a string and saves it to variable year

                // use of Anonymous Gregorian algorithm - https://c-for-dummies.com/blog/?p=2431
                int varA = year % 19; // finds the remainder of "year" when divided by 19 
                int varB = year / 100; // use of int = no decimals, which is what the algorithm wants (however instead of using Math.Floor and double it made sense to use the data type int so it does the same function but more efficiently)
                int varC = year % 100; // finds the remainder of "year" when divided by 100
                int varD = varB / 4; // use of int = no decimals, which is what the algorithm wants (however instead of using Math.Floor and double it made sense to use the data type int so it does the same function but more efficiently) 
                int varE = varB % 4; // finds the remainder of the value of "varB" when divided by 4
                int varF = (varB + 8) / 25; // use of int = no decimals, which is what the algorithm wants (however instead of using Math.Floor and double it made sense to use the data type int so it does the same function but more efficiently) 
                int varG = (varB - varF + 1) / 3; // use of int = no decimals, which is what the algorithm wants (however instead of using Math.Floor and double it made sense to use the data type int so it does the same function but more efficiently) 
                int varH = (19 * varA + varB - varD - varG + 15) % 30; // finds the remainder of the eqution in the brackets when divded by 30
                int varI = varC / 4; // use of int = no decimals, which is what the algorithm wants (however instead of using Math.Floor and double it made sense to use the data type int so it does the same function but more efficiently) 
                int varK = varC % 4; // finds the remainder of "varC" when divided by 4
                int varL = (32 + 2 * varE + 2 * varI - varH - varK) % 7; // finds the remainder of of the eqution in the brackets when divided by 7
                int varM = (varA + 11 * varH + 22 * varL) / 451; // use of int = no decimals, which is what the algorithm wants (however instead of using Math.Floor and double it made sense to use the data type int so it does the same function but more efficiently) 

                int month = (varH + varL - 7 * varM + 114) / 31; // rounds down to the nearest integer, and does the final calcultion for the month -> outcomes will only be 3 or 4
                int day = ((varH + varL - 7 * varM + 114) % 31) + 1; // rounds down to the nearest integer, and does the final calcultion for the day -> outcomes will only be integers from 1 - 31

                if (month == 3) // checks if month is 3 (march) 
                {
                    Console.WriteLine("Easter will be on: " + day + " March " + year); // tells the user the date and the month (march) 
                }

                else // anything other than month = 3 (the reason I did else instead of else if is becuase there are only 2 possible outcomes)  
                {
                    Console.WriteLine("Easter will be on: " + day + " April " + year); // tells the user the date and the month (april) 
                }

                Console.WriteLine("Again? "); // asks the user if they want to run the code again 
                answer = Console.ReadLine(); // saves userinput to variable answer, to check if the while loops should be repeated or not
                Console.Clear(); // clears the screen for the code to be run again 
                Console.WriteLine("\t" + "\t" + "\t" + "\t" + "\t" + "Welcome to Easter Calculator!"); // sets the title of the program
                Console.WriteLine("");
            }

            Console.ReadKey(); // I'm not Barry Allen

            // https://www.census.gov/data/software/x13as/genhol/easter-dates.html#par_textimage_924432483 -> This is the website I used to confirm that my output/calculations were right
            // Algorithm Explaination: 

            // 1. Calculates the location of the year in the Metonic cycle 
            // 2. (var b mod 4) finds the # of leap days according to the Julian Calender 
            // 3. (var L) takes into account the non-leap year that lasts 1 extra day from the 52 weeks thus the 32 and % 7 
            // 4. (var H) incorprates the century of the year, so if the year given is in the 21st century -> varH = 24
            // 5. Basically this algorithm considers the Julian, Gergorian, Paschall Full Moon and combines their leap/non-leap days to find the center value of Easter

            // The mistakes made in the code you gave us, did the calcultion at the wrong time. For example,
            // (19 * varA + varB - varD - varG + 15) % 30 was done 1 line earlier in the program than compared to mine
            // Due to this, not all year values worked to give the correct date compared to my program 
            // Additionaly, in varF you multipled the varible by 8 even though you were supposed to add it by 8 

            // Code Explanantion: 

            // Firstly I start off by declearing my variables input and year. 
            // The purpose of these varibales is to store the user input to be used later.
            // After that, I ask the user to input the year they would like to know easter's date for.
            // Then, I read the input using .Readline() and save it to input
            // After that, I parse input as it was a string into a double value and save it to the varibale year (the reason I parsed it was because the year is a numerical value not a string)
            // Upon saving these inputs, I go through the Anonymous Gregorian algorithm and complete several mathmatical operations 
            // Once the algrioitm is finished, I save the last 2 equations in month and day. 
            // Then, I check if the month = 3, and if it does I inform the user the date and instead of typing 2 numbers, I type the number + march 
            // Lastly, I put an else statment for april becuase the varibale day can only equal 3 or 4. So, instead of rewriting what I did in the first line I just did else as there was only 1 more possiblity. 
            // The output is basically the same thing as for when month = 3 however, instead of saying March it says April 
        }
    }
}
