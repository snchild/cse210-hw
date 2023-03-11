public class ChecklistGoal : Goal
{
    private int _progress;
    private int _times;
    private int _pointsOnceDone;
    public override void SaveToFile(string fileName)
    {
        List<string> info = GetGoalInfo();
        using (StreamWriter outputFile = new StreamWriter(fileName,true))//"true" keeps it from writing over the file
        {
            outputFile.WriteLine($"ChecklistGoal; {info[0]}; {info[1]}; {info[2]}; {_pointsOnceDone}; {_progress}; {_times}");
            
        }
    }
    public override int AccomplishGoal()
    {
        _progress += 1;
        Console.WriteLine($"Congradualtions! You have earned {GetPoints()} points!");
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