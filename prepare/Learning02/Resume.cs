public class Resume
{
    // Create Member Variables
    public string _name;

    // Create and Initialize List of Job Objects.
    public List<Job> _myJobs = new List<Job>();

    // Constructor
    public Resume()
    {
        
    }

    // Method to Display Resume
    public void DisplayResume()
    {
        Console.WriteLine($"My Name is {_name}.");
        Console.WriteLine($"My Jobs:");

        // Iterate through the job object list and display each job.
        foreach (Job j in _myJobs)
        {
            j.DisplayJob();
        }
    }

}