public class Spiritual: Event
{
    //attributes here
    private List<string> _whoWith = new List<string>();
    private string _journal; //starting empty
    public Spiritual(List<string> info, List<string> people): base(info)//constructor here
    {
        _whoWith = people;
    }
    //methods here
    public override void DisplayEventDetails() //wip
    {
        Console.WriteLine("running DisplayEventDetails from Spiritual ");
    }

    public override void TimePast() //wip
    {
        Console.WriteLine("running TimePast from Spiritual ");
    }
    public override void SaveEvent(string fileName) //wip
    {
        Console.WriteLine("running SaveEvent from Spiritual ");
    }
    public void DisplayEntries() //wip
    {
        Console.WriteLine("running DisplayEntries from Spiritual");
    }
}