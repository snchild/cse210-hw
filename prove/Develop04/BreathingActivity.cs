public class BreathingActivity : Activity
{ 
    private int _secondsPassing;
    private List<string> _breathingMessage = new List<string>{"Breathe In...","Now Breathe out..."};

    //don't forget a construction method
    public void DisplayBreathing()
    {
        Console.WriteLine("running DisplayBreathing from breathing activity");
    }
}