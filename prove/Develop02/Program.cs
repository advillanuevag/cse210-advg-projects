using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        string randomPrompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"The RandomPrompt is: {randomPrompt}");

        Journal myJournal = new Journal();

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

                    // Reuse the existing instance
                    randomPrompt = promptGenerator.GetRandomPrompt();

                    Console.WriteLine($"Prompt: {randomPrompt}");
                    string userPrompt = Console.ReadLine();

                    newEntry._userResponse = userPrompt;
                    newEntry._randomPrompt = randomPrompt;
                    newEntry._date = DateTime.Now.ToString("dd/MM/yyyy"); // Dynamic date

                    myJournal.AddEntry(newEntry);
                    break;

                case 2:
                    Console.WriteLine("Displaying Journal...");
                    myJournal.DisplayAll(); // Fixed typo
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
