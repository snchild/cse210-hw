public class Homework: School
{
    //attributes here
    private string _whenDue; //might be a different format  <- should it be a DateTime?
    private int _points;

    public Homework(List<string> info, string where, string dueDate, int points, List<string> materials): base(info, where, materials)//constructor here
    {
        _whenDue = dueDate;
        _points = points;
    }

    //methods here
    public override void DisplayEventDetails() //wip
    {
        Console.WriteLine("running DisplayEventDetails from Homework ");
        //call GetEventDetails
        //display info from GetEventDetails
        //call GetLocationAndMaterials
        //display info from GetLocationAndMaterials
        //display _whenDue and _points
    }
    public override void TimePast() //wip
    {
        Console.WriteLine("running TimePast from Homework ");
        //asks the user if they finished their homework
        //if no, it tells them to schedule another homework event
        //can i make them?
    }
    public override void SaveEvent(string fileName) //wip
    {
        Console.WriteLine("running SaveEvent from Homework ");
        //call GetEventDetails
        //call GetLocationAndMaterials
        //opens fileName
        //writes event type and all info
    }
}