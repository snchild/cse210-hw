public class EternalGoal : Goal
{
    public override void SaveToFile(string fileName)
    {
        Console.WriteLine("running SaveToFile from EternalGoal");
    }
    public override void LoadFromFile(string fileName) //might go somewhere else
    {
        Console.WriteLine("running LoadFromFile from EternalGoal");
    }
}