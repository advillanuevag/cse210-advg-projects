public class Journal
{
    //Defines the variable _entries as a List of Entry objects:
    public List<Entry> _entries = new List<Entry>();

    //Defines the AddEntry() method to append an Entry into the List _entries:
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);

    }


    public void DispalyAll()
    {
        //Display a message indicating that Journal is being printed:
        Console.WriteLine("Printing your Journal...");
        //Traverse the List _entries and acces DisplayEntry() method
        //located in Entry class by dot notation.
        foreach(Entry entry in _entries)
        {
            entry.DisplayEntry();
        }

    }

    public void SaveToFile()
    {
        //Save an entry into a file:
        Console.WriteLine("");
        Console.WriteLine("What is the file name?: ");
        string fileName = Console.ReadLine();
        Console.WriteLine("Saving to file...");

        using(StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("Date || Prompt || Response");
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} || {entry._randomPrompt} || {entry._userResponse}");
            }
        }
        Console.WriteLine("File saved succesfully!");

    }

    public void LoadFromFile()
    {
        Console.WriteLine("");
        Console.WriteLine("What is the file name?: ");
        string fileName = Console.ReadLine();

        Console.WriteLine("Loading from file...");
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach(string line in lines)
        {
            string[] parts = line.Split("||");
            string _date = parts[0];
            string _randomPrompt = parts[1];
            string _userResponse = parts[2];

            Console.WriteLine($"{_date} || {_randomPrompt} || {_userResponse}");
            Console.WriteLine("File loaded succesfully!");

        }
        

    }
}