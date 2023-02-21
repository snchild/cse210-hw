using System;

class Program
{
    static void DisplayMenu() 
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start five things activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Start reflection activity");
        Console.WriteLine("5. Quit");
    }
    
    static void Main(string[] args)
    {
        //initialize all 4 activities
        BreathingActivity breathe = new BreathingActivity("Breathing",3);
        FiveThingsActivity fiveThings = new FiveThingsActivity("Five Things");
        ListingActivity listing = new ListingActivity("Listing");
        ReflectionActivity reflection = new ReflectionActivity("Reflection", 4);

        //initialize variables
        bool willContinue = true;

        do{
            Console.Clear();
            DisplayMenu(); //display menu

            //prompt for user input
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            int chosenOption = int.Parse(userInput); 

            //use switch case to run corresponding methods
            switch(chosenOption)
            {
                case 1: //breathing activity
                    breathe.DisplayBeginning();
                    breathe.PromptDuration();
                    breathe.DisplayBreathing();
                    breathe.DisplayEnding();
                    break;

                case 2: //five things activity
                    fiveThings.DisplayBeginning();
                    fiveThings.PromptDuration();
                    fiveThings.PromptResponses();
                    fiveThings.DisplayEnding();
                    break;

                case 3: //listing activity
                    listing.DisplayBeginning();
                    listing.PromptDuration();
                    listing.DisplayPrompt();
                    listing.PromptItems();
                    listing.DisplayLengths();
                    listing.DisplayEnding();
                    break;

                case 4: //reflection activity
                    reflection.DisplayBeginning();
                    reflection.PromptDuration();
                    reflection.DisplayPrompt();
                    reflection.DisplayQuestion();
                    reflection.DisplayEnding();
                    break;

                case 5: //quit
                    willContinue = false;
                    break;
            }
        } while(willContinue);
    }
    

}