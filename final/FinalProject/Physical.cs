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
    public override void DisplayEventDetails() //wip
    {
        Console.WriteLine("running DisplayEventDetails from Physical ");
        //call GetEventDetails
        //display info from GetEventDetails
        //display _materials and _goal
    }

    public override void TimePast() //wip
    {
        Console.WriteLine("running TimePast from Physical ");
        //ask the user if they met their goal
        //ask the user if they would like to make a new goal
            //if so, ask them what their new goal is
            //set _goal to their response
        SetIsPast();
    }
    public override void SaveEvent(string fileName) //wip
    {
        Console.WriteLine("running SaveEvent from Physical ");
        
        List<string> info = GetEventDetails(); //call GetEventDetails
        using (StreamWriter outputFile = new StreamWriter(fileName, true))//open fileName
        {
            //order: List<string> info, string goal, List<string> materials
            //info order: name, start day, start hour, start min, end day, end hour, end min, _isPast
            outputFile.Write($"Classtime; {info[0]}; {info[1]}; {info[2]}; {info[3]}; {info[4]}; {info[5]}; {info[6]}; {info[7]}");

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