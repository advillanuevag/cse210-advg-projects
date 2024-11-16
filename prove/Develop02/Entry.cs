public class Entry
{
    //Declares class Entry variables:
    public string _date;
    public string _randomPrompt;
    public string _userResponse;

    //Declares and define DisplayEntry() method to show Entry information:
    public void DisplayEntry()
    {
        Console.WriteLine("");
        Console.WriteLine($"Date:{_date} - Prompt: {_randomPrompt}");
        Console.WriteLine($"{_userResponse}");
        Console.WriteLine("");
    }

}