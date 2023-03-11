using System;
using System.IO; 

class Program
{
    static void DisplayMenu(int points)
    {
        Console.WriteLine($"\nYou have {points} points.\n");
        Console.WriteLine("Menu options: ");
        Console.WriteLine("\t1. Create New Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record Event");
        Console.WriteLine("\t6. Quit");
        Console.Write("Select a choice from the menu: ");
    }
    static void CreateGoal(int inputInt, string inputString, List<string> inputList, List<Goal> goals)
    {
        //prompt the user for the type of goal
        Console.WriteLine("\nThe type of goals are: ");
        Console.WriteLine("\t1. Checklist Goals");
        Console.WriteLine("\t2. Eternal Goals");
        Console.WriteLine("\t3. Simple Goals");
        Console.Write("What type of goal would you like to create? ");
        inputString = Console.ReadLine();
        inputInt = int.Parse(inputString);

        Console.Write("What is the name of your goal? "); //get the name
        inputString = Console.ReadLine();
        inputList.Add(inputString);

        Console.Write("What is a short description of it? "); //get the description
        inputString = Console.ReadLine();
        inputList.Add(inputString);

        Console.Write("What is the amount of points associated with this goal? ");
        inputString = Console.ReadLine();
        inputList.Add(inputString);
                    
        switch(inputInt){
            case 1: //checklist goal
                ChecklistGoal goal1 = new ChecklistGoal();
                 //add the goal's details to the goal
                goal1.SetGoalInfo(inputList);

                Console.Write("How many times does this goal need to be accomplished for a bonus? "); 
                inputString = Console.ReadLine();
                inputInt = int.Parse(inputString);
                goal1.SetTimesTillDone(inputInt);

                Console.Write("What is the bonus for accomplishing it that many times? ");
                inputString = Console.ReadLine();
                inputInt = int.Parse(inputString);
                goal1.SetPointsOnceDone(inputInt);

                goals.Add(goal1);
                break;

            case 2: //eternal goal
                EternalGoal goal2 = new EternalGoal();
                //add the goal's details to the goal
                goal2.SetGoalInfo(inputList);
                goals.Add(goal2);
                break;

            case 3: //simple goal
                SimpleGoal goal3 = new SimpleGoal();
                goal3.SetGoalInfo(inputList);
                goals.Add(goal3);
                break;    
        }
    }
    static int LoadGoals(string fileName, List<Goal> goals)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName); //read the file, line by line

        int newPoints = int.Parse(lines[0]); //deal with the points part
        lines = lines.Skip(1).ToArray(); 

        foreach (string line in lines) //loop through the lines
        {
            string[] parts = line.Split("; "); //split the lines up into parts, separated by a ;

            List<string> info = new List<string>(){parts[1],parts[2],parts[3]}; //name, description, points

            //use a switch case to create the correct type of goal
            switch(parts[0])
            { //set the correct attributes to the right values
                case "ChecklistGoal":
                    ChecklistGoal goal1 = new ChecklistGoal();
                    //add the goal's details to the goal
                    goal1.SetGoalInfo(info);
                    goal1.SetPointsOnceDone(int.Parse(parts[4])); //points for doing all
                    goal1.SetProgress(int.Parse(parts[5])); //progress
                    goal1.SetTimesTillDone(int.Parse(parts[6])); //times
                   
                    goals.Add(goal1); //add that goal to goals
                    break;

                case "EternalGoal":
                    EternalGoal goal2 = new EternalGoal();
                    //add the goal's details to the goal
                    goal2.SetGoalInfo(info);
                    goals.Add(goal2);
                    break;

                case "SimpleGoal":
                    SimpleGoal goal3 = new SimpleGoal();
                    goal3.SetGoalInfo(info);
                    goals.Add(goal3);
                    break;
                
            }
        }
        //note: this won't replace any of the previous goals. to do otherwise, clear goals first
        return newPoints; 
    }
    static void Main(string[] args)
    {
        //create variables
        int points = 0;
        List<Goal> goals = new List<Goal>();
        bool keepPlaying = true;
        string inputString; //will be versitile
        int inputInt = 0; //will be versitile
        List<string> inputList = new List<string>(); //will be versitile
        int currentOption;

        do{
            //display the menu and get the user's chosen option
            DisplayMenu(points);
            inputString = Console.ReadLine();
            currentOption = int.Parse(inputString);

            //do whatever that option entails
            switch(currentOption){
                case 1: //create new goal
                    inputList.Clear();
                    
                    CreateGoal(inputInt,inputString,inputList,goals);

                    break;
                    
                case 2: //list goals
                    Console.WriteLine("\nThe goals are: ");
                    for(int i = 0; i < goals.Count; i++) //loop through goals
                    {
                        goals[i].DisplayGoal(i+1);
                    }
                    
                    break;

                case 3: //save goals
                    //get file name
                    Console.Write("What is the filename for the goal file? ");
                    inputString = Console.ReadLine();

                    using (StreamWriter outputFile = new StreamWriter(inputString))
                    {
                        outputFile.WriteLine($"{points}"); //add in the points
                    }
                    for(int i = 0; i < goals.Count; i++) //loop through goals
                    {
                        goals[i].SaveToFile(inputString); //call SaveToFile
                    }
                    break;

                case 4: //load goals
                    Console.Write("What is the filename for the goal file? ");
                    inputString = Console.ReadLine();
                    points += LoadGoals(inputString, goals);
                    break;

                case 5: //record event
                    //prompt the user for the number of the goal they want to record for
                    Console.Write("What goal did you accomplish? ");
                    inputString = Console.ReadLine();
                    inputInt = int.Parse(inputString);
    
                    points += goals[inputInt-1].AccomplishGoal();//for that specific goal, call AccomplishGoal
                    Console.WriteLine($"You now have {points} points. "); //display updated points
                    break;

                default: //quit or invalid entry
                    keepPlaying = false;
                    break;
            }
        }while (keepPlaying);


    }
}