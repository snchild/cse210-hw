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
        //call GetEventDetails
        //display info from GetEventDetails
        //display _whoWith
        //stretch goal: checks to see if _isPast is true
            //if so, call DisplayEntries()
    }

    public override void TimePast() //wip
    {
        Console.WriteLine("running TimePast from Spiritual ");
        //ask user what insight they gained from the event
        //save that to _journal
    }
    public override void SaveEvent(string fileName) //wip
    {
        Console.WriteLine("running SaveEvent from Spiritual ");
        //call GetEventDetails
        using (StreamWriter outputFile = new StreamWriter(fileName, true))//open fileName
        {
            //write event type and all info
            outputFile.WriteLine($"; ");
            
        }
        
    }
    public void DisplayEntries() //wip
    {
        Console.WriteLine("running DisplayEntries from Spiritual");
        //displays the journal entry
    }
}