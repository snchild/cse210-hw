public class Menu
{
    public int _optionNumber;
    public void DisplayOptions()
    {
        Console.WriteLine("\nJournal options:");
        //display the options
        Console.WriteLine("1    Write a new entry");
        Console.WriteLine("2    Display the journal");
        Console.WriteLine("3    Save the journal");
        Console.WriteLine("4    Load the journal");
        Console.WriteLine("0    Quit");

        //prompt for the chosen option
        Console.Write("\nPlease enter the number correlating to which option you would like: ");
        string inputedOption = Console.ReadLine();
        _optionNumber = int.Parse(inputedOption);
    }
    public void EnactOptions(Journal journal)
    {
        //use case switch to run the corresponding functions
        switch(_optionNumber)
        {
            case 1:
                //write a new entry
                journal.GetNewEntry();
                break;
            case 2: 
                //display the journal
                journal.DisplayJournal();
                break;
            case 3:
                //save the journal
                journal.SaveJournal();
                break;
            case 4:
                //load the journal
                journal.LoadJournal();
                break;
            default:
                //would be if they entered a 0, stop the loop
                break;
            
        }
    }
}