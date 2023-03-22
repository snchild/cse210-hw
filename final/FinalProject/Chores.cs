public class Chores: Event
{
    //attributes here
    private List<string> _materials = new List<string>();

    public Chores(List<string> info, List<string> materials): base(info)//constructor here
    {
        _materials = materials;
    }
    //methods here
    public override void DisplayEventDetails() //wip
    {
        Console.WriteLine("running DisplayEventDetails from Chores ");
        //call GetEventDetails
        //display info from GetEventDetails
        //display _materials
    }

    public override void TimePast() //wip
    {
        Console.WriteLine("running TimePast from Chores ");
        //congradulates the user on completing their chores
    }
    public override void SaveEvent(string fileName) //wip
    {
        Console.WriteLine("running SaveEvent from Chores ");
        //call GetEventDetails
        //opens fileName
        //writes event type and all info
    }
}