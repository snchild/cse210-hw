public abstract class Event
{
    //attributes here
    private string _name;
    private List<int> _startTime = new List<int>(); //in form (hours, minutes)
    private List<int> _endTime =  new List<int>(); //in form (hours, minutes)
    private bool _isPast;

    public Event(List<string> info) //constructor here
    {
        _name = info[0];
        _startTime.Add(int.Parse(info[1]));
        _startTime.Add(int.Parse(info[2]));
        _endTime.Add(int.Parse(info[3]));
        _endTime.Add(int.Parse(info[4]));
        _isPast = false;
    }
    //methods here
    public abstract void DisplayEventDetails();
    public abstract void TimePast();
    public abstract void SaveEvent(string fileName);
    public List<string> GetEventDetails() //wip
    {
        Console.WriteLine("running GetEventDetails from Event");
        List<string> info = new List<string>(){_name};
        info.Add($"{_startTime[0]}");
        info.Add($"{_startTime[1]}");
        info.Add($"{_endTime[0]}");
        info.Add($"{_endTime[1]}");
        info.Add($"{_isPast}");
        return info;
    }
    public List<int> GetStartTime() //wip
    {
        Console.WriteLine("running GetStartTime from Event");
        return _startTime;
    }
    
     
}