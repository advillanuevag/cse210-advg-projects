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
        Console.WriteLine("Printing your Journal...");
        foreach(Entry entry in _entries)
        {
            entry.DisplayEntry();
        }

    }
}