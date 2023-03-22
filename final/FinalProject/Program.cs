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
        //open the file and read all the lines
        //loop through all the lines
            //create events that correspond to the first segment in each line
            //add those events to the event list
        return myEvents; //return updated event list 
    }
    static void SaveSchedule(List<Event> myEvents) //wip
    {
        Console.WriteLine("running SaveSchedule from Program");
        //propmt the user for the file name
        //loop through events
            //run SaveEvent() for each event
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
                    break;
                case 2: //create event
                    break;
                case 3: //cancel event
                    break;
                case 4: //display event info
                    break;
                case 5: //save schedule
                    break;
                case 6: //load schedule
                    break;
                case 7: //check time
                    break;
                default: //quit or anything else
                    keepGoing = false;
                    break;
            }
        }while (keepGoing);
    }
}