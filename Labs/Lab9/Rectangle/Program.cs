using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Nov 5 - Nov 5> 
//Assignment: Lab9 
//Purpose: To make a program that can create rectnagles using methods

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string check; 
            char letter;
            int width;
            int length;

            Console.Write("Type Y if you want to see a regular rectangle otherwise type N to see a hollow rectangle: ");
            check = Console.ReadLine();
            check.ToLower(); 

            Console.Write("Enter the letter for which you want the rectangle to look like: ");
            letter = char.Parse(Console.ReadLine());

            Console.Write("Enter the width of the rectangle: ");
            width = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of the rectangle: ");
            length = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            if (check == "y")
            {
                RectanglePrint(letter, width, length);
            }

            else
            {
                HollowRectangle(letter, width, length);
            }

            Console.ReadKey(); 
        }

        public static void RectanglePrint(char c, int width, int height)
        {
            int counter = 0; 

            while (counter != height) { 
                for (int i = 0; i < width; i++)
                {
                    Console.Write(c);
                }
                Console.Write("\n");
                counter += 1; 
            }
        }

        public static void HollowRectangle(char c, int width, int height)
        {
            int counter = 0;
            int counter2 = 0; // for width 

            while (counter != height)
            {
                if (counter == 0 || counter == (height - 1))
                {
                    for (int i = 0; i < width; i++)
                    {
                        Console.Write(c);
                        counter2 += 1;
                    }
                }
                else {
                    for (int i = 0; i < width; i++)
                    {
                        if (i == 0 || i == (width - 1)) { 
                        Console.Write(c); //ask how to do space thing 
                        }
                    }
                    //it has to overlap
                    //make two for loops for the lines 
                    //C//onsole.Write(c + " " + " " + " " + " " + c); 
                }
                Console.Write("\n");
                counter += 1;
            }
        }
    }
}
