using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Ishaan Mittal 
//Date: <Nov 20 - Nov 212>
//Assigment: Assigment 4
//Purpose: To check what team is who on based on the user input  

namespace TeamSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            string students; //declaring varibales
            int students2;


            Console.Write("Type the # of students: "); //Asks the user for the # of studens 
            students = Console.ReadLine();

            while (InputVal(students) == false) { //loops until the user types a valid value, the method is responsible for the input validation where the tryparsing takes place (will talk about it more in the method itself) 
                Console.WriteLine("Sorry, " + students + " is not a valid value "); //error message to tell the user they are wrong 

                Console.Write("Type the # of students: "); //asks the user again 
                students = Console.ReadLine();
            }


            students2 = int.Parse(students); //converts # of students into a int value to be used later in the team method 
            team(students2); //sends the int value to team method -> will talk more about later 
            Console.ReadKey(); //Not Barrey Allen 

        }

        public static bool InputVal(string value) { //input validation for # of students 
            int errorCheck; 
            bool continueLoop;

            if (int.TryParse(value, out errorCheck) && errorCheck > 0) //trys to parse the string value into an int, and if it is succesful returns true, which causes the while loop above to stop looping and save user input and transfer to the method team
            {
                return continueLoop = true; //returns bool value to stop while loop in main method 
            }

            else
            {
                return continueLoop = false; //returns false to continue while loop, until the user types in a valid value resutling in the int.tryparse to be succesful 
            }
        }

        public static bool InputVal2(string value) //input validation for # of students 
        {
            char errorCheck;
            bool continueLoop;

            if (char.TryParse(value, out errorCheck) && errorCheck == 'M' || errorCheck == 'm' || errorCheck == 'F' || errorCheck == 'f') //trys to parse the string value into a char and checks if the char vaue of erorr check is equal to one of the possible outcomes (m, M, f, F)
            {
                return continueLoop = true; //ends while loop that repeats asking the user for their gender 
            }

            else //if errorCheck is not one of the possible outcomes excutes what is in the brackets 
            {
                return continueLoop = false; //continues while loop that repeats asking the user for their gender 
            }
        }

        public static bool InputVal3(string value) //input validation for grade 
        {
            int errorCheck;
            bool continueLoop;

            if (int.TryParse(value, out errorCheck) && errorCheck == 9 || errorCheck == 10 || errorCheck == 11 || errorCheck == 12) //trys to parse the string value into int and checks if the int value is one of the possible outcomes (9, 10, 11, 12) 
            {
                return continueLoop = true; //ends while loop that repeats asking the user for their grade 
            }

            else //if the int value errorCheck is not one the possible outcomes exctues the code in the bracket 
            {
                return continueLoop = false; //continues while loop that repeats asking the user for their grade 
            }
        }

        public static bool InputVal4(string value) //input validation for name 
        {
            

            string name; 
            bool check = false;
            char errorCheck; 

            bool continueLoop;


            if (char.TryParse(value, out errorCheck)) // parses into a char value to check if the user inputted a single letter as their name, which doesn't make sense, as a result returns false which outputs the error message and continues the loop until user writes a valid value 
            {
                return continueLoop = false; //ends while loop that repeats asking the user for their name 
            }

            for (int i = 0; i < value.Length; i++) //checks for special names (ie Ish@an or Ish11n), integers, decimals and returns check = true which ends the while loop
             { 
                name = Convert.ToString(value[i]); //converts all the single chracter values into a string

                if (name.ToUpper() == name.ToLower()) { //checks if the uppercase version of the string is the same as the lower case, and if it is returns check = true which continues the while loop. This is becuase if the user inputted an actual name/sting value the uppercase version of the name would not be the same as the lowercase, however for names with speical chracters or numbers nothing would happen to the numbers or special chracters as there is no uppercase or lowercase for a special chracter or number 
                    check = true; 
                }                      
            }
            if (check == true) //I put this here becuase I couldn't return the value in the for loop, so I just put in a checker for returning where if the checker was true the while loop would continue running whereas if it was false than the while loop asking for the name would stop running
            {
                return continueLoop = false; //continues while loop that repeats asking the user for their name
            }
            else
            {
                return continueLoop = true; //ends while loop that repeats asking the user for their name
            }

        }

        public static void team(int total)
        {
            string name; //varable declration 
            string gender;
            string grade;
            int grade2; 
            char gender2; 

            string maleJun = "";
            string maleSen = "";
            string femaleJun = "";
            string femaleSen = "";

            int counter = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0; 

            for (int i = 0; i < total; i++) { // loops code until the user has inputted all the students as per total (the value that passed on from main) 

                Console.Write("Enter your Name: "); //asks user for name 
                name = Console.ReadLine();

                while (InputVal4(name) == false) //repeats until user puts in a valid value 
                {
                    Console.WriteLine("Sorry, " + name + " is not a valid value "); //prints error message to tell the user they are wrong 
                    Console.Write("Enter your Name: "); //asks for name again 
                    name = Console.ReadLine();
                }

                Console.Write("Enter your gender (M for Male, F for Female): "); //asks user for gender 
                gender = Console.ReadLine();

                while (InputVal2(gender) == false) { //same comments as above but for gender 
                    Console.WriteLine("Sorry, " + gender + " is not a valid value ");
                    Console.Write("Enter your gender (M for Male, F for Female): ");
                    gender = Console.ReadLine(); 
                }

                gender2 = char.Parse(gender); //converts to a char value as originally it was a string 
                Console.Write("Enter your grade (9, 10, 11, 12): "); // asks user for grade 
                grade = Console.ReadLine();

                while (InputVal3(grade) == false) //same comments as above but for grade 
                {
                    Console.WriteLine("Sorry, " + grade + " is not a valid value ");
                    Console.Write("Enter your grade (9, 10, 11, 12): ");
                    grade = Console.ReadLine();
                }

                grade2 = int.Parse(grade); //converts to int value as originally it was a string 


                if ((grade2 == 9 || grade2 == 10) && (gender2 == 'M' || gender2 == 'm')) { //checks if the student is a juior male 
                    maleJun += name + ", "; //adds to the varible that prints the junior boys 
                    counter++; //adds onto counter that is used later to show input 
                }

                if ((grade2 == 11 || grade2 == 12) && (gender2 == 'M' || gender2 == 'm')) //same comments as above but for senior male 
                {
                    maleSen += name + ", ";
                    counter2++;
                }

                if ((grade2 == 9 || grade2 == 10) && (gender2 == 'F' || gender2 == 'f')) //same comments as above but for junior female 
                {
                    femaleJun += name + ", ";
                    counter3++;
                }

                if ((grade2 == 11 || grade2 == 12) && (gender2 == 'F' || gender2 == 'f')) //same comments as above but for senior female 
                {
                    femaleSen += name + ", ";
                    counter4++; 
                }
            }

            Console.WriteLine("\n" + "Press any button on your keyboard to see the teams!"); //informs user how to see the teams 
            Console.ReadKey(); //doesn't instanlty clear screen, causes a delay so no output is missed 
            Console.Clear(); //clears screen for teams

            //these if statments are here to check if each team even has 1 member. If they have 1+ members it prints the statment, otherwise prints nothing 
            //I put this here becuase lets suppose there are 0 senior girls, instead of still printing "The Senior Girl(s) is/are" with no names, it would make sense to not print anything at all, as it makes the program look more professinal 
            if (counter >= 1) { 
                Console.WriteLine("The Junior Boy(s) is/are: " + maleJun);
            }

            if (counter2 >= 1)
            {
                Console.WriteLine("The Senior Boy(s) is/are: " + maleSen);
            }

            if (counter3 >= 1)
            {
                Console.WriteLine("The Junior Girl(s) is/are: " + femaleJun);
            }

            if (counter4 >= 1)
            {
                Console.WriteLine("The Senior Girl(s) is/are: " + femaleSen);
            }

            //General Code Explaination: 
            //Firstly, the program starts off by asking user on the # of students there are and then after validiting input it sends the value for the # of students into the method team 
            //Then, it repetadly asks the user their name, gender, and grade until all students have been account for (for loop statment is false) 
            //While it is asking the user for their name, gender, and grade it validates their input, and if they make a mistake it informs the user and asks them for the value again 
            //After, through the use of if statments the program checks if the student belongs to the juior boys, senior boys, junior girls, or senior girls team based on their input 
            //Once the program indeitifies which team each student belongs on, the program outputs the team with all the names of students and their respected team 
        }
    }
}
