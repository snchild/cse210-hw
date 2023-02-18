public class ListingActivity : Activity
{ 
    private List<string> _itemsList;
    //don't forget a construction method
    public void PromptItems()
    {
        Console.WriteLine("running PromptItems from listing activity");
    }
    public void DisplayLengths()
    {
        Console.WriteLine("running DisplayLengths from listing activity");
    }
}