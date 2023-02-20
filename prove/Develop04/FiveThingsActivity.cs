public class FiveThingsActivity : Activity
{ 
    private List<string> _responses;

    public FiveThingsActivity(string name) : base(name)
    {
        _description = "This activity will help ground you by focusing on things that correspond to your five senses.";
    } 

    public void PromptResponses()//wip
    {
        Console.WriteLine("running PromptResponses from five things activity");
    }

}