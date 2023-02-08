public class Choose
{
    Random _rand = new Random();
    private int _numberOfWords;
    private List<int> _currentIndices = new List<int>();
    private List<int> _chosenIndices = new List<int>();
    public void InitializeCurrentIndices(int length)
    {
        _currentIndices.InsertRange(0, Enumerable.Range(0,length));
    }
    public List<int> ChooseWords()
    {       
        _chosenIndices.Clear(); //empty _chosenIndices

        _numberOfWords = _rand.Next(1,3); //pick a random number between 1 and 3

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