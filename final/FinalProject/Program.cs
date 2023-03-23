using System;

class Program
{
    static List<Event> CreateEvent(List<Event> myEvents) //wip
    {
        Console.WriteLine("running CreateEvent from Program");
        //display the list of event types
        //prompt user for type of event they want to create
        //ask for name, start time, and end time
        //stretch goal: check whether time overlaps with another event
        //create corresponding event (use switch case)
        //prompt the user for the needed details
        //add that event to the event list
        return myEvents; //return the updated event list
    }
    static List<Event> CancelEvent(List<Event> myEvents) //wip
    {
        Console.WriteLine("running CancelEvent from Program");
        //prompt the user for the number of event to be deleted
        //delete that entry in myEvents
        return myEvents; //return updated event list
    }
    static void CheckTime(List<Event> myEvents) //wip
    {
        Console.WriteLine("running CheckTime from Program");
        //prompt user for day and time
        //loop through event list
            //if _isPast is false, call TimePast() for the event
        //display the name of the event that's next up 
    }
    static void DisplayOptions()
    {
        Console.WriteLine("\nOption Menu:");
        Console.WriteLine("\t1. Display Schedule");
        Console.WriteLine("\t2. Create Event");
        Console.WriteLine("\t3. Cancel Event");
        Console.WriteLine("\t4. Display Event Information");
        Console.WriteLine("\t5. Save Schedule");
        Console.WriteLine("\t6. Load Schedule");
        Console.WriteLine("\t7. Check The Time");
        Console.WriteLine("\t8. Quit\n");
    }
    static void DisplaySchedule(List<Event> myEvents) //wip
    {
        Console.WriteLine("running DisplaySchedule from Program");
        //display the schedule
        //make sure each event is numbered
    }
    static void DisplayEventInfo(List<Event> myEvents) //wip
    {
        Console.WriteLine("running DisplayEventInfo from Program");
        //prompt the user for the event number
        //run DisplayEventDetails() for that event 
    }
    static List<Event> LoadSchedule(List<Event> myEvents) //wip
    {
        Console.WriteLine("running LoadSchedule from Program");
        //prompt the user for the file name
        Console.Write("What is the name of your file? ");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName); //read the file, line by line

        foreach (string line in lines) //loop through the lines
        {
            string[] parts = line.Split("; "); //split the lines up into parts, separated by a ;

            //name, start day, start hour, start min, end day, end hour, end min, isPast
            List<string> info = new List<string>(){parts[1],parts[2],parts[3],parts[4],parts[5],parts[6],parts[7],parts[8]}; 

           //create events that correspond to the first segment in each line
            switch(parts[0])
            { 
                case "Chores":
                    //create materials list
                    List<string> materialsList1 = new List<string>();
                    for(int j=9; j < parts.Length; j++ )
                    {
                        materialsList1.Add(parts[j]);
                    }

                    Chores event1 = new Chores(info, materialsList1); //create event
                    myEvents.Add(event1);//add those events to the event list
                    break;

                case "Classtime":
                    bool attendance = bool.Parse(parts[11]); //change attendace to correct form
                    
                    List<string> materialsList2 = new List<string>();//create materials list
                    for(int j=9; j < parts.Length; j++ )
                    {
                        materialsList2.Add(parts[j]);
                    }
                    //order: List<string> info, string where, string teacher, bool attendance, List<string> materials
                    Classtime event2 = new Classtime(info, parts[9], parts[10], attendance, materialsList2); //create event
                    myEvents.Add(event2);//add those events to the event list
                    break;

                case "Homework":
                    List<string> materialsList3 = new List<string>();//create materials list
                    for(int j=12; j < parts.Length; j++ )
                    {
                        materialsList3.Add(parts[j]);
                    }

                    //order: List<string> info, string where, string dueDate, int points, List<string> materials
                    Homework event3 = new Homework(info, parts[9], parts[10], int.Parse(parts[11]), materialsList3); //create event
                    myEvents.Add(event3);//add those events to the event list
                    break;

                case "Physical":
                    List<string> materialsList4 = new List<string>();//create materials list
                    for(int j=10; j < parts.Length; j++ )
                    {
                        materialsList4.Add(parts[j]);
                    }
                    //order: List<string> info, string goal, List<string> materials
                    Physical event4 = new Physical(info, parts[9], materialsList4); //create event
                    myEvents.Add(event4); //add those events to the event list
                    break;

                case "Social":
                    List<string> materialsList5 = new List<string>();//create materials list
                    for(int j=10; j < parts.Length; j++ )
                    {
                        materialsList5.Add(parts[j]);
                    }
                    //order: List<string> info, double cost, string where, string description, List<string> people
                    Social event5 = new Social(info, double.Parse(parts[9]), parts[10], parts[11], materialsList5);
                    myEvents.Add(event5); //add those events to the event list
                    break;

                case "Spiritual":
                    List<string> peopleList = new List<string>();//create people list
                    for(int j=9; j < parts.Length; j++ )
                    {
                        peopleList.Add(parts[j]);
                    }
                    //order: List<string> info, List<string> people
                    Spiritual event6 = new Spiritual(info, peopleList);
                    myEvents.Add(event6);//add those events to the event list
                    break;
            }
        }
        return myEvents; //return updated event list 
    }
    static void SaveSchedule(List<Event> myEvents) //wip
    {
        Console.WriteLine("running SaveSchedule from Program");
        
        //prompt the user for the file name
        Console.Write("What is the name of your file? ");
        string fileName = Console.ReadLine();

        for (int j = 0; j < myEvents.Count; j++)//loop through events
        {
            myEvents[j].SaveEvent(fileName); //run SaveEvent() for each event
        }
            
    }
    static List<Event> SortEvents(List<Event> myEvents) //wip
    {
        Console.WriteLine("running SortEvents from Program");
        //loop through event list
            //call GetStartTime() for each event
            //sort the events based on their start times
        return myEvents; //return updated event list
    }
    static void Main(string[] args) //wip
    {
        //create variables
        bool keepGoing = true;
        List<Event> myEvents = new List<Event>();
        string inputString;
        int option;

        do{
            DisplayOptions(); //display the options

            Console.Write("Which option would you like? "); //prompt the user for their option
            inputString = Console.ReadLine(); 
            option = int.Parse(inputString);

            //enact those options using a switch case
            switch(option)
            {
                case 1: //display schedule
                    DisplayOptions();
                    break;
                case 2: //create event
                    myEvents = CreateEvent(myEvents);
                    break;
                case 3: //cancel event
                    myEvents = CancelEvent(myEvents);
                    break;
                case 4: //display event info
                    DisplayEventInfo(myEvents);
                    break;
                case 5: //save schedule
                    SaveSchedule(myEvents);
                    break;
                case 6: //load schedule
                    myEvents = LoadSchedule(myEvents);
                    break;
                case 7: //check time
                    CheckTime(myEvents);
                    break;
                default: //quit or anything else
                    keepGoing = false;
                    break;
            }
        }while (keepGoing);
    }
}