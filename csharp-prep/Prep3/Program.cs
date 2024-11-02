using System;

class Program
{
    static void Main(string[] args)
    {
        /*
          Author: Alberto Villanueva
          Purpose: Write My Number game, a program that make the computer ramdomly
                   generate a magic number, and then the user tries to guess it.
                   After each guess, the computer tells the user to guess "higher" 
                   or "lower" until they guess the magic number.
        */

        //Generates Randomly a number in the range 1 to 100, and stores the
        //value in the magicNumber variable.
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        //Set the variable playAgain in "yes" to allow the program to run the code
        //within the while.
        string playAgain = "yes";

        while(playAgain == "yes")
        {
            playAgain = "no";
            Console.WriteLine("Let´s see if you can guess the magic number...");

            int guess = 0;
            //Stretch Chalenge 1:
            int guessCounter = 1;

            //Keeps looping while guess does not math magicNumber.
            while(guess != magicNumber)
            {
                Console.WriteLine("What´s your guess?");
                string guesNumber = Console.ReadLine();
                guess = int.Parse(guesNumber);

                if(guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if(guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You Guessed it!");
                    Console.WriteLine($"You Guessed {guessCounter} times");
                }
                guessCounter += 1;
            }
            Console.WriteLine("Do you want to play again?");
            playAgain = Console.ReadLine();
            playAgain =playAgain.ToLower();


        }
        Console.WriteLine("Thank you for Playing the Guess number game!");

    }
}