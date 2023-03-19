public class Physical: Event
{
    //attributes here
    private List<string> _materials = new List<string>();
    private string _goal;

    public Physical(List<string> info, List<string> materials, string goal): base(info)//constructor here
    {
        _materials = materials;
        _goal = goal;
    }
    //methods here
    public override void DisplayEventDetails() //wip
    {
        Console.WriteLine("running DisplayEventDetails from Physical ");
    }

    public override void TimePast() //wip
    {
        Console.WriteLine("running TimePast from Physical ");
    }
    public override void SaveEvent(string fileName) //wip
    {
        Console.WriteLine("running SaveEvent from Physical ");
    }
}