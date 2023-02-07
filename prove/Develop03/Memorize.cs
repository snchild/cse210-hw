public class Memorize
{
    private bool _continue = true;
    private string _userInput;
    
    public void MemorizeScripture(Scripture s)
    {
        Console.WriteLine("running MemorizeScripture");
        do{
            //display the scripture
            s.DisplayVerse();

            //prompt user for input
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            _userInput = Console.ReadLine();
            
            if(_userInput == "quit" || _userInput == "quit")
            {
                //pick random number
                //choose random words
                //erase the words

            }
            else{
                _continue = false;
            }
            
        }while(_continue == true);
    }
    public void ClearConsole()
    {
        Console.WriteLine("running ClearConsole");
    }
}