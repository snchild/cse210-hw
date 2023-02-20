public class BreathingActivity : Activity
{ 
    private int _secondsPassing;
    private List<string> _breathingMessage = new List<string>{"Breathe In...","Now Breathe out..."};

    public BreathingActivity(string name) : base(name)
    {
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void DisplayBreathing()//wip
    {
        Console.WriteLine("running DisplayBreathing from breathing activity");
        do{
            Console.WriteLine(_breathingMessage[0]);
            //pause for _secondsPassing
            Console.WriteLine(_breathingMessage[1]);
            //pause for _secondsPassing

            //check to see if the time has to pass

        }while (false); //until the time has passed

    }
}