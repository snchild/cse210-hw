public class Activity{ //parent class for the activities
    
    private string _name;
    private string _finishingMessage;//might not actually exist
    protected int _duration;
    protected string _description;
    private List<string> _prompts;
    private string _currentPrompt;
    private Random _rand = new Random();
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
        Console.WriteLine("Get ready...");
        DisplaySpinner();

    }
    public void DisplayPrompt()//wip
    {
        Console.WriteLine("running DisplayPrompt from parent activity");
        Console.WriteLine("Consider the following prompt: ");
        _currentPrompt = _prompts[GetRandom(_prompts)];
        Console.WriteLine($" --- {_currentPrompt} --- ");
        
    }
    public int GetRandom(List<string> list)//wip; might not actually exist......
    {
        int chosenIndex = _rand.Next(0,list.Count);
        return chosenIndex;
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

    public void CountDown(int highestNumber)
    {
        Thread.Sleep(100);
        for(int j = highestNumber; j > 0; j--)
        {
            Console.Write(j);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the character
            
        }
    }
}