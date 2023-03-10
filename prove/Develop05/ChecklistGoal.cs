public class ChecklistGoal : Goal
{
    private int _progress;
    private int _times;
    private int _pointsOnceDone;
    public override void SaveToFile(string fileName) //wip
    {
        Console.WriteLine("running SaveToFile from ChecklistGoal");
        List<string> info = GetGoalInfo();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"ChecklistGoal; {info[0]}; {info[1]}; {info[2]}; {_pointsOnceDone}; {_progress}; {_times}");
            
        }
    }
    public override void LoadFromFile(string fileName) //might go somewhere else
    {
        Console.WriteLine("running LoadFromFile from ChecklistGoal");
    }
    public override int AccomplishGoal() //wip
    {
        Console.WriteLine("running AccomplishGoal from ChecklistGoal");
        _progress += 1;
        return GetPoints();
    }
    public void SetPointsOnceDone(int points)
    {
        _pointsOnceDone = points;
    }
    public void SetTimesTillDone(int times)
    {
        _times = times;
    }
    public void SetProgress(int p)
    {
        _progress = p;
    }
    public override void DisplayGoal(int number)
    {
        List<string> info = new List<string>();
        info = GetGoalInfo();
        
        string ex = " ";
        if(_progress >= _times){ex = "X";}

        Console.WriteLine($"{number}. [{ex}] {info[0]} ({info[1]}) -- Currently completed: {_progress}/{_times}");
    }
}