public class Activity{ //parent class for the activities
    
    private string _name;
    protected int _duration;
    protected string _description;
    protected List<string> _prompts;
    protected string _currentPrompt;
    private Random _rand = new Random();
    public Activity(string name) 
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
        Console.WriteLine("\nWell Done!\n");
        DisplaySpinner();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.\n");
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

    public int GetRandom(int length)
    {
        int chosenIndex = _rand.Next(0,length);
        return chosenIndex; 
    }
    public void DisplaySpinner()
    {
        List<string> _spinner = new List<string>(){"|","\\","-","/","|","\\","-","/","|","\\"};

        Thread.Sleep(500);
        for(int j = 0; j < _spinner.Count; j++)
        {
            Console.Write(_spinner[j]); //write the current character
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the character
            
        }
        
    }

    public void CountDown(int highestNumber)
    {
        for(int j = highestNumber; j > 0; j--)
        {
            Console.Write(j);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the character
            
        }
    }
}