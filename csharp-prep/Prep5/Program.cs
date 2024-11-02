using System;

class Program
{
    static void Main(string[] args)
    {
        /*
          Author: Alberto Villanueva
          Purpose: For this assignment, write a C# program that has several 
                   simple functions:
                      DisplayWelcome - Displays the message, 
                                       "Welcome to the Program!"
                      PromptUserName - Asks for and returns the user's name 
                                       (as a string)
                      PromptUserNumber - Asks for and returns the user's favorite 
                                         number (as an integer)
                      SquareNumber - Accepts an integer as a parameter and returns 
                                     that number squared (as an integer)
                      DisplayResult - Accepts the user's name and the squared number 
                                      and displays them.
        */

        //Call the DisplayMessage() function to display a Welcome message.
        DisplayMessage();

        //Call the PromptUserName() function and return the userName.
        string userName = PromptUserName();

        //Call the PromptUserNumber() function and return the userNumber.
        int userNumber = PromptUserNumber();

        //Calle the SquareNumber() function with userNumber as parameter
        //and return the squaredNumber.
        int squaredNumber = SquareNumber(userNumber);

        //Call the DisplayResult() function and prints the userName and the favorite number squared.
        DisplayResult(userName, squaredNumber);

        //DisplayMessage() function.
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        //PromptUserName() Function.
        static string PromptUserName()
        {
            Console.WriteLine("Please, enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        //PromptUserNumber() Function.
        static int PromptUserNumber()
        {
            Console.WriteLine("Enter your favorite number: ");
            string userNumber = Console.ReadLine();
            int favoriteNumber = int.Parse(userNumber);
            return favoriteNumber;
        }



        //SquareNumber() Function.
        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;

        }

        //DisplayResult() Function.
        static void DisplayResult(string userName, int squared)
        {
            Console.WriteLine($"{userName}, the Squared of your favorite number is {squared}");
        }


    }
}