using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        /*
        Author: Alberto Villanueva Gudiño
        Purpose: Creating a design for a Developer project about 
                 creating a journal. In order to create the journal
                 program the classes Entry, Journal and GetRandomPrompt
                 will be created.
                 The program must show a menu with the following options:
                 1) Write
                 2) Display
                 3) Load
                 4) Save
                 5) Quit
                 What would you like to do?:
        */

        //Creates an instance of the object Journal named myJournal:
        Journal myJournal = new Journal();

        //The following code shows the menu options:
        int choice;
        do
        {
            Console.WriteLine("Please, select one of the following options:");
            Console.WriteLine("1) Write");
            Console.WriteLine("2) Display");
            Console.WriteLine("3) Load");
            Console.WriteLine("4) Save");
            Console.WriteLine("5) Quit");
            Console.WriteLine("What would you like to do?: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Writing a new Entry...");

                    Entry newEntry = new Entry();

                    PromptGenerator promptGenerator = new PromptGenerator();
                    string randomPrompt = promptGenerator.GetRandomPrompt();

                    Console.WriteLine($"Prompt: {randomPrompt}");

                    string userPrompt = Console.ReadLine();

                    newEntry._userResponse = userPrompt;
                    newEntry._randomPrompt = randomPrompt;
                    newEntry._date = "17/10/2024";

                    myJournal.AddEntry(newEntry);

                    break;
                case 2:
                    Console.WriteLine("Displayin Journal...");
                    myJournal.DispalyAll();
                    break;
                case 3:
                    Console.WriteLine("Load option selected.");
                    myJournal.LoadFromFile();
                    break;
                case 4:
                    Console.WriteLine("Save option selected.");
                    myJournal.SaveToFile();
                    break;
                case 5:
                    Console.WriteLine("Quitting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 5);






    }
}