public class Memorize
{
    private bool _continue = true;
    private string _userInput;
    
    public void MemorizeScripture(Scripture s, Choose ch) //wip
    {
        ch.InitializeCurrentIndices( s.GetVerseLength() );

        Console.WriteLine("running MemorizeScripture");
        do{
            //display the scripture
            s.DisplayVerse();

            //prompt user for input
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            _userInput = Console.ReadLine();
            
            if(_userInput != "quit")
            {
                List<int> chosenIndices = new List<int>(); 
                chosenIndices = ch.ChooseWords(); //choose random words to erase
                
                s.ReplaceWord(chosenIndices); //erase the words
                
                ClearConsole(); //clear console
            }
            else{
                _continue = false;
            }
            
        }while(_continue == true);
    }
    public void ClearConsole() //wip
    {
        Console.WriteLine("running ClearConsole");
        //clear console
    }
}