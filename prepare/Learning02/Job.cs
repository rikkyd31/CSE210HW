public class Job
{
    // Member Variables
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Constructor (Called when creating a new instance/object of a class)
    public Job()
    {
        
    }


    // Member function (Method) to display job details.
    public void DisplayJob()
    {
        Console.WriteLine($"Company: {_company} ({_jobTitle}) {_startYear} - {_endYear}");
    }
}
