using System;

class Program
{
    static List<Event> CreateEvent(List<Event> myEvents) //wip
    {
        Console.WriteLine("\nHere is the list of even types: "); //display the list of event types
        Console.WriteLine("\t1. Chores");
        Console.WriteLine("\t2. Class time");
        Console.WriteLine("\t3. Homework");
        Console.WriteLine("\t4. Physical");
        Console.WriteLine("\t5. Social");
        Console.WriteLine("\t6. Spiritual");
        
        //prompt user for type of event they want to create
        Console.Write("What type of event would you like to make? ");
        int option = int.Parse(Console.ReadLine());

        Console.Write("\nWhat is the name of your event? "); //ask for name, start time, and end time
        string name = Console.ReadLine();
        Console.Write("What day does your event start? (Sunday is 1, Saturday 7) ");
        string startDay = Console.ReadLine();
        Console.Write("What is the hour your event starts (in military time)? ");
        string startHour = Console.ReadLine();
        Console.Write("What is the minute your event starts? ");
        string startMin = Console.ReadLine();
        Console.Write("What day does your event end? (Sunday is 1, Saturday 7) ");
        string endDay = Console.ReadLine();
        Console.Write("What is the hour your event ends (in military time)? ");
        string endHour = Console.ReadLine();
        Console.Write("What is the minute your event ends? ");
        string endMin = Console.ReadLine();

        //combine all into info
        List<string> info = new List<string>(){name, startDay, startHour, startMin, endDay, endHour, endMin, $"{false}"};

        //stretch goal: check whether time overlaps with another event

        //create corresponding event (use switch case)
        switch(option)
        {
            case 1: //chores
                //prompt the user for the needed details
                Console.Write("How many materials do you need for your chores? ");
                int numMat1 = int.Parse(Console.ReadLine());

                Console.WriteLine("What materials do you need?");
                List<string> mat1 = new List<string>();
                for(int j=0; j < numMat1; j++)
                {
                    string response = Console.ReadLine();
                    mat1.Add(response);
                }
                Chores event1 = new Chores(info, mat1);
                myEvents.Add(event1); //add that event to the event list
                break;

            case 2: //class time
                //prompt the user for the needed details
                Console.Write("Where is your class? ");
                string where2 = Console.ReadLine();

                Console.Write("Who is your teacher? ");
                string teacher = Console.ReadLine();

                Console.Write("Attendance is required, true or false? ");
                bool attendance = bool.Parse(Console.ReadLine());

                Console.Write("How many materials do you need for your class? "); //get materials
                int numMat2 = int.Parse(Console.ReadLine());
                Console.WriteLine("What materials do you need?");
                List<string> mat2 = new List<string>();
                for(int j=0; j < numMat2; j++)
                {
                    string response = Console.ReadLine();
                    mat2.Add(response);
                }
        
                Classtime event2 = new Classtime(info, where2, teacher, attendance, mat2); 
                myEvents.Add(event2); //add that event to the event list
                break;

            case 3: //homework
                //prompt the user for the needed details
                Console.Write("Where are you doing your homework? ");
                string where3 = Console.ReadLine();

                Console.Write("When is this homework due? ");
                string dueDate = Console.ReadLine();

                Console.Write("How many points is this homework worth? ");
                int points = int.Parse(Console.ReadLine());

                Console.Write("How many materials do you need for your homework? "); //get materials
                int numMat3 = int.Parse(Console.ReadLine());
                Console.WriteLine("What materials do you need?");
                List<string> mat3 = new List<string>();
                for(int j=0; j < numMat3; j++)
                {
                    string response = Console.ReadLine();
                    mat3.Add(response);
                }
                
                Homework event3 = new Homework(info, where3, dueDate, points, mat3);
                myEvents.Add(event3); //add that event to the event list
                break;

            case 4: //physical
                //prompt the user for the needed details
                Console.Write("What is your goal for this event? ");
                string goal = Console.ReadLine();

                Console.Write("How many materials do you need for your workout? "); //get materials
                int numMat4 = int.Parse(Console.ReadLine());
                Console.WriteLine("What materials do you need?");
                List<string> mat4 = new List<string>();
                for(int j=0; j < numMat4; j++)
                {
                    string response = Console.ReadLine();
                    mat4.Add(response);
                }

                Physical event4 = new Physical(info, goal, mat4);
                myEvents.Add(event4); //add that event to the event list
                break;

            case 5: //social
                //prompt the user for the needed details
                Console.Write("What is a description of this event? ");
                string description5 = Console.ReadLine();
                
                Console.Write("What do you anticipate spending for this event? $");
                double cost = double.Parse(Console.ReadLine());

                Console.Write("Where is this happening? ");
                string where5 = Console.ReadLine();

                Console.Write("How many people are also going? "); //get people
                int numPep5 = int.Parse(Console.ReadLine());
                Console.WriteLine("Who are those people?");
                List<string> people5 = new List<string>();
                for(int j=0; j < numPep5; j++)
                {
                    string response = Console.ReadLine();
                    people5.Add(response);
                }
                
                Social event5 = new Social(info, cost, where5, description5, people5);
                myEvents.Add(event5); //add that event to the event list
                break;

            case 6: //spiritual
                //prompt the user for the needed details
                Console.Write("How many people are also going? "); //get people
                int numPep6 = int.Parse(Console.ReadLine());
                Console.WriteLine("Who are those people?");
                List<string> people6 = new List<string>();
                for(int j=0; j < numPep6; j++)
                {
                    string response = Console.ReadLine();
                    people6.Add(response);
                }

                Spiritual event6 = new Spiritual(info, people6);
                myEvents.Add(event6); //add that event to the event list
                break;
        }
        
        return myEvents; //return the updated event list
    }
    static List<Event> CancelEvent(List<Event> myEvents) //wip
    {
        //prompt the user for the number of event to be deleted
        Console.Write("\nWhat is the number of the event you would like to cancel? ");
        int eventCancel = int.Parse(Console.ReadLine()) - 1; //this gets the index of the event
        
        if(eventCancel < myEvents.Count) //check if the input is valid
        {
            myEvents.RemoveAt(eventCancel); //delete that entry in myEvents
        }
        else{
            Console.WriteLine("That event didn't exist.");
        }
        
        return myEvents; //return updated event list
    }
    static void CheckTime(List<Event> myEvents) //wip
    {
        //prompt user for day and time
        Console.Write("What day is it? (1 is Sunday, 7 is Saturday) ");
        int day = int.Parse(Console.ReadLine());
        Console.Write("What hour is it (in military time)? ");
        int hour = int.Parse(Console.ReadLine());
        Console.Write("What minute is it? ");
        int minute = int.Parse(Console.ReadLine());
        
        //loop through event list
        for(int j=0; j < myEvents.Count; j++)
        {
            
            bool hasPassed = myEvents[j].HasPassed();
            List<int> time = myEvents[j].GetStartTime();

            //this is when isTime hasn't been called, but the time has passed
            if(!hasPassed && ((time[0] < day) || ((time[0] == day) && (time[1] < hour)) || ((time[0] == day) && (time[1] == hour) && (time[2] < minute))) )
            {
                //if _isPast is false, call TimePast() for the event
                myEvents[j].TimePast();
            }
        }
            
        //stretch goal: display the name of the event that's next up 
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
    static void DisplaySchedule(List<Event> myEvents)
    {
        //initialize variables
        List<string> info = new List<string>();
        List<string> days = new List<string>(){"Sunday", "Monday", "Tuesday","Wednesday", "Thursday","Friday","Saturday"};
        
        Console.WriteLine("\nYour schedule for the week: "); //display the schedule
        
        for(int i = 0; i < myEvents.Count; i++)
        { //make sure each event is numbered
            info = myEvents[i].GetEventDetails();
            Console.WriteLine($"\t{i+1}. {days[ int.Parse(info[1]) - 1 ]}\tfrom {info[2]}:{info[3]} to {info[5]}:{info[6]} - {info[0]}");
        }
    }
    static void DisplayEventInfo(List<Event> myEvents) //wip
    {
        List<string> days = new List<string>(){"Sunday", "Monday", "Tuesday","Wednesday", "Thursday","Friday","Saturday"};

        Console.Write("Which event would you like to see the details for? "); //prompt user for event number
        int detailedEvent = int.Parse(Console.ReadLine()) - 1; //this gets the index of the event
        
        if(detailedEvent < myEvents.Count) //check if the input is valid
        {
            myEvents[detailedEvent].DisplayEventDetails(days); //run DisplayEventDetails() for that event
        }
        else{
            Console.WriteLine("That event didn't exist.");
        }
    }
    static List<Event> LoadSchedule(List<Event> myEvents) //wip
    {
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
                    for(int j=11; j < parts.Length; j++ )
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
                    List<string> peopleList5 = new List<string>();//create materials list
                    for(int j=12; j < parts.Length; j++ )
                    {
                        peopleList5.Add(parts[j]);
                    }
                    //order: List<string> info, double cost, string where, string description, List<string> people
                    Social event5 = new Social(info, double.Parse(parts[9]), parts[10], parts[11], peopleList5);
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
                    DisplaySchedule(myEvents);
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