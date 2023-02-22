public class FiveThingsActivity : Activity
{ 
    private List<string> _responses;

    public FiveThingsActivity(string name) : base(name)
    {
        _description = "This activity will help ground you by focusing on things that correspond to your five senses.";
        _prompts = new List<string>{"prompt1","prompt2","prompt3","prompt4", "prompt5"}; 
    } 

    public void PromptResponses()//wip
    {
        Console.WriteLine("running PromptResponses from five things activity");
    }

}