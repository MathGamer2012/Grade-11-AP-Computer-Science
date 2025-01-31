// See https://aka.ms/new-console-template for more information

string username = "Ishaan";

string[] usernames = new string[4];
usernames[0] = "Hi";
usernames[1] = "Ishaan";
usernames[2] = "Yo";
usernames[3] = "SN";


for (int i = 0; i < usernames.Length; i++)
{ //checks thourgh all the elements in the username array 
    if (usernames[i] == username) //checks if the username inputted is actually in the text file/array or if the username is blank 
    {
        Console.WriteLine("Hello kid"); 
        check = false; //returns false so the program does not output an error message to the user stating that the username is not in the text file, therfore meaning the user has not signed up

        lblStart.Text = "Enter your Password: "; //sets the text to displaying enter your password instead of enter your username
    }
}

if (check == true)
{ //based on the if statement above, if the username does not exsist in the text file, tells the user to sign up 
    MessageBox.Show("Username not found, please sign up"); //Informs user that username is not found and tht they should sign up
}


public static bool check(string username, string[] usernames) { 

}