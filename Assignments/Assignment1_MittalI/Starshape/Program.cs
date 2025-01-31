using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Sept 23 - Sept 24> 
//Assignment: StarShape
//Purpose: To create a shape using "*" and then animating the shape 

namespace Starshape
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string Input; // declearing the variable for my program 

            Console.WriteLine("\t" + "\t" + "\t" + "\t" + "\t" + "Welcome to the Shape Animation Program!"); //prints the title of the program
            Console.Write("\t" + "\t" + "\t" + "\t" + "\t" + "Type yes to see and animate the shape: "); //asks for user input if they wanna see/animate the shape
            Input = Console.ReadLine(); // saves the user input in the Input variable to be used later
            Input = Input.ToLower(); // converts the string (Input) to lowercase letters to make the program case insenstive and to prevent the output from having an error message if the user types "Yes" instead of "yes"

            if (Input == "yes") // checks if the user typed yes, and if they did outputs the code within the brackets (drawing and animating the shape) 
            {
                Console.Write("\n" + "\n" + "\n" + "*****************" + "\n" + "*" + "\t" + "\t" + "*" + "\n" + "*" + "\t" + "\t" + "*" + "\n" + "*" + "    " + "**" + "   " + "**" + "\t" + "*" + "\n" + "*" + "\t" + "*" + "\t" + "*" + "\n" + "*" + "     " + "*****" + "\t" + "*" + "\n" + "*" + "\t" + "\t" + "*" + "\n" + "*****************"); // draws the shape 
                Console.WriteLine("\n" + "Press enter to make me move!"); // informs users what to do in order to make the shape move
                Console.ReadLine(); // I use console.readline() so the user can control the shape, and when they press enter it moves
                Console.Clear(); // clears the screen so I can draw the next shape a tab away from its original position 

                Console.Write("\n" + "\n" + "\n" + "\t" + "*****************" + "\n" + "\t" + "*" + "\t" + "\t" + "*" + "\n" + "\t" + "*" + "\t" + "\t" + "*" + "\n" + "\t" + "*" + "    " + "**" + "   " + "**" + "\t" + "*" + "\n" + "\t" + "*" + "\t" + "*" + "\t" + "*" + "\n" + "\t" + "*" + "     " + "*****" + "\t" + "*" + "\n" + "\t" + "*" + "\t" + "\t" + "*" + "\n" + "\t" + "*****************"); // each time shape is drawn an extra \t is added after every \n inorder to make the shape "move" to a different position
                Console.ReadLine(); // Not going to comment the same thing 7 times, as it doesn't make sense and you understand the use of this code 
                Console.Clear(); 

                Console.Write("\n" + "\n" + "\n" + "\t" + "\t" + "*****************" + "\n" + "\t" + "\t" + "*" + "\t" + "\t" + "*" + "\n" + "\t" + "\t" + "*" + "\t" + "\t" + "*" + "\n" + "\t" + "\t" + "*" + "    " + "**" + "   " + "**" + "\t" + "*" + "\n" + "\t" + "\t" + "*" + "\t" + "*" + "\t" + "*" + "\n" + "\t" + "\t" + "*" + "     " + "*****" + "\t" + "*" + "\n" + "\t" + "\t" + "*" + "\t" + "\t" + "*" + "\n" + "\t" + "\t" + "*****************"); // adds \t 
                Console.ReadLine();
                Console.Clear();


                Console.Write("\n" + "\n" + "\n" + "\t" + "\t" + "\t" + "*****************" + "\n" + "\t" + "\t" + "\t" + "*" + "\t" + "\t" + "*" + "\n" + "\t" + "\t" + "\t" + "*" + "\t" + "\t" + "*" + "\n" + "\t" + "\t" + "\t" + "*" + "    " + "**" + "   " + "**" + "\t" + "*" + "\n" + "\t" + "\t" + "\t" + "*" + "\t" + "*" + "\t" + "*" + "\n" + "\t" + "\t" + "\t" + "*" + "     " + "*****" + "\t" + "*" + "\n" + "\t" + "\t" + "\t" + "*" + "\t" + "\t" + "*" + "\n" + "\t" + "\t" + "\t" + "*****************"); // adds \t
                Console.ReadLine();
                Console.Clear();

                //Return back (makes it return back to its original positions) -> basically removing \t
                Console.Write("\n" + "\n" + "\n" + "\t" + "\t" + "*****************" + "\n" + "\t" + "\t" + "*" + "\t" + "\t" + "*" + "\n" + "\t" + "\t" + "*" + "\t" + "\t" + "*" + "\n" + "\t" + "\t" + "*" + "    " + "**" + "   " + "**" + "\t" + "*" + "\n" + "\t" + "\t" + "*" + "\t" + "*" + "\t" + "*" + "\n" + "\t" + "\t" + "*" + "     " + "*****" + "\t" + "*" + "\n" + "\t" + "\t" + "*" + "\t" + "\t" + "*" + "\n" + "\t" + "\t" + "*****************"); // removes \t after every \n so the shape "moves" backwards to its original position
                Console.ReadLine();
                Console.Clear();

                Console.Write("\n" + "\n" + "\n" + "\t" + "*****************" + "\n" + "\t" + "*" + "\t" + "\t" + "*" + "\n" + "\t" + "*" + "\t" + "\t" + "*" + "\n" + "\t" + "*" + "    " + "**" + "   " + "**" + "\t" + "*" + "\n" + "\t" + "*" + "\t" + "*" + "\t" + "*" + "\n" + "\t" + "*" + "     " + "*****" + "\t" + "*" + "\n" + "\t" + "*" + "\t" + "\t" + "*" + "\n" + "\t" + "*****************"); // removes \t
                Console.ReadLine();
                Console.Clear();

                Console.Write("\n" + "\n" + "\n" + "*****************" + "\n" + "*" + "\t" + "\t" + "*" + "\n" + "*" + "\t" + "\t" + "*" + "\n" + "*" + "    " + "**" + "   " + "**" + "\t" + "*" + "\n" + "*" + "\t" + "*" + "\t" + "*" + "\n" + "*" + "     " + "*****" + "\t" + "*" + "\n" + "*" + "\t" + "\t" + "*" + "\n" + "*****************"); // removes \t
                Console.ReadLine();
                Console.WriteLine("Ok thats enough im done moving enough cardio for me! (press enter again to leave) "); // prints a goodbye message and tells the user what                 
            }

            else // shows a goodbye/error message if the user didn't type yes or made a mistake 
            {
                Console.WriteLine("\t" + "\t" + "I guess you didn't want to see the shape, Bye then! (Run the Program again if you made a mistake)"); // print goodbye/error message         

            }

            Console.ReadKey(); // Im not Barry Allen 
                               // got some info about console.clear() on https://learn.microsoft.com/en-us/dotnet/api/system.console.clear?view=net-6.0

        }
    }
}
