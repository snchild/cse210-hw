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
        _startTime = new DateTime(int.Parse(info[1]),int.Parse(info[2]),int.Parse(info[3]));
        _endTime = new DateTime(int.Parse(info[4]),int.Parse(info[5]),int.Parse(info[6]));
        _isPast = false;
    }
    //methods here
    public abstract void DisplayEventDetails(List<string> days);
    public abstract void TimePast();
    public abstract void SaveEvent(string fileName);
    public void SetIsPast()
    {
        _isPast = true;
    }
    public List<string> GetEventDetails()
    {
        List<string> info = new List<string>(){_name};
        List<int> startInfo = _startTime.GetDateAndTime();
        List<int> endInfo = _endTime.GetDateAndTime();

        for(int j=0; j < startInfo.Count; j++)
        {
            info.Add($"{startInfo[j]}");
        }
        for(int k=0; k < startInfo.Count; k++)
        {
            info.Add($"{endInfo[k]}");
        }
        info.Add($"{_isPast}");
        return info;
    }
    public List<int> GetStartTime() 
    {
        return _startTime.GetDateAndTime();
    }
    
    public bool HasPassed() 
    {
        return _isPast;
    }

    public string GetName() 
    {
        return _name;
    } 
    public int GetStartDay()
    {
        List<int> dateAndTime = _startTime.GetDateAndTime();
        return dateAndTime[0];
    }
    public int GetStartHour()
    {
        List<int> dateAndTime = _startTime.GetDateAndTime();
        return dateAndTime[1];
    }
    public int GetStartMin()
    {
        List<int> dateAndTime = _startTime.GetDateAndTime();
        return dateAndTime[2];
    }
}