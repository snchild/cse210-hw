public class Homework: School
{
    //attributes here
    private string _whenDue; //might be a different format
    private int _points;

    public Homework(List<string> info, string where, List<string> materials, string dueDate, int points): base(info, where, materials)//constructor here
    {
        _whenDue = dueDate;
        _points = points;
    }

    //methods here
    public override void DisplayEventDetails() //wip
    {
        Console.WriteLine("running DisplayEventDetails from Homework ");
    }

    public override void TimePast() //wip
    {
        Console.WriteLine("running TimePast from Homework ");
    }
    public override void SaveEvent(string fileName) //wip
    {
        Console.WriteLine("running SaveEvent from Homework ");
    }
}