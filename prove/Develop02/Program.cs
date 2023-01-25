using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu(); 
        Journal journal = new Journal(); //create journal
        do{
            menu.DisplayOptions();
            menu.EnactOptions(journal);
            
        } while (menu._optionNumber != 0);
        
        Console.WriteLine("Thanks for writing in your journal.");
        //to exceed expectations, I am also prompting the user to enter the amount of time 
        //they spent on their phone that day.
    }
}