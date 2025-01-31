using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int Val3 = 8;
            int Val4 = 10;
            Swap(ref Val3, ref Val4);
            Console.WriteLine("Val3 = " + Val3 + " and Val4 = " + Val4);
            Console.ReadKey(); 
        }

        public static void Swap(ref int Val1, ref int Val2)
        {
            int temp = Val1;
            Val1 = Val2;
            Val2 = temp;
        }
    }
}
