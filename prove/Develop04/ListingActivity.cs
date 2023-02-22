public class ListingActivity : Activity
{ 
    private List<string> _itemsList;
    private string _userInput;
    public ListingActivity(string name) : base(name)
    {
        _prompts = new List<string>{"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _userInput = "blank";
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("\nList as many responses you can to the following prompt: ");
        _currentPrompt = _prompts[GetRandom(_prompts.Count)];
        Console.WriteLine($" --- {_currentPrompt} --- ");
        
        Console.Write("\nYou may begin in: ");
        CountDown(3);
    }
    public void PromptItems()//wip
    {
        Console.WriteLine("running PromptItems from listing activity");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime;

        do{
            Console.Write("> ");
            _userInput = Console.ReadLine();
            _itemsList.Add(_userInput); //Object reference not set to an instance of an object.

            currentTime = DateTime.Now;//update currentTime

        } while (currentTime < futureTime); //time hasn't run out yet
    }
    public void DisplayLengths()//wip
    {
        Console.WriteLine("running DisplayLengths from listing activity");
    }
}