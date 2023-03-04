public class ChecklistGoal : Goal
{
    private int _progress;
    private int _pointsOnceDone;
    public override void SaveToFile(string fileName)
    {
        Console.WriteLine("running SaveToFile from ChecklistGoal");
    }
    public override void LoadFromFile(string fileName) //might go somewhere else
    {
        Console.WriteLine("running LoadFromFile from ChecklistGoal");
    }
    public override int AccomplishGoal()
    {
        Console.WriteLine("running AccomplishGoal from ChecklistGoal");
        return 0;
    }
    public override void SetGoalInfo(List<string> goalInfo)
    {
        Console.WriteLine("running SetGoalInfo from ChecklistGoal");
    }
}