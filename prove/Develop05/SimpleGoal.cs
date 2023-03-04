public class SimpleGoal : Goal
{
    private bool _isFinished = false;
    public override void SaveToFile(string fileName)
    {
        Console.WriteLine("running SaveToFile from SimpleGoal");
    }
    public override void LoadFromFile(string fileName) //might go somewhere else
    {
        Console.WriteLine("running LoadFromFile from SimpleGoal");
    }
    public override int AccomplishGoal()
    {
        Console.WriteLine("running AccomplishGoal from SimpleGoal");
        return 0;
    }
}