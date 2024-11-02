using System;
//Add this code to work with lists.
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        /*
          Author: Alberto Villanueva.
          Purpose: Ask the user for a series of numbers, 
                   and append each one to a list. Stop when they enter 0.
                   The program Compute the sum, or total, of the numbers in the list,
                   and also Compute the average of the numbers in the list and
                   Find the maximum, or largest, number in the list.
        */

        //Declares the variable numbers as a List of int which will contain a list
        //of numbers later.
        List<int> numbers = new List<int>();

        //Declares a variable named largerNumber to save the larger number later.
        int largerNumber = 0;

        //Declares a variable named enterListOfNumbers and assignes a value of 1
        //allowing the program looping while enterListOfNUmbers is not equal to cero.
        int enterListOfNumbers = 1;


        while (enterListOfNumbers != 0)
        {
            //Read numbers from the Console.
            Console.WriteLine("Enter number or type 0 to quit: ");
            string userNumber = Console.ReadLine();
            enterListOfNumbers = int.Parse(userNumber);

            //If the number read from Console is not equal to 0, the number
            //is added to the list of int named numbers.
            if (enterListOfNumbers != 0)
            {
                numbers.Add(enterListOfNumbers);
            }
        }

        //Check if is there are any numbers entered.
        if (numbers.Count > 0)
        {
            //Computes the sum of the numbers
            int sum = 0;

            //Traverse the list of numbers
            foreach (int number in numbers)
            {
                //Computes the sum of numbers in the list.
                sum += number;

                //Computes the larger number.
                if (number > largerNumber)
                {
                    largerNumber = number;
                }

            }

            //Computes the average of the numbers.
            float average = ((float)sum) / numbers.Count;

            //Finds the smallest positive number.
            int? smallestPositive = numbers.Where(n => n > 0).OrderBy(n => n).FirstOrDefault();

            //Stretch Challenge 2) Sort the list of numbers
            numbers.Sort();

            //Output results.
            Console.WriteLine($"The sum is {sum}");
            Console.WriteLine($"The Average is {average}");
            Console.WriteLine($"The Larger Number is {largerNumber}");

            if (smallestPositive != 0)
            {
                Console.WriteLine($"The Smallest Positive Number is: {smallestPositive}");
            }
            else
            {
                Console.WriteLine("No positive numbers were entered.");
            }

            // Print the sorted list of numbers
            Console.WriteLine("The sorted list of numbers is: ");

            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }




    }
}