public class Physical: Event
{
    //attributes here
    private List<string> _materials = new List<string>();
    private string _goal;

    public Physical(List<string> info, List<string> materials, string goal): base(info)//constructor here
    {
        _materials = materials;
        _goal = goal;
    }
    //methods here
    public override void DisplayEventDetails() //wip
    {
        Console.WriteLine("running DisplayEventDetails from Physical ");
        //call GetEventDetails
        //display info from GetEventDetails
        //display _materials and _goal
    }

    public override void TimePast() //wip
    {
        Console.WriteLine("running TimePast from Physical ");
        //ask the user if they met their goal
        //ask the user if they would like to make a new goal
            //if so, ask them what their new goal is
            //set _goal to their response
    }
    public override void SaveEvent(string fileName) //wip
    {
        Console.WriteLine("running SaveEvent from Physical ");
        //call GetEventDetails
        //opens fileName
        //writes event type and all info
    }
}