using System.Linq.Expressions;

namespace ApExamTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = new string("hi");
            string s2 = new string("hi there");
            string s3 = s2.Substring(0, 2);

            Console.WriteLine(s3); 
            Console.ReadKey(); 


        }
    }
}