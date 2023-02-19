public class BreathingActivity : Activity
{ 
    private int _secondsPassing;
    private List<string> _breathingMessage = new List<string>{"Breathe In...","Now Breathe out..."};

    public BreathingActivity(string name) : base(name)
    {
        //nothing actually happens here
    }
    public void DisplayBreathing()//wip
    {
        Console.WriteLine("running DisplayBreathing from breathing activity");
    }
}