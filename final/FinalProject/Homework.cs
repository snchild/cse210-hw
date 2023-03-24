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
        SetIsPast();
    }
    public override void SaveEvent(string fileName) //wip
    {
        Console.WriteLine("running SaveEvent from Homework ");

        List<string> info = GetEventDetails(); //call GetEventDetails
        List<string> locAndMat = GetLocationAndMaterials(); //call GetLocationAndMaterials

        using (StreamWriter outputFile = new StreamWriter(fileName, true))//open fileName
        {
            //write event type and all info
            //order: List<string> info, string where, string dueDate, int points, List<string> materials
            //info order: name, start day, start hour, start min, end day, end hour, end min, _isPast
            outputFile.Write($"Homework; {info[0]}; {info[1]}; {info[2]}; {info[3]}; {info[4]}; {info[5]}; {info[6]}; {info[7]}");

            //this writes where, when it's due, and points
            outputFile.Write($"; {locAndMat[0]}; {_whenDue}; {_points}");

            //writes the list of materials
            for (int j = 1; j < locAndMat.Count; j++)
            {
                outputFile.Write($"; {locAndMat[j]}");
            }
            outputFile.Write($"\n");            
        }
    }
}