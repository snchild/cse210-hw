using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu(); 
        Journal journal = new Journal(); //create journal
        do{
            menu.DisplayOptions();
            menu.EnactOptions();
            
        } while (menu._optionNumber != 0);
        
        Console.WriteLine("Thanks for writing in your journal.");

    }
}