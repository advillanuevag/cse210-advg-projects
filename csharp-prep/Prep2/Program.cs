using System;

class Program
{
    static void Main(string[] args)
    {
        /*
          Author: Alberto Villanueva
          Purpose:Write a program that determines the letter grade for a course
                  according to the following scale:

                  A >= 90
                  B >= 80
                  C >= 70
                  D >= 60
                  F < 60
        */

        //Prompts the user for his/her grade.
        Console.WriteLine("What is your grade:? ");

        //Reads the user grade from Terminal, declares a string variable named grade
        //and assign the read value to this variable.
        string grade = Console.ReadLine();

        //Convert the variable grade from string to int.
        int number = int.Parse(grade);

        //Declares string variables letter and sign to be used later to stores
        //the student letter and the sign.
        string letter = "";
        string sign = "";

        //Determine the student letter based on the grade.
        if (number >= 90)
        {
            letter = "A";
            //Stretch chalenge 1, 2, 3:

            //Get the remainder from number divided by 10.
            int lastDigit = number % 10;

            //Determine the sign depending on lastDigit value.
            if (lastDigit >= 7)
            {
                sign = "";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else if (number >= 80)
        {
            letter = "B";
            int lastDigit = number % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";

            }

        }
        else if (number >= 7)
        {
            letter = "C";
            int lastDigit = number % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";

            }

        }
        else if (number >= 60)
        {
            letter = "D";
            int lastDigit = number % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";

            }

        }
        else
        {
            letter = "F";
            int lastDigit = number % 10;
            if (lastDigit >= 7)
            {
                sign = "";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }

        }

        //Show in the Console the Student letter and sign.
        Console.WriteLine($"Your Grade is: {letter} {sign}");

        //Validate if the Student Passed or Not and display a message in
        //consequence.
        if (number >= 70)
        {
            Console.WriteLine("Congratulations!, you Passed.");

        }
        else
        {
            Console.WriteLine("You Did not Pass!, We encourage you to try again.");
        }


    }
}