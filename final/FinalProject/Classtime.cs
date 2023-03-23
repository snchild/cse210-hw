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

        List<string> info = GetEventDetails(); //call GetEventDetails
        List<string> locAndMat = GetLocationAndMaterials(); //call GetLocationAndMaterials

        using (StreamWriter outputFile = new StreamWriter(fileName, true))//open fileName
        {
            //write List<string> info, string where, string teacher, bool attendance, List<string> materials
            //info order: name, start day, start hour, start min, end day, end hour, end min, _isPast
            outputFile.Write($"Classtime; {info[0]}; {info[1]}; {info[2]}; {info[3]}; {info[4]}; {info[5]}; {info[6]}; {info[7]}");

            //this writes where, teacher, and attendace
            outputFile.Write($"; {locAndMat[0]}; {_teacherName}; {_attendanceRequired}");

            //writes the list of materials
            for (int j = 1; j < locAndMat.Count; j++)
            {
                outputFile.Write($"; {locAndMat[j]}");
            }
            outputFile.Write($"\n");
            
        }
    }
}