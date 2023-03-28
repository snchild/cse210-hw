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
    public override void DisplayEventDetails(List<string> days) 
    {
        List<string> info = GetEventDetails(); //call GetEventDetails
        List<string> locAndMat = GetLocationAndMaterials(); //call GetLocationAndMaterials

        Console.WriteLine($"\nHomework: {info[0]} "); //display info from GetEventDetails
        Console.WriteLine($"When: {days[int.Parse(info[1]) - 1]} at {info[2]}:{info[3]} until {info[5]}:{info[6]}");
        Console.WriteLine($"Due Date: {_whenDue}\nPoints: {_points}"); //display _whenDue and _points
        Console.WriteLine($"Location: {locAndMat[0]}"); //display info from GetLocationAndMaterials
        
        Console.WriteLine($"\nMaterials: "); //display materials
        for(int j=1; j < locAndMat.Count; j++)
        {
            Console.WriteLine($"{locAndMat[j]}");
        }
    }
    public override void TimePast() 
    {
        //asks the user if they finished their homework
        Console.Write($"Did you finish your {GetName()}? (y/n) ");
        string finished = Console.ReadLine();
        
        if(finished == "n"){ //if no, it tells them to schedule another homework event
            Console.WriteLine($"You should schedule another time to do {GetName()}.");  
        }
        
        //can i make them schedule another event?
        SetIsPast();
    }
    public override void SaveEvent(string fileName)
    {
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