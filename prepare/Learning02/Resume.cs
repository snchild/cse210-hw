public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name} \nJobs: ");
        _jobs[0].Display();
        _jobs[1].Display();
    }


}