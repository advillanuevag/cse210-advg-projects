public class Resume{
    //Creates Resume class and declares it´s variable _personName:

    public string _personName;

    //Declares and instantiate the object _jobs as a List of objects
    //of Type Job.

    public List<Job> _jobs = new List<Job>();

    //Declares DisplayResumeDetails() Method to show the Person´s Name and
    //his or her Jobs:
    public void DisplayResumeDetails()
    {
        Console.WriteLine($"name: {_personName}");
        Console.WriteLine("Jobs:");

        //Travers the List _jobs, and for each element in the list (pega)
        //calls the DisplayJobDetails() Method using dot notation:
        foreach(Job pega in _jobs)
        {
            pega.DisplayJobDetails();
        }

    }
}   