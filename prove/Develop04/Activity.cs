public class Activity{ //parent class for the activities
    
    private string _name;
    private string _startingMessage;
    private string _finishingMessage;
    private int _duration;
    private bool _continue;
    private string _description;
    private List<string> _prompts;
    private string _currentPrompt;
    //don't forget a construction method
    public void DisplayBeginning()
    {
        Console.WriteLine("running DisplayBeginning from parent activity");
        Console.WriteLine("running  from parent activity");
    }
    public void DisplayEnding()
    {
        Console.WriteLine("running DisplayEnding from parent activity");
    }
    public void PromptDuration()
    {
        Console.WriteLine("running PromptDuration from parent activity");
    }
    public void Pause(int totalSeconds) //might not actually use
    {
        Console.WriteLine("running Pause from parent activity");
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("running DisplayPrompt from parent activity");
    }
    public int GetRandom()
    {
        Console.WriteLine("running GetRandom from parent activity");
        return 0;
    }

}