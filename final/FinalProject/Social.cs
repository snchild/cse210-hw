public class Social: Event
{
    //attributes here
    private List<string> _whoWith = new List<string>();
    private double _cost;
    private string _location;
    private string _description;

    public Social(List<string> info, List<string> people, double cost, string where, string description): base(info)//constructor here
    {
        _whoWith = people;
        _cost = cost;
        _location = where;
        _description = description;
    }
    //methods here
    public override void DisplayEventDetails() //wip
    {
        Console.WriteLine("running DisplayEventDetails from Social ");
    }

    public override void TimePast() //wip
    {
        Console.WriteLine("running TimePast from Social ");
    }
    public override void SaveEvent(string fileName) //wip
    {
        Console.WriteLine("running SaveEvent from Social ");
    }
}