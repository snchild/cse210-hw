public class Spiritual: Event
{
    //attributes here
    private List<string> _whoWith = new List<string>();
    private string _journal; //starting empty
    public Spiritual(List<string> info, List<string> people): base(info)//constructor here
    {
        _whoWith = people;
    }
    //methods here
    public override void DisplayEventDetails(List<string> days) //wip
    {
        Console.WriteLine("running DisplayEventDetails from Spiritual ");

        List<string> info = GetEventDetails(); //call GetEventDetails
        Console.WriteLine($"\n{info[0]}: "); //display info from GetEventDetails
        Console.WriteLine($"When: {days[int.Parse(info[1])]} at {info[2]}:{info[3]} until {info[5]}:{info[6]}");
        Console.WriteLine($"\nOther People: "); //display _whoWith
        for(int j=0; j < _whoWith.Count; j++)
        {
            Console.WriteLine($"{_whoWith[j]}");
        }

        if(bool.Parse(info[-1])) //checks to see if _isPast is true
        {
            Console.WriteLine($"Reflection from the event: {_journal}");
        }
    }

    public override void TimePast() //wip
    {
        Console.WriteLine("running TimePast from Spiritual ");
        
        //ask user what insight they gained from the event
        Console.WriteLine("What did you gain from this event? ");
        _journal = Console.ReadLine(); //save that to _journal
        
        SetIsPast();
    }
    public override void SaveEvent(string fileName) //wip
    {
        Console.WriteLine("running SaveEvent from Spiritual ");
        List<string> info = GetEventDetails(); //call GetEventDetails
        using (StreamWriter outputFile = new StreamWriter(fileName, true))//open fileName
        {
            //order: List<string> info, List<string> people
            //info order: name, start day, start hour, start min, end day, end hour, end min, _isPast
            outputFile.Write($"Spiritual; {info[0]}; {info[1]}; {info[2]}; {info[3]}; {info[4]}; {info[5]}; {info[6]}; {info[7]}");

            for (int j = 1; j < _whoWith.Count; j++) //writes the list of people
            {
                outputFile.Write($"; {_whoWith[j]}");
            }

            if(bool.Parse(info[-1])) //write _journal if it exists
            {
                outputFile.Write($"; {_journal}");
            }
            outputFile.Write($"\n");
            
        }
        
    }
}