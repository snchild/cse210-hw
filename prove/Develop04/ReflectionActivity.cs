public class ReflectionActivity : Activity
{ 
    private List<string> _questions;
    private string _currentQuestion;
    private int _secondsPassing;
    //don't forget a construction method
    public void DisplayQuestion()
    {
        Console.WriteLine("running DisplayQuestion from reflection activity");
    }
}