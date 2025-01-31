using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Name: Ishaan Mittal 
//Date: <Nov 19 - Nov 21>
//Assigment: Assigment 4
//Purpose: To create a simulation of a math quiz 

namespace MathQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //I used this method for basically getting the user input on the min, max, and number of questoins and then passed these parametrs 
            //To my other method which creates a problem and then checks if the user is right.

            //Genreal explaination for all my input validation code (so I don't have to write a paragraph for each): 
            //Firstly, the tryParse trys to convert the string variable to the data type specified (int, double, etc).
            //If the conversion is successful, the converted value is stored in the value next to 'out', and it returs the boolean value true 
            //to indicate that the conversion was succesful. If the conversion is not successful, it doesn't crash the program 
            //instead it stores 0 in variable next to 'out' and returns the boolean value false to indicate that the string could not be converted 
            //addtionally, when it is not succesful it prints out an error message to the user to inform they are wrong, and asks them again 
            //I have a while loop running in the background so it keeps on informing the user that they are wrong until they type in a valid value
            //and end the loop. 
            //All in all, becuse of this my program doesn't crash and makes it more user friendly. 

            //Also just an FYI, I have many spaces in my program to keep it organized and not mix/mess me up, as most of the code is repetative 

            string min; //declaring variables 
            string max;

            string questions;
            int min2;
            int max2;
            int questions2;

            string quit;
            char quit2; 

            //Basically warns the user ahead of time you can't quit the quiz in the middle 
            Console.WriteLine("THERE WILL BE NO QUITING THE QUIZ AND YOU WILL HAVE TO COMPLETE THE WHOLE QUIZ"); //Used to warn the reader ahead of time
            Console.Write("Wanna quit whlie you have the chance (Y/N): ");
            quit = Console.ReadLine();

            while (Quit(quit) == false) //loops until the user enters a valid value 
            {

                Console.WriteLine("Sorry, " + quit + " is not a valid/logical value."); // Informs the user they made a mistake 
                Console.Write("Wanna quit whlie you have the chance (Y/N): "); // Asks again 
                quit = Console.ReadLine();
            }

            quit2 = char.Parse(quit); //Parses for further testing 

            if (quit2 == 'N' || quit2 == 'n')
            {
                Console.WriteLine("You have been warned"); // prints message 
            }

            else if (quit2 == 'Y' || quit2 == 'y') {
                Environment.Exit(1); // exits out of the enviroment (console)
            }

            Console.Write("Enter the minimum (positive): "); // asking the user to input the minimum 
            min = Console.ReadLine();

            while (InputVal(min) == false) //loops until the user enters a valid value 
            {

                Console.WriteLine("Sorry, " + min + " is not a valid/logical value."); // Informs the user they made a mistake 
                Console.Write("Enter the minimum (positive): "); // Asks the user again for the minimum 
                min = Console.ReadLine();

            }

            min2 = int.Parse(min); // stores the minimum into min2 by parsing into an integer so it can be used later in the program for its purpose. What I mean by purpose is that, if it is not parsed it would cause an error as you can't find a random of 2 different string values, thats not how the random class works 

            Console.Write("Enter the maximum (positive): "); // asking the user to input the maximum 
            max = Console.ReadLine();

            while (InputVal2(max, min2) == false) //loops until the user enters a valid value -> mathod takes 2 parameters to test the min and max as the min can't be greater than the max. 
            {
                Console.WriteLine("Sorry, " + max + " is not a valid/logical value."); // Informs the user they made a mistake 
                Console.Write("Enter the maximum (positive): "); // Asks the user again for the maximum 
                max = Console.ReadLine();

            }

            max2 = int.Parse(max); //same as above but for max 

            Console.Write("Enter the # of questions: "); // asks the user for the number of questions 
            questions = Console.ReadLine();

            while (InputVal(questions) == false) //loops until the user enters a valid value 
            {
                Console.WriteLine("Sorry, " + questions + " is not a valid/logical value."); // Informs the user they made a mistake 
                Console.Write("Enter the # of questions: "); // Asks the user again for the quesitons  
                questions = Console.ReadLine();
            }

            questions2 = int.Parse(questions); // same as above but for questions  


            Problem(min2, max2, questions2); //takes in the parsed int parameters min2, max2, questions2 to create a problem and then checks if the user is right. It also gives them their score and keeps into account their tries. 

            Console.ReadKey(); //Not Barrey Allen 
        }
        public static bool Quit(string value) //input validation for quiting if the user wnants to in the start 
        {
            char errorCheck;
            bool continueLoop;

            if (char.TryParse(value, out errorCheck) && errorCheck == 'Y' || errorCheck == 'y' || errorCheck == 'n' || errorCheck == 'N') //trys to parse the string value into a char and checks if the char vaue of erorr check is equal to one of the possible outcomes (y, Y, n, N) 
            {
                return continueLoop = true; //ends while loop that repeats asking the user for their option  
            }

            else //if errorCheck is not one of the possible outcomes excutes what is in the brackets 
            {
                return continueLoop = false; //continues while loop that repeats asking the user for their option  
            }
        }
        public static bool InputVal(string value) //input validation for min/questions  
        { 
            int errorCheck;
            bool continueLoop;

            if (int.TryParse(value, out errorCheck) && errorCheck > 0) //trys to parse the string value into an int, and if it is succesful returns true, which causes the while loop above to stop looping and save user input and transfer to the method problem 
            {
                return continueLoop = true; //returns bool value to stop while loop in main method 
            }

            else
            {
                return continueLoop = false; //returns false to continue while loop, until the user types in a valid value resutling in the int.tryparse to be succesful 
            }
        }

        public static bool InputVal2(string value, int value2) //input validation for max 
        { 
            int errorCheck;
            bool continueLoop;

            if (int.TryParse(value, out errorCheck) && errorCheck > 0 && errorCheck >= value2) //same comment as the one above (InputVal), however this one has one added condition where the max needs to be greater than the min, and if it is not it prints out the error message and continues the loop 
            {
                return continueLoop = true; //returns bool value to stop while loop in main method 
            }

            else
            {
                return continueLoop = false; //returns false to continue while loop, until the user types in a valid value resutling in the int.tryparse to be succesful 
            }
        }

        public static bool InputVal3(string value) //input validation for assesing userinput (their answer to the question)
        {  
            double errorCheck;
            bool continueLoop;

            if (double.TryParse(value, out errorCheck)) //other than the ones before this validation only focuses on checking for string/char values as the the value can be negative or a decimal. Why is why I tryParse it as a double becuase double takes into account decimals, and also this is why I didn't incude errorCheck > 0, as the value can be a negative
            {
                return continueLoop = true; //returns bool value to stop while loop in main method 
            }

            else if (value == "0") //I have to specify, as if I don't it will output 0 as an inavlid value which is not true in this situation 
            {
                return continueLoop = true; //returns bool value to stop while loop in main method 
            }

            else
            {
                return continueLoop = false; //returns false to continue while loop, until the user types in a valid value resutling in the int.tryparse to be succesful 
            }
        }
        public static void Problem(int min2, int max2, int check) // Method used for creating problem, assesing user input, showing the user's result, and all the processing/math in the background
        {
            Random random = new Random(); // varable declartion, I will talk more about the varibles on the lines I do stuff to them 
            Random random2 = new Random();
            double mathProb = 0;
            string guess;
            int counter = 1;
            int counter2 = 0;
            int correct = 0;
            int tries = 0;
            int loopCheck = 0;
            int num1;
            int num2;
            double guess2;

            Console.WriteLine("Disclaimer: you have 3 tries for each question"); // Tells the user how many tries they have 

            for (int i = 0; i < check; i++) // continues to run the program until it reaches the number of questions the user asked for 
            {
                loopCheck++; //increments value by 1. This variable is basically another i. Will talk more about it later. 
                num1 = random.Next(min2, max2); // generates the first number for the question based on the user's min and max 
                num2 = random.Next(min2, max2); // generates the second number for the question based on the user's min and max 

                int operation = random2.Next(1, 6); //generates a random number from 1-5 to represent the 5 operations +, -, x, /, ^

                while (true) //loop focuses on each question, and continues to loop until the user gets the right answer for each question 
                {

                    if (operation == 1) // if the random value is 1 then the operation of the problem is addition 
                    {

                        mathProb = num1 + num2; // creates the math problem 
                        Console.Write("What is " + num1 + " + " + num2 + ": "); // informs the user the problem 
                        guess = Console.ReadLine(); // takes the user answer 

                        while (InputVal3(guess) == false) //loops until user types valid value 
                        {
                            Console.WriteLine("Sorry, " + guess + " is not a valid value."); // tells them they are wrong 
                            Console.Write("What is " + num1 + " + " + num2 + ": "); // asks again 
                            guess = Console.ReadLine();
                        }

                        guess2 = Convert.ToDouble(guess); //saves user input into guess2 after the input validation to be used later in the program when comparing the user's guess and the answer to the problem. 

                        if (guess2 == mathProb) // checks if user guess is the answer to the problem 
                        {
                            if (counter == 1) //Checks if the user got it on their first try 
                            {
                                Console.WriteLine("Wow! First Try"); // prints that they got it on their first try 
                                tries += counter; // adds on to tries, which is going to be used in the end of program to infrom the user about the total tries 

                            }

                            else if (counter >= 2 && counter <= 3) //prints if they took 1+ tries but less than 3 as that is the max # of tries 
                            {
                                Console.WriteLine("Correct! You took " + counter + " tries to answer " + num1 + " + " + num2 + " correctly"); // informs them 
                                tries++; //adds to tries by 1 as without it here if the user got the answer on their 2nd or 3rd try it would not be added thus why I included it here
                            }

                            correct++; //adds on to the correct counter to be used later in the end of program when informing user on how many questions they got right
                            counter = 1; // resets counter to 1 the other questions (nested for-while loop) 
                            break; //ends the while loop, and begins for the next iteration of the for loop 
                        }

                        else // if the user got the question wrong 
                        {

                            Console.WriteLine("Wrong"); //tells them they are wrong 
                            counter++; //adds to the counter for # of tries 
                            counter2++; //while the other counter is used to keep track of the tries per question, this one is used to store all the tries so that it can be printed in the end through the varibles tries 
                            tries += counter2; //adds value of counter2. Note: the reason I do += for both counter2 and counter is becuase counter accounts for the numerical value of 1 while counter2 is for numerical values over 1, so the total # of tries are accurate 
                            counter2 = 0; // resets counter2 for next question 

                            if (counter == 4) // checks if the user has used all their tries (it's 4 bc counter starts at 1) 
                            {
                                Console.WriteLine("You lost all your tries, the answer was: " + mathProb); //Informs the user 
                                counter = 1; // resets counter for next question 
                                break; // ends while loop, for next question -> next iteration in for loop 
                            }
                        }

                    }

                    if (operation == 2) //everything is same as above however the problem is now for subtraction 
                    {
                        mathProb = num1 - num2; // creates the math problem 
                        Console.Write("What is " + num1 + " - " + num2 + ": "); // informs the user the problem 
                        guess = Console.ReadLine(); // takes the user answer 

                        while (InputVal3(guess) == false) //loops until user types valid value 
                        {
                            Console.WriteLine("Sorry, " + guess + " is not a valid value."); // tells them they are wrong 
                            Console.Write("What is " + num1 + " - " + num2 + ": "); // asks again 
                            guess = Console.ReadLine();
                        }

                        guess2 = Convert.ToDouble(guess); //saves user input into guess2 after the input validation to be used later in the program when comparing the user's guess and the answer to the problem. 

                        if (guess2 == mathProb) // checks if user guess is the answer to the problem 
                        {
                            if (counter == 1) //Checks if the user got it on their first try 
                            {
                                Console.WriteLine("Wow! First Try"); // prints that they got it on their first try 
                                tries += counter; // adds on to tries, which is going to be used in the end of program to infrom the user about the total tries 

                            }

                            else if (counter >= 2 && counter <= 3) //prints if they took 1+ tries but less than 3 as that is the max # of tries 
                            {
                                Console.WriteLine("Correct! You took " + counter + " tries to answer " + num1 + " - " + num2 + " correctly"); // informs them 
                                tries++; //adds to tries by 1 as without it here if the user got the answer on their 2nd or 3rd try it would not be added thus why I included it here
                            }

                            correct++; //adds on to the correct counter to be used later in the end of program when informing user on how many questions they got right
                            counter = 1; // resets counter to 1 the other questions (nested for-while loop) 
                            break; //ends the while loop, and begins for the next iteration of the for loop 
                        }

                        else // if the user got the question wrong 
                        {

                            Console.WriteLine("Wrong"); //tells them they are wrong 
                            counter++; //adds to the counter for # of tries 
                            counter2++; //while the other counter is used to keep track of the tries per question, this one is used to store all the tries so that it can be printed in the end through the varibles tries 
                            tries += counter2; //adds value of counter2. Note: the reason I do += for both counter2 and counter is becuase counter accounts for the numerical value of 1 while counter2 is for numerical values over 1, so the total # of tries are accurate 
                            counter2 = 0; // resets counter2 for next question 

                            if (counter == 4) // checks if the user has used all their tries (it's 4 bc counter starts at 1) 
                            {
                                Console.WriteLine("You lost all your tries, the answer was: " + mathProb); //Informs the user 
                                counter = 1; // resets counter for next question 
                                break; // ends while loop, for next question -> next iteration in for loop 
                            }
                        }

                    }

                    if (operation == 3) //everything is same as above however the problem is now for multiplication 
                    {
                        mathProb = num1 * num2; // creates the math problem 
                        Console.Write("What is " + num1 + " x " + num2 + ": "); // informs the user the problem 
                        guess = Console.ReadLine(); // takes the user answer 

                        while (InputVal3(guess) == false) //loops until user types valid value 
                        {
                            Console.WriteLine("Sorry, " + guess + " is not a valid value."); // tells them they are wrong 
                            Console.Write("What is " + num1 + " x " + num2 + ": "); // asks again 
                            guess = Console.ReadLine();
                        }

                        guess2 = Convert.ToDouble(guess); //saves user input into guess2 after the input validation to be used later in the program when comparing the user's guess and the answer to the problem. 

                        if (guess2 == mathProb) // checks if user guess is the answer to the problem 
                        {
                            if (counter == 1) //Checks if the user got it on their first try 
                            {
                                Console.WriteLine("Wow! First Try"); // prints that they got it on their first try 
                                tries += counter; // adds on to tries, which is going to be used in the end of program to infrom the user about the total tries 

                            }

                            else if (counter >= 2 && counter <= 3) //prints if they took 1+ tries but less than 3 as that is the max # of tries 
                            {
                                Console.WriteLine("Correct! You took " + counter + " tries to answer " + num1 + " x " + num2 + " correctly"); // informs them 
                                tries++; //adds to tries by 1 as without it here if the user got the answer on their 2nd or 3rd try it would not be added thus why I included it here
                            }

                            correct++; //adds on to the correct counter to be used later in the end of program when informing user on how many questions they got right
                            counter = 1; // resets counter to 1 the other questions (nested for-while loop) 
                            break; //ends the while loop, and begins for the next iteration of the for loop 
                        }

                        else // if the user got the question wrong 
                        {

                            Console.WriteLine("Wrong"); //tells them they are wrong 
                            counter++; //adds to the counter for # of tries 
                            counter2++; //while the other counter is used to keep track of the tries per question, this one is used to store all the tries so that it can be printed in the end through the varibles tries 
                            tries += counter2; //adds value of counter2. Note: the reason I do += for both counter2 and counter is becuase counter accounts for the numerical value of 1 while counter2 is for numerical values over 1, so the total # of tries are accurate 
                            counter2 = 0; // resets counter2 for next question 

                            if (counter == 4) // checks if the user has used all their tries (it's 4 bc counter starts at 1) 
                            {
                                Console.WriteLine("You lost all your tries, the answer was: " + mathProb); //Informs the user 
                                counter = 1; // resets counter for next question 
                                break; // ends while loop, for next question -> next iteration in for loop 
                            }
                        }

                    }

                    if (operation == 4)
                    {
                        double val3;
                        double val4;
                        val3 = Convert.ToDouble(num1); //I convert the original numbers into doubles as some of the questions could lead to decimals (i.e 3/4) 
                        val4 = Convert.ToDouble(num2);

                        mathProb = Math.Round(val3 / val4, 2); //Round to 2 decimal places instead of having the user type a billion numbers for questions like 1/3
                        Console.Write("What is " + num1 + " / " + num2 + " (round to 2 decimal places, if applicable): "); //asks the user the probelm 
                        guess = Console.ReadLine();

                        //same as above but for division 
                        while (InputVal3(guess) == false) //loops until user types valid value 
                        {
                            Console.WriteLine("Sorry, " + guess + " is not a valid value."); // tells them they are wrong 
                            Console.Write("What is " + num1 + " / " + num2 + " (round to 2 decimal places, if applicable): "); // asks again 
                            guess = Console.ReadLine();
                        }

                        guess2 = Convert.ToDouble(guess); //saves user input into guess2 after the input validation to be used later in the program when comparing the user's guess and the answer to the problem. 


                        if (guess2 == mathProb) // checks if user guess is the answer to the problem 
                        {
                            if (counter == 1) //Checks if the user got it on their first try
                            {
                                Console.WriteLine("Wow! First Try"); // prints that they got it on their first try 
                                tries += counter; // adds on to tries, which is going to be used in the end of program to infrom the user about the total tries 

                            }

                            else if (counter >= 2 && counter <= 3)
                            {
                                Console.WriteLine("Correct! You took " + counter + " tries to answer " + num1 + " / " + num2 + " correctly"); // informs them 
                                tries++; //adds to tries by 1 as without it here if the user got the answer on their 2nd or 3rd try it would not be added thus why I included it here
                            }

                            correct++; //adds on to the correct counter to be used later in the end of program when informing user on how many questions they got right
                            counter = 1; // resets counter to 1 for the other questions (nested for-while loop) 
                            break; //ends the while loop, and begins for the next iteration of the for loop 
                        }

                        else
                        {

                            Console.WriteLine("Wrong"); //tells them they are wrong 
                            counter++; //adds to the counter for # of tries 
                            counter2++; //while the other counter is used to keep track of the tries per question, this one is used to store all the tries so that it can be printed in the end through the varibles tries 
                            tries += counter2; //adds value of counter2. Note: the reason I do += for both counter2 and counter is becuase counter accounts for the numerical value of 1 while counter2 is for numerical values over 1, so the total # of tries are accurate 
                            counter2 = 0; // resets counter2 for next question 


                            if (counter == 4)
                            {
                                Console.WriteLine("You lost all your tries, the answer was: " + mathProb); //Informs the user 
                                counter = 1; // resets counter for next question 
                                break; // ends while loop, for next question -> next iteration in for loop 
                            }
                        }

                    }

                    if (operation == 5) // if the random value is 5 then the operation of the problem is exponent  
                    {

                        mathProb = Math.Pow(num1, num2); // creates the math problem 
                        Console.Write("What is " + num1 + " ^ " + num2 + ": "); // informs the user the problem 
                        guess = Console.ReadLine(); // takes the user answer 

                        while (InputVal3(guess) == false) //loops until user types valid value 
                        {
                            Console.WriteLine("Sorry, " + guess + " is not a valid value."); // tells them they are wrong 
                            Console.Write("What is " + num1 + " ^ " + num2 + ": "); // asks again 
                            guess = Console.ReadLine();
                        }

                        guess2 = Convert.ToDouble(guess); //saves user input into guess2 after the input validation to be used later in the program when comparing the user's guess and the answer to the problem. 

                        if (guess2 == mathProb) // checks if user guess is the answer to the problem 
                        {
                            if (counter == 1) //Checks if the user got it on their first try 
                            {
                                Console.WriteLine("Wow! First Try"); // prints that they got it on their first try 
                                tries += counter; // adds on to tries, which is going to be used in the end of program to infrom the user about the total tries 

                            }

                            else if (counter >= 2 && counter <= 3) //prints if they took 1+ tries but less than 3 as that is the max # of tries 
                            {
                                Console.WriteLine("Correct! You took " + counter + " tries to answer " + num1 + " ^ " + num2 + " correctly"); // informs them 
                                tries++; //adds to tries by 1 as without it here if the user got the answer on their 2nd or 3rd try it would not be added thus why I included it here
                            }

                            correct++; //adds on to the correct counter to be used later in the end of program when informing user on how many questions they got right
                            counter = 1; // resets counter to 1 the other questions (nested for-while loop) 
                            break; //ends the while loop, and begins for the next iteration of the for loop 
                        }

                        else // if the user got the question wrong 
                        {

                            Console.WriteLine("Wrong"); //tells them they are wrong 
                            counter++; //adds to the counter for # of tries 
                            counter2++; //while the other counter is used to keep track of the tries per question, this one is used to store all the tries so that it can be printed in the end through the varibles tries 
                            tries += counter2; //adds value of counter2. Note: the reason I do += for both counter2 and counter is becuase counter accounts for the numerical value of 1 while counter2 is for numerical values over 1, so the total # of tries are accurate 
                            counter2 = 0; // resets counter2 for next question 

                            if (counter == 4) // checks if the user has used all their tries (it's 4 bc counter starts at 1) 
                            {
                                Console.WriteLine("You lost all your tries, the answer was: " + mathProb); //Informs the user 
                                counter = 1; // resets counter for next question 
                                break; // ends while loop, for next question -> next iteration in for loop 
                            }
                        }

                    }
                }

                if (loopCheck < check) // checks if the loop counter (aka i) is less than the # of questions -> I used these few lines of code to seperate each question (in terms of clearing the screen and make my output look more organized  
                {
                    Console.WriteLine("\n" + "Press any button on your keyboard to continue to the next question!"); //tells the user to type any button in order to cancel out the readkey
                    Console.ReadKey(); // I used this to delay the clear, as without it would instatnly clear my screen without showing my last statment from the code above 
                    Console.Clear(); // clears the screen 
                }

            }

            Console.WriteLine("\n" + "Press any button on your keyboard to see your results!"); // same things as above but I put it at the very end of the program as that is when I will give the user their results 
            Console.ReadKey(); //doesn't instanlty clear screen 
            Console.Clear(); // clears the screen 
            double correct2 = Convert.ToDouble(correct); //converts int correct, into a double, correct2 -> as said before this varible was to keep track of the number of questions the user got right 
            double check2 = Convert.ToDouble(check); //converts int check, into a double, check2 -> this varible hold the total # of questions  

            //the reason I converted these values into doubles is becuase divsion usually leads to fractions and also beucase Math.Round only takes double values (I don't want the user to see You Scored 98.3444444444444444444444444444444%)
            double percent = Math.Round((correct2 / check2) * 100, 2); // calculates percent between the ratio of the answers the user got correct by the total # of questions, then multiples by 100 to get %

            Console.WriteLine("Congrats you finished the quiz! You scored " + percent + "%" + " with a total of " + tries + " tries "); //informs the user their score and total # of tries 


            //General Code Explaination: 
            //Firslty, the program asks the user if they want to take the quiz or not 
            //After, in the main method it asks the user for the min, max, and total # of questions 
            //Then, it passes those values into method Problem to complete the processing and present output 
            //Using the parameter values the method creates 2 random values from the min to max to be used in the question 
            //It also generates a random value 1-4 to declear what opertion the question will be
            //The for loop takes into account the number of questions and repeats the code until the number of quesitons is less than the counter 
            //The while loop takes into account each question and asks for the user's answer, validates input, checks their answer, then informs them if they are right or wrong 
            //Then, it ends looping once the user finds the answer or uses all their tries, and starts on the next question (next iteration on for loop) 
            //This cycle repeates until the for loop condition is false 
            //Once that is done, the screen is cleared and the user's total score (percentage) is shown and thier total tries 
        }
    }
}
