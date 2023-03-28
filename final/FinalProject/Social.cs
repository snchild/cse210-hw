public class Social: Event
{
    //attributes here
    private List<string> _whoWith = new List<string>();
    private double _cost;
    private string _location;
    private string _description;
    private int _stars;

    public Social(List<string> info, double cost, string where, string description, List<string> people): base(info)//constructor here
    {
        _whoWith = people;
        _cost = cost;
        _location = where;
        _description = description;
    }
    //methods here
    public override void DisplayEventDetails(List<string> days) //wip
    {
        List<string> info = GetEventDetails(); //call GetEventDetails
        Console.WriteLine($"\nSocial: {info[0]} "); //display info from GetEventDetails
        Console.WriteLine($"When: {days[int.Parse(info[1])]} at {info[2]}:{info[3]} until {info[5]}:{info[6]}");

        //display _cost, _location, and _description
        Console.WriteLine($"Expected Cost: {_cost}\nLocation: {_location}\nDescription: {_description}");
        Console.WriteLine($"\nOther People: "); //display _whoWith
        for(int j=0; j < _whoWith.Count; j++)
        {
            Console.WriteLine($"{_whoWith[j]}");
        }

        if(bool.Parse(info.Last())) //checks to see if _isPast is true
        {
            Console.WriteLine($"The event was {_stars} / 5 stars.");
        }
    }

    public override void TimePast() //wip
    {
        //asks the user to rate their experience out of 5 stars
        Console.Write("Please rate your experience out of 5 stars: ");
        _stars = int.Parse(Console.ReadLine());
        SetIsPast();
    }
    public override void SaveEvent(string fileName) //wip
    {
        List<string> info = GetEventDetails(); //call GetEventDetails
        using (StreamWriter outputFile = new StreamWriter(fileName, true))//open fileName
        {
            //order: List<string> info, double cost, string where, string description, List<string> people
            //info order: name, start day, start hour, start min, end day, end hour, end min, _isPast
            outputFile.Write($"Social; {info[0]}; {info[1]}; {info[2]}; {info[3]}; {info[4]}; {info[5]}; {info[6]}; {info[7]}");

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