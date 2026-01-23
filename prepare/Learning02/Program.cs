using System;

class Program
{
    static void Main(string[] args)
    {
        // Create new Job Object
        Job job1 = new Job();

        // Initialize New Job Object
        job1._company = "PWC";
        job1._jobTitle = "Accountant";
        job1._startYear = 2027;
        job1._endYear = 2031;

        // Create Another Job Object
        Job job2 = new Job();

        // Intialize New Job Objects
        job2._company = "Deloitte";
        job2._jobTitle = "Manager";
        job2._startYear = 2031;
        job2._endYear = 2036;

        // Create a new Resume Object
        Resume myResume = new Resume();

        // Initialize Resume Object
        myResume._name = "Josh";

        // Add jobs to Resume
        myResume._myJobs.Add(job1);
        myResume._myJobs.Add(job2);

        // Display my resume by calling the Resume method.
        myResume.DisplayResume();
    }
}