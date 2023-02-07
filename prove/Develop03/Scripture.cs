public class Scripture
{
    private string _reference = "John 3:16";
    public List<string> _verse = new List<string>() {"That","whosoever","believeth","in","him","should","not","perish","but","have","eternal","life."};
    public int GetVerseLength()
    {
        int listLength = _verse.Count;
        return listLength;
    }
    public void DisplayVerse()
    {
        Console.WriteLine("running DisplayVerse");
        
        int listLength = GetVerseLength(); //get verse's length

        Console.WriteLine(_reference);

        //show each word one at a time
        for (int i = 0; i< listLength; i++){
            Console.Write($"{_verse[i]} ");
        }
        Console.WriteLine(" "); //makes it so the next words are on a different line

    }
    public int GetCharacterLength()
    {
        Console.WriteLine("running GetCharacterLength");
        return 1;
    }
    public void ReplaceWord()
    {
        Console.WriteLine("running ReplaceWord");
        //get the list of random words to replace
        //do loop through all of that list
        //get the character length
        //at that index, replace the word with _*number of characters
    }

}