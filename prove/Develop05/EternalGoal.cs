public class EternalGoal : Goal
{
    public override void SaveToFile(string fileName) //wip
    {
        List<string> info = GetGoalInfo();
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            outputFile.WriteLine($"EternalGoal; {info[0]}; {info[1]}; {info[2]}");
            
        }
    }
    public override void DisplayGoal(int number)
    {
        List<string> info = new List<string>();
        info = GetGoalInfo();
        
        Console.WriteLine($"{number}. [ ] {info[0]} ({info[1]})");
    }
}