public class Classtime: School
{
    //attributes here
    private string _teacherName;
    private bool _attendanceRequired;

    public Classtime(List<string> info, string where, List<string> materials, string teacher, bool attendance): base(info, where, materials)//constructor here
    {
        _teacherName = teacher;
        _attendanceRequired = attendance;
    }

    //methods here
    public override void DisplayEventDetails() //wip
    {
        Console.WriteLine("running DisplayEventDetails from  Classtime");
    }

    public override void TimePast() //wip
    {
        Console.WriteLine("running TimePast from  Classtime");
    }
    public override void SaveEvent(string fileName) //wip
    {
        Console.WriteLine("running SaveEvent from Classtime ");
    }
}