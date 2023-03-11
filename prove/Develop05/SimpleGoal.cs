public class SimpleGoal : Goal
{
    private bool _isFinished = false;
    public override void SaveToFile(string fileName) 
    {
        List<string> info = GetGoalInfo();
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            outputFile.WriteLine($"SimpleGoal; {info[0]}; {info[1]}; {info[2]}; {_isFinished}");
            
        }
    }
    public override int AccomplishGoal()
    {
        _isFinished = true;
        Console.WriteLine($"Congradualtions! You have earned {GetPoints()} points!");
        return GetPoints();
    }
    public override void DisplayGoal(int number)
    {
        List<string> info = new List<string>();
        info = GetGoalInfo();

        string ex = " ";
        if(_isFinished){ex = "X";}

        Console.WriteLine($"{number}. [{ex}] {info[0]} ({info[1]})");
    }
}