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
    public override void DisplayEventDetails(List<string> days) 
    {
        List<string> info = GetEventDetails(); //call GetEventDetails
        List<string> locAndMat = GetLocationAndMaterials();//call GetLocationAndMaterials

        Console.WriteLine($"\nClass: {info[0]} "); //display info from GetEventDetails
        Console.WriteLine($"When: {days[int.Parse(info[1]) - 1]} at {info[2]}:{info[3]} until {info[5]}:{info[6]}");
        Console.WriteLine($"Teacher: {_teacherName}"); //display _teacherName
        Console.WriteLine($"Attendance is required: {_attendanceRequired}");
        Console.WriteLine($"Location: {locAndMat[0]}"); //display info from GetLocationAndMaterials
        
        Console.WriteLine($"\nMaterials: "); //display materials
        for(int j=1; j < locAndMat.Count; j++)
        {
            Console.WriteLine($"{locAndMat[j]}");
        }
    }

    public override void TimePast()
    {
        Console.WriteLine($"{GetName()} is over now."); //displays a message saying class is over
        SetIsPast();
    }
    public override void SaveEvent(string fileName)
    {
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