public abstract class Goal
{
    private string _name;
    private string _description;
    private int _pointsForProgress; //previously named pointsToComplete

    //don't forget the creation method
    public abstract void SaveToFile(string fileName);
    public abstract void DisplayGoal(int number);
    public virtual int AccomplishGoal() //wip 
    {
        Console.WriteLine("running AccomplishGoal from Goal");
        Console.WriteLine($"Congradualtions! You have earned {_pointsForProgress} points!");
        return _pointsForProgress;
    }
    public List<string> GetGoalInfo()
    {
        List<string> info = new List<string>(){_name,_description,$"{_pointsForProgress}"};
        return info;
    }
    public string GetName()  //wip
    {
        return _name;
    }
    public int GetPoints()
    {
        return _pointsForProgress;
    }
    public void SetGoalInfo(List<string> goalInfo)
    {
        _name = goalInfo[0];
        _description = goalInfo[1];
        _pointsForProgress = int.Parse(goalInfo[2]);
    }

}