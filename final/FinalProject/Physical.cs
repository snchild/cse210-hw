public class Physical: Event
{
    //attributes here
    private List<string> _materials = new List<string>();
    private string _goal;

    public Physical(List<string> info, string goal, List<string> materials): base(info)//constructor here
    {
        _materials = materials;
        _goal = goal;
    }
    //methods here
    public override void DisplayEventDetails(List<string> days) //wip
    {
        List<string> info = GetEventDetails(); //call GetEventDetails
        Console.WriteLine($"\nPhysical: {info[0]} "); //display info from GetEventDetails
        Console.WriteLine($"When: {days[int.Parse(info[1])]} at {info[2]}:{info[3]} until {info[5]}:{info[6]}");
        
        Console.WriteLine($"\nGoal for the workout: {_goal}"); //display _materials and _goal
        Console.WriteLine($"\nMaterials: "); //display materials
        for(int j=0; j < _materials.Count; j++)
        {
            Console.WriteLine($"{_materials[j]}");
        }
        
    }

    public override void TimePast() //wip
    {
        Console.WriteLine($"Goal: {_goal}");

        Console.Write("Would you like to make a new goal? (y/n) "); //ask if user wants to make a new goal
        string newGoal = Console.ReadLine();
        
        if(newGoal == "y"){
            Console.Write("Please enter you new goal: "); //ask them what their new goal is
            _goal = Console.ReadLine(); //set _goal to their response  
        }
        SetIsPast();
    }
    public override void SaveEvent(string fileName) //wip
    {        
        List<string> info = GetEventDetails(); //call GetEventDetails
        using (StreamWriter outputFile = new StreamWriter(fileName, true))//open fileName
        {
            //order: List<string> info, string goal, List<string> materials
            //info order: name, start day, start hour, start min, end day, end hour, end min, _isPast
            outputFile.Write($"Physical; {info[0]}; {info[1]}; {info[2]}; {info[3]}; {info[4]}; {info[5]}; {info[6]}; {info[7]}");

            outputFile.Write($"; {_goal}");
            //writes the list of materials
            for (int j = 1; j < _materials.Count; j++)
            {
                outputFile.Write($"; {_materials[j]}");
            }
            outputFile.Write($"\n");
            
        }
    }
}