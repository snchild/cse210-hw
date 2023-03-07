public class EternalGoal : Goal
{
    public override void SaveToFile(string fileName) //wip
    {
        Console.WriteLine("running SaveToFile from EternalGoal");
    }
    public override void LoadFromFile(string fileName) //might go somewhere else
    {
        Console.WriteLine("running LoadFromFile from EternalGoal");
    }
    public override void DisplayGoal(int number)
    {
        List<string> info = new List<string>();
        info = GetGoalInfo();
        
        Console.WriteLine($"{number}. [ ] {info[0]} ({info[1]})");
    }
}