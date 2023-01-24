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
    public void EnactOptions()
    {
        Console.WriteLine("enacting options");
        //use case switch to run the corresponding functions
        switch(_optionNumber)
        {
            case 1:
                //write a new entry
            case 2:
                //display the journal
            case 3:
                //save the journal
            case 4:
                //load the journal
            default:
                break;
            
        }
    }
}