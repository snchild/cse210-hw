public class Classtime: School
{
    //attributes here
    private string _teacherName;
    private bool _attendanceRequired;

    public Classtime(List<string> info, string where, string teacher, bool attendance, List<string> materials): base(info, where, materials)//constructor here
    {
        _teacherName = teacher;
        _attendanceRequired = attendance;
    }

    //methods here
    public override void DisplayEventDetails() //wip
    {
        Console.WriteLine("running DisplayEventDetails from  Classtime");
        //call GetEventDetails
        //display info from GetEventDetails
        //call GetLocationAndMaterials
        //display info from GetLocationAndMaterials
        //display _teacherName and _attendanceRequired 
    }

    public override void TimePast() //wip
    {
        Console.WriteLine("running TimePast from  Classtime");
        //displays a message saying class is over
    }
    public override void SaveEvent(string fileName) //wip
    {
        Console.WriteLine("running SaveEvent from Classtime ");
        //call GetEventDetails
        //call GetLocationAndMaterials
        //opens fileName
        //writes event type and all info
    }
}