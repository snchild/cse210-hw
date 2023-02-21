public class ReflectionActivity : Activity
{ 
    private List<string> _questions;
    private string _currentQuestion;
    private int _secondsPassing;
    public ReflectionActivity(string name, int seconds) : base(name)
    {
        _questions = new List<string>{"question1","question2","question3"};
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _secondsPassing = seconds;
    }
    public void DisplayQuestion()//wip
    {
        Console.WriteLine("running DisplayQuestion from reflection activity");
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime;

        Console.WriteLine(" "); //makes spacing work nicely
        do{
            _currentQuestion = _questions[GetRandom(_questions)];
            Console.WriteLine(_currentQuestion);
            
            CountDown(_secondsPassing);
            Console.WriteLine(" ");
            
            currentTime = DateTime.Now;//update currentTime

        }while (currentTime < futureTime); //until the time has passed
    }
}