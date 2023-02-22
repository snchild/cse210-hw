public class ReflectionActivity : Activity
{ 
    private List<string> _questions;
    private string _currentQuestion;
    private int _secondsPassing;
    public ReflectionActivity(string name, int seconds) : base(name)
    {
        _prompts = new List<string>{"Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."};
        _questions = new List<string>{"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _secondsPassing = seconds;
    }
    public void DisplayPrompt()//wip
    {
        Console.WriteLine("running DisplayPrompt from listing activity");
        Console.WriteLine("\nConsider the following prompt: ");
        _currentPrompt = _prompts[GetRandom(_prompts.Count)];
        Console.WriteLine($"\n --- {_currentPrompt} --- \n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine(); //makes the program wait until they press enter
        
    }
    public void DisplayQuestion()//wip
    {        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime;

        Console.WriteLine(" "); //makes spacing work nicely
        do{
            _currentQuestion = _questions[GetRandom(_questions.Count)];
            Console.WriteLine(_currentQuestion);
            
            CountDown(_secondsPassing);
            Console.WriteLine(" ");
            
            currentTime = DateTime.Now;//update currentTime

        }while (currentTime < futureTime); //until the time has passed
    }
}