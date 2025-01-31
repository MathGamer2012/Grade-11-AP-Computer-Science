using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

//Name: Ishaan Mittal 
//Date: <Jan 11 - Jan 11> 
//Assignment: Lab 12
//Purpose: To save total price of different items into a recpiet 

namespace TotalPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double price;
            int quan;
            string check;
            double total;

            StreamWriter sr = new StreamWriter("receipt.txt");
            sr.Write("Name:" + "\t" + "\t" + "Price:" + "\n");

            while (true) {

                Console.Write("Type the name of the item: ");
                name = Console.ReadLine();

                Console.Write("Type the price of " + name + ": "); 
                price = double.Parse(Console.ReadLine());

                Console.Write("Type the quanitity of the item " + name + ": ");
                quan = int.Parse(Console.ReadLine());

                total = Math.Round((price * quan) * 1.13, 2);

                sr.Write(name + "\t" + "\t" + "$" + total + "\n");
                Console.WriteLine(""); 
                Console.WriteLine("Name:" + "\t" + "\t" + "Price:"); 
                Console.WriteLine(name + "\t" + "\t" + "$" + total);
                Console.WriteLine("");
                Console.WriteLine("Do you want to input more items? (Y/N)");
                check = Console.ReadLine();

                check.ToLower();

                if (check == "y")
                {
                    continue;
                }

                else
                {
                    break; 
                }


            }
            sr.Close(); 
            Console.ReadKey(); 
        }
    }
}
