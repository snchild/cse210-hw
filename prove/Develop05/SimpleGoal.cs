public class SimpleGoal : Goal
{
    private bool _isFinished = false;
    public override void SaveToFile(string fileName) //wip
    {
        Console.WriteLine("running SaveToFile from SimpleGoal");
    }
    public override void LoadFromFile(string fileName) //might go somewhere else
    {
        Console.WriteLine("running LoadFromFile from SimpleGoal");
    }
    public override int AccomplishGoal() //wip
    {
        Console.WriteLine("running AccomplishGoal from SimpleGoal");
        _isFinished = true;
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