public class ListingActivity : Activity
{ 
    private List<string> _itemsList;
    public ListingActivity(string name) : base(name)
    {
        _prompts = new List<string>{"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    public void DisplayPrompt()//wip
    {
        Console.WriteLine("running DisplayPrompt from listing activity");
        Console.WriteLine("Consider the following prompt: ");
        _currentPrompt = _prompts[GetRandom(_prompts.Count)];
        Console.WriteLine($" --- {_currentPrompt} --- ");
        
    }
    public void PromptItems()//wip
    {
        Console.WriteLine("running PromptItems from listing activity");
    }
    public void DisplayLengths()//wip
    {
        Console.WriteLine("running DisplayLengths from listing activity");
    }
}