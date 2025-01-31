using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Sept 23 - Sept 25> 
//Assignment: TotalPrice
//Purpose: To calculate the total price of different items including tax 

namespace TotalPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string Input = ""; // declaring variables, Note: the reason I did input = "" was becuase when I just wrote string Input; there was an error (use of unassigned local variable "Input")
            string ItemName = ""; 
            int Quantity; // you can't have a decimal of an item -> i'll take half of a car (doesnt make sense) 
            double ItemPrice;
            double TotalPrice;
            double Tax;
            double TotalTax; 

            var NameList = new List<string>(); // declaring lists for each item 
            var QuantityList = new List<int>();
            var PriceList = new List<double>();
            var TotalList = new List<double>();
            var TaxList = new List<double>();
            var TotalTaxList = new List<double>();

            Console.WriteLine("\t" + "\t" + "\t" + "\t" + "\t" + "Welcome to the Price Calculator Program!"); //prints the title of the program -> the reason this is not in the while loops is becuase I dont want this to repeat each time

            while (true) // runs the code until break is given -> break ends the loop in turn ending the code 
            {
                Console.Write("\n" + "Enter the name of the item (enter stop if finished): ");
                Input = Console.ReadLine();
                Input.ToLower(); // converts the string (Input) to lowercase letters to make the program case insenstive and to prevent the output from having an error message if the user types "Yes" instead of "yes"
                ItemName = Input; // setes ItemName to Input so the name of the item can be reffered to when askng for other outputs
                
                if (Input != "stop") // checks if the output is not "stop" then only adds to the list otherwise, it would have added the string stop to the list
                {
                    NameList.Add(Input); // adds the item to the list "NameList" 
                }

                if (Input != "stop") // checks again if input = stop, then only runs the program otherwise the program will never stop
                {
                    Console.Write("\n" + "Enter the price of " + ItemName + ": "); // asks the user for the price of the item 
                    Input = Console.ReadLine(); // reads the user input
                    Math.Round(ItemPrice = double.Parse(Input), 2); // assigns the userinput to ItemPrice -> rounds to 2 decimal places
                    PriceList.Add(ItemPrice); // adds the item's price to the list "PriceList" to be printed later

                    Console.Write("\n" + "Enter the quantity of " + ItemName + " (whole number, if you type decimal number it the decimals will be dropped): "); // asks the user for the quantity of the item
                    Input = Console.ReadLine(); // reads the user input
                    Quantity = int.Parse(Input); // saves userinput into "Quantity"
                    QuantityList.Add(Quantity); // adds the item's quantity to the list "QuantityList" to be printed later

                    Math.Round(TotalPrice = ItemPrice * Quantity, 2); // multiples the quantity by the price to get the total price (without tax) -> rounds to 2 decimal places
                    TotalList.Add(TotalPrice); // adds the item's total price to the list "TotalList" to be printed later

                    Math.Round(Tax = TotalPrice * 0.13, 2); // calculates the tax of the total price 0.13(TotalPrice) -> rounds to 2 decimal places
                    TaxList.Add(Tax); // adds the item's tax to the list "TaxList" to be printed later

                    Math.Round(TotalTax = TotalPrice * 1.13, 2); // calculates the price of the item including tax -> rounds to 2 decimal places
                    TotalTaxList.Add(TotalTax); // adds the total price of the item (including tax) to the list "TotalTax" to be printed later
                }

                if (Input == "stop") { // checks if the user wants to end the program and prints the following code which gives the user their "receipt"
                    Console.WriteLine(""); // prints the title of each category being outputed to the user 
                    Console.Write("Name");
                    Console.Write("\t" + "\t" + "Cost");
                    Console.Write("\t" + "\t" + "Quantity");
                    Console.Write("  " + "\t" + "Total");
                    Console.Write("\t" + "  " + "\t" + "Tax");
                    Console.WriteLine("\t" + "\t" + "Total with Tax");
                    Console.WriteLine("");

                    for (var i = 0; i < NameList.Count(); i++) // sets i to 0 (i is used as a counter) and increments it by 1 (i++), then repeats the code until i is less than the #of items in NameList 
                    {                     
                       Console.Write(NameList[i]); // Note the reason I did NameList.Count instead of doing it for each list, was because all the other lists have the same count and indexs as NameList
                       Console.Write("\t" + "\t" + "$" + PriceList[i]); // prints the name, price, quanitiy, total price (without tax), tax, and total price (with tax) of the item to the console
                       Console.Write("\t" + "  " + "\t" + QuantityList[i]);
                       Console.Write("\t" + "   " + "\t" + "$" + TotalList[i]);
                       Console.Write("\t" + "  " + "\t" + "$" + TaxList[i]);
                       Console.Write("\t" + "  " + "\t" + "$" + TotalTaxList[i] + "\n");
                    
                    }
 
                    Console.ReadKey(); // Im not Barry Allen 
                    break; // ends the while loop so the code doesn't repeat 
                    // for loops/while loops/arrays info from https://www.w3schools.com/
                }

            }
                
        }
    }
}
