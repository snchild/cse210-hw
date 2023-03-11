public abstract class Goal
{
    private string _name;
    private string _description;
    private int _pointsForProgress; 

    public abstract void SaveToFile(string fileName);
    public abstract void DisplayGoal(int number);
    public virtual int AccomplishGoal() 
    {
        Console.WriteLine($"Congradualtions! You have earned {_pointsForProgress} points!");
        return _pointsForProgress;
    }
    public List<string> GetGoalInfo()
    {
        List<string> info = new List<string>(){_name,_description,$"{_pointsForProgress}"};
        return info;
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