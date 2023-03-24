public class Social: Event
{
    //attributes here
    private List<string> _whoWith = new List<string>();
    private double _cost;
    private string _location;
    private string _description;

    public Social(List<string> info, double cost, string where, string description, List<string> people): base(info)//constructor here
    {
        _whoWith = people;
        _cost = cost;
        _location = where;
        _description = description;
    }
    //methods here
    public override void DisplayEventDetails() //wip
    {
        Console.WriteLine("running DisplayEventDetails from Social ");
        //call GetEventDetails
        //display info from GetEventDetails
        //display _whoWith, _cost, _location, and _description
    }

    public override void TimePast() //wip
    {
        Console.WriteLine("running TimePast from Social ");
        //ask the user how the event went
        //asks the user to rate their experience out of 5 stars
        SetIsPast();
    }
    public override void SaveEvent(string fileName) //wip
    {
        Console.WriteLine("running SaveEvent from Social ");
        List<string> info = GetEventDetails(); //call GetEventDetails
        using (StreamWriter outputFile = new StreamWriter(fileName, true))//open fileName
        {
            //order: List<string> info, double cost, string where, string description, List<string> people
            //info order: name, start day, start hour, start min, end day, end hour, end min, _isPast
            outputFile.Write($"Classtime; {info[0]}; {info[1]}; {info[2]}; {info[3]}; {info[4]}; {info[5]}; {info[6]}; {info[7]}");

            outputFile.Write($"; {_cost}; {_location}; {_description}");
            //writes the list of people
            for (int j = 1; j < _whoWith.Count; j++)
            {
                outputFile.Write($"; {_whoWith[j]}");
            }
            outputFile.Write($"\n");
            
        }
    }
}