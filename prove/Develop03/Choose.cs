public class Choose
{
    Random _rand = new Random();
    private int _numberOfWords;
    public List<int> _currentIndices = new List<int>();
    private List<int> _chosenIndices = new List<int>();
    public void InitializeCurrentIndices(int length) //starts _currentIndices out with having all the indices
    {
        _currentIndices.InsertRange(0, Enumerable.Range(0,length));
    }
    public List<int> ChooseWords() //returns a list of indices that the chosen words are at
    {       
        _chosenIndices.Clear(); //empty _chosenIndices

        if (_currentIndices.Count > 3)
        {
            _numberOfWords = _rand.Next(1,3); //pick a random number between 1 and 3
        }
        else if (_currentIndices.Count > 0)
        {
            //pick a random number between 1 and the number of words
            _numberOfWords = _rand.Next(1,_currentIndices.Count); 
        }
        else{
            _numberOfWords = 0; //this prevents the for loop below from running
        }

        //loop for number of words to be erased
        for (int i = 0; i < _numberOfWords; i++)
        {
            
            //pick a random index from _currentIndices
            int j = _rand.Next(_currentIndices.Count); 
            int chosenIndex = _currentIndices[j]; 

            _currentIndices.RemoveAt(j); //update _currentIndices
            _chosenIndices.Add(chosenIndex); //add that chosen value to _chosenIndices
        }
        return _chosenIndices;
    }

}