using System;

class Program
{
    static void Main(string[] args)
    {
        /*
          Author: Alberto Villanueva
          Purpose: Practice the principle of Abstraction by creating clases
                   to represent a Resume or a Job History for a person like
                   you might see in LinkedIn.
        */

        //Create a new Job instance called job1:
        Job job1 = new Job();

        //Assign values to job1 variables:
        job1._companyName = "MicroSoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = "2022";
        job1._endYear = "2023";

        //Create a new Job instance called job2:
        Job job2 = new Job();

        //Assign values to job2 variables:
        job2._companyName = "Apple";
        job2._jobTitle = "Senior Software Engineer";
        job2._startYear = "2022";
        job2._endYear = "2024";

        //Create a new Resume instance called myResume:
        Resume myResume = new Resume();

        //Assignes a value to _personName variable:
        myResume._personName = "Alberto Villanueva";

        //Adds objects job1 and job2 to myResume:
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //Calls DisplayResumeDetails() Method from Resume class.
        myResume.DisplayResumeDetails();



    }
}