public abstract class Event
{
    //attributes here
    private string _name;
    private DateTime _startTime;
    private DateTime _endTime;  
    private bool _isPast;

    public Event(List<string> info) //constructor here
    {
        _name = info[0];
        int date = int.Parse(info[1]);
        _startTime = new DateTime(int.Parse(info[1]),int.Parse(info[2]),int.Parse(info[3]));
        _endTime = new DateTime(int.Parse(info[4]),int.Parse(info[5]),int.Parse(info[6]));
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
        info.Add($"{_startTime}");
        info.Add($"{_endTime}");
        info.Add($"{_isPast}");
        return info;
    }
    public DateTime GetStartTime() //wip
    {
        Console.WriteLine("running GetStartTime from Event");
        return _startTime;
    }
    
     
}