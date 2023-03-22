public class DateTime
{
    //attributes here
    int _date;
    int _hour;
    int _minute;

    //constructor
    public DateTime(int date, int hour, int min)
    {
        _date = date;
        _hour = hour;
        _minute = min;
    }
    //methods
    public List<int> GetDateAndTime()
    {
        Console.WriteLine("running GetDateAndTime from DateTime");
        List<int> info = new List<int>(){_date,_hour,_minute};
        return info;
    }
}