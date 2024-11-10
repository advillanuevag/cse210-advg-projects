public class Job
{
    //Create the class Job and Declare class variable names:
    public string _companyName;
    public string _jobTitle;
    public string _startYear;
    public string _endYear;

    //Declare DisplayJobDetails() Method to show the class variables:
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear} - {_endYear}")
    }

}