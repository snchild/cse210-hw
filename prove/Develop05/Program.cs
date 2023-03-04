using System;

class Program
{
    static void DisplayMenu(int points)
    {
        Console.WriteLine($"You have {points} points.\n");
        Console.WriteLine("Menu options: ");
        Console.WriteLine("\t1. Create New Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record Event");
        Console.WriteLine("\t6. Quit");
        Console.Write("Select a choice from the menu: ");
    }
    static void Main(string[] args)
    {
        //create variables
        int points = 0;
        List<Goal> goals = new List<Goal>();
        bool keepPlaying = true;
        string userInput; //will be versitile
        int currentOption;

        do{
            //display the menu and get the user's chosen option
            DisplayMenu(points);
            userInput = Console.ReadLine();
            currentOption = int.Parse(userInput);

            //do whatever that option entails
            switch(currentOption){
                case 1: //create new goal
                    //prompt the user for the type of goal
                    //create a goal of that type
                    //add that goal to goals
                    //call createGoal method for most recent goal item
                    break;
                case 2: //list goals
                    //loop through goals
                        //call GetGoalInfo
                        //display that goal info
                    break;
                case 3: //save goals
                    //open file
                    //loop through goals
                        //call SaveToFile
                    //close file
                    break;
                case 4: //load goals
                    //note: most of this should be in a function cause it's a long progess
                    //read the file, line by line
                    //loop through the lines
                        //split the lines up into parts, separated by a ;
                        //use a switch case to create the correct type of goal
                            //set the correct attributes to the right values
                        //add that goal to goals
                        //note: this won't replace any of the previous goals. to do otherwise, clear goals first
                    break;
                case 5: //record event
                    //prompt the user for the number of the goal they want to record for
                    //for that specific goal, call AccomplishGoal
                    //display the number of points they have now
                    break;
                default: //quit or invalid entry
                    keepPlaying = false;
                    break;
            }
        }while (keepPlaying);


    }
}