public class theResume
{
    public string _Name;

    // Initializing the list to a new List before using it
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_Name}");
        Console.WriteLine($"Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}