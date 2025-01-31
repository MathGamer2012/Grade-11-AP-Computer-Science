using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "John                    Doe";
            string Fname = word.Substring(0, word.IndexOf(' '));
            string Lname = word.Substring(word.IndexOf(' ') + 20, 3);

            Console.WriteLine(Fname);
            Console.WriteLine(Lname);
          
            Console.ReadKey(); 
        }
    }
}
