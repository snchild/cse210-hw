public class ReflectionActivity : Activity
{ 
    private List<string> _questions;
    private string _currentQuestion;
    private int _secondsPassing;
    public ReflectionActivity(string name, int seconds) : base(name)
    {
        _questions = new List<string>{"question1","question2","question3"};
        _secondsPassing = seconds;
    }
    public void DisplayQuestion()//wip
    {
        Console.WriteLine("running DisplayQuestion from reflection activity");
    }
}