public class ListingActivity : Activity
{ 
    private List<string> _itemsList = new List<string>();
    private string _userInput;
    public ListingActivity(string name) : base(name)
    {
        _prompts = new List<string>{"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _userInput = new string("blank");
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("\nList as many responses you can to the following prompt: ");
        _currentPrompt = _prompts[GetRandom(_prompts.Count)];
        Console.WriteLine($" --- {_currentPrompt} --- ");
        
        Console.Write("\nYou may begin in: ");
        CountDown(3);
    }
    public void PromptItems()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime;

        Console.WriteLine(" "); //makes spacing work out better

        do{
            Console.Write("> ");
            _userInput = Console.ReadLine();
            _itemsList.Add(_userInput);

            currentTime = DateTime.Now;//update currentTime

        } while (currentTime < futureTime); //time hasn't run out yet
    }
    public void DisplayLengths()
    {
        Console.WriteLine($"You listed {_itemsList.Count} items!");
    }
}