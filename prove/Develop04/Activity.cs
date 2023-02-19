public class Activity{ //parent class for the activities
    
    private string _name;
    private string _startingMessage; //might not actually exist
    private string _finishingMessage;//might not actually exist
    private int _duration;
    private bool _continue; //might actually be in Program
    private string _description;
    private List<string> _prompts;
    private string _currentPrompt;
    public Activity(string name) //wip
    {
        _name = name;
    }
    public void DisplayBeginning() //wip
    {
        Console.WriteLine("running DisplayBeginning from parent activity");
    }
    public void DisplayEnding() //wip
    {
        Console.WriteLine("running DisplayEnding from parent activity");
    }
    public void PromptDuration() //wip
    {
        Console.WriteLine("running PromptDuration from parent activity");
    }
    public void Pause(int totalSeconds) //might not actually use; wip
    {
        Console.WriteLine("running Pause from parent activity");
    }
    public void DisplayPrompt()//wip
    {
        Console.WriteLine("running DisplayPrompt from parent activity");
    }
    public int GetRandom()//wip
    {
        Console.WriteLine("running GetRandom from parent activity");
        return 0;
    }

}