public class BreathingActivity : Activity
{ 
    private int _secondsPassing;
    private List<string> _breathingMessage = new List<string>{"Breathe In...","Now Breathe out..."};

    public BreathingActivity(string name, int seconds) : base(name)
    {
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _secondsPassing = seconds;
    }
    public void DisplayBreathing()//wip
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime;

        Console.WriteLine(" "); //makes spacing work nicely
        do{
            Console.Write(_breathingMessage[0]);
            CountDown(_secondsPassing);

            Console.WriteLine(" ");
            Console.Write(_breathingMessage[1]);
            CountDown(_secondsPassing);

            Console.WriteLine(" \n");
            //update currentTime
            currentTime = DateTime.Now;

        }while (currentTime < futureTime); //until the time has passed

    }
}