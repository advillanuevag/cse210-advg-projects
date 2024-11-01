using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Author: Alberto Villanueva
        Purpose: Prompt the user for their first name.
                 Then, prompt them for their last name. Display the text back all
                 on one line saying, "Your name is last-name, first-name, last-name".
        */

        //Display a message prompting for the User First Name.
        Console.WriteLine("What is your first name? ");

        //Read the First Name from the console and stores it in a variable
        //named firstName of type string.
        string firstName = Console.ReadLine();

        //Display a message prompting for the User Last Name.
        Console.WriteLine("What is your last name?");

        //Read the Last User Name from the console and stores it in a variable
        //named lirstName of type string.
        string lastName = Console.ReadLine();

        //Display the User Names using James Bond fashion.
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
        
    }
}