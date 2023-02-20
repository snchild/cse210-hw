public class ListingActivity : Activity
{ 
    private List<string> _itemsList;
    public ListingActivity(string name) : base(name)
    {
        //nothing actually happens here
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
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