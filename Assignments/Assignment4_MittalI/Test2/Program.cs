namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "Ishaan";

            string[] usernames = new string[4];
            usernames[0] = "Hi";
            usernames[1] = "Ishaan";
            usernames[2] = "Yo";
            usernames[3] = "SN";

           

            if (check(username, usernames) == false)
            {
                Console.WriteLine("LETS GO IT WORKED");
            }

            else {
                Console.WriteLine("Fail"); 
            }

            Console.ReadKey(); 
            
        }

        public static bool check(string username, string[] usernames)
        {
            bool checker = true; 
            for (int i = 0; i < usernames.Length; i++)
            { //checks thourgh all the elements in the username array 
                if (usernames[i] == username) //checks if the username inputted is actually in the text file/array or if the username is blank 
                {
                    checker = false; //returns false so the program does not output an error message to the user stating that the username is not in the text file, therfore meaning the user has not signed u
                }

            }

            if (checker == false)
            {
                return false;
            }

            else {
                return true; 
            }
        }
    }
}