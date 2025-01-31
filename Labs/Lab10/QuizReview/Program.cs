using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizReview
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Yo = true;
            int Moo;
            int Boo;

            Console.Write("Nrf");
            Console.Write("H"); 
            Console.WriteLine("DKKD");
            
            Console.Write("HI"); 
            for (Moo = 0; Moo < 3; Moo++) {
                Moo = Roll(Moo);
                Console.WriteLine(Moo); 
            }

            while (Yo == true) {
                Yo = Check(Moo);
                Moo--;
            }

            Console.ReadKey(); 
        }

        public static int Roll(int Recieve) {
            return Recieve + 1; 
        }

        public static bool Check(int Recieve) {
            if (Recieve > 3)
            {
                return true;
            }

            else {
                return false; 
            }
        }
    }
}
