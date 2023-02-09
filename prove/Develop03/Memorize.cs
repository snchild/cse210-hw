public class Memorize
{
    private bool _continue = true;
    private string _userInput;
    
    public void MemorizeScripture(Scripture s, Choose ch) 
    {
        ch.InitializeCurrentIndices( s.GetVerseLength() );

        do{
            //display the scripture
            s.DisplayVerse();

            //prompt user for input
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish");
            _userInput = Console.ReadLine();
            
            if(_userInput != "quit" && ch._currentIndices.Count > 0)
            {
                List<int> chosenIndices = new List<int>(); 
                chosenIndices = ch.ChooseWords(); //choose random words to erase
                
                s.ReplaceWord(chosenIndices); //erase the words
                
                Console.Clear(); //clear console
            }
            else{
                _continue = false;
            }
            
        }while(_continue == true);
    }
    
}