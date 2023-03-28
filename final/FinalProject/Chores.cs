public class Chores: Event
{
    //attributes here
    private List<string> _materials = new List<string>();

    public Chores(List<string> info, List<string> materials): base(info)//constructor here
    {
        _materials = materials;
    }
    //methods here
    public override void DisplayEventDetails(List<string> days) //wip
    {
        List<string> info = GetEventDetails(); //call GetEventDetails
        Console.WriteLine($"\nChores: {info[0]} "); //display info from GetEventDetails
        Console.WriteLine($"When: {days[int.Parse(info[1])]} at {info[2]}:{info[3]} until {info[5]}:{info[6]}");
        
        Console.WriteLine($"\nMaterials needed: "); //display materials
        for(int j=0; j < _materials.Count; j++)
        {
            Console.WriteLine($"{_materials[j]}");
        }
    }

    public override void TimePast() //wip
    {
        Console.WriteLine("Congradulations! You copmleted your chores!"); 
        SetIsPast();
    }
    public override void SaveEvent(string fileName) //wip
    {
        List<string> info = GetEventDetails();//call GetEventDetails
        
        using (StreamWriter outputFile = new StreamWriter(fileName, true)) //open fileName
        {
            //write info, materials
            //info order: name, start day, start hour, start min, end day, end hour, end min, _isPast
            outputFile.Write($"Chores; {info[0]}; {info[1]}; {info[2]}; {info[3]}; {info[4]}; {info[5]}; {info[6]}; {info[7]}");
            for (int j = 0; j < _materials.Count; j++)
            {
                outputFile.Write($"; {_materials[j]}");
            }
            outputFile.Write("\n"); //makes it so the line ends
        }
        
    }
}