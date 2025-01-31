using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Dec 05 - Dec 05> 
//Assignment: Lab12 
//Purpose: Testing .equals, indexof, trimm, and split 

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;

            if (x == 7) {
                Console.WriteLine("Here's 7"); 
            }

            string someone = "One Direction";

            if (someone.Equals("One Direction")) {
                Console.WriteLine("Found 'em"); 
            }

            string name = "John Doe the third";

            string Fname = name.Substring(0, 4);
            string Lname = name.Substring(5, 3);


            string Fname2 = name.Substring(0, name.IndexOf(' '));
            string Lname2 = name.Substring(name.IndexOf(' ') + 1, 3);
            string AlexAskedMe = name.Substring(name.IndexOf(' ', name.IndexOf(' ', name.IndexOf(' ') + 1)));

            Console.WriteLine("-->" + Fname2);
            Console.WriteLine(Lname2);

            Console.ReadKey(); 
        }
    }
}
