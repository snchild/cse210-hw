public abstract class Goal
{
    private string _name;
    private string _description;
    private int _pointsForProgress; //previously named pointsToComplete

    //don't forget the creation method
    public abstract void SaveToFile(string fileName);
    public abstract void LoadFromFile(string fileName);
    public virtual int AccomplishGoal()
    {
        Console.WriteLine("running AccomplishGoal from Goal");
        return _pointsForProgress;
    }
    public List<string> GetGoalInfo()
    {
        Console.WriteLine("running GetGoalInfo from Goal");
        List<string> info = new List<string>(){_name,_description,"_pointsForProgress"};
        return info;
    }
    public string GetName()
    {
        Console.WriteLine("running GetName from Goal");
        return _name;
    }
    public int GetPoints()
    {
        Console.WriteLine("running GetPoints from Goal");
        return _pointsForProgress;
    }
    public virtual void SetGoalInfo(List<string> goalInfo)
    {
        Console.WriteLine("running SetGoalInfo from Goal");
        _name = goalInfo[0];
        _description = goalInfo[1];
        _pointsForProgress = int.Parse(goalInfo[2]);
    }

}