public class Activity{ //parent class for the activities
    
    private string _name;
    private string _finishingMessage;//might not actually exist
    private int _duration;
    protected string _description;
    private List<string> _prompts;
    private string _currentPrompt;
    public Activity(string name) //wip
    {
        _name = name;
    }
    public void DisplayBeginning()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n\n{_description}");
    }
    public void DisplayEnding()
    {
        Console.WriteLine("\nWell Done!");
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.\n");
        DisplaySpinner();
    }
    public void PromptDuration()
    {
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        string userInput = Console.ReadLine();
        _duration = int.Parse(userInput); 

        Console.Clear();
        Console.Write("Get ready...");
        DisplaySpinner();

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
    public void DisplaySpinner()
    {
        Thread.Sleep(500);
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the character
        Console.Write("\\"); // Replace it with the \ character
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the character
        Console.Write("-"); // Replace it with the - character
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the character
        Console.Write("/"); // Replace it with the / character
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the character
        Console.Write("|"); // Replace it with the | character
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the character
        Console.Write("\\"); // Replace it with the \ character
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the character
        Console.Write("-"); // Replace it with the - character
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the character
        Console.Write("/"); // Replace it with the | character
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the character
        Console.Write("\\"); // Replace it with the \ character
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the character
        
    }
}