public class Scripture
{
    private string _reference = "Proverbs 3:5-6";
    public List<string> _verse = new List<string>() {"Trust", "in", "the", "Lord","with","all","thine","heart;","and","lean","not","unto","thine","own","understanding.","\nIn","all","thy","ways","acknowledge","him,","and","he","shall","direct","thy","paths."};
    public int GetVerseLength()
    {
        int listLength = _verse.Count;
        return listLength;
    }
    public void DisplayVerse()
    {        
        int listLength = GetVerseLength(); //get verse's length

        Console.WriteLine(_reference);

        //show each word one at a time
        for (int i = 0; i< listLength; i++){
            Console.Write($"{_verse[i]} ");
        }
        Console.WriteLine(" "); //makes it so the next words are on a different line

    }
    private int GetCharacterLength(int index) 
    {
        Console.WriteLine("running GetCharacterLength");
        int characterLength = _verse[index].Length;
        return characterLength;
    }
    public void ReplaceWord(List<int> words) 
    {
        Console.WriteLine("running ReplaceWord");
        
        //do loop through all of that list
        for(int i = 0; i < words.Count; i++){
            int length = GetCharacterLength(words[i]); //get the character length
            //at that index, replace the word with _*number of characters
            string replacement = new String('_',length);
            _verse[words[i]] = replacement;
        }
        
    }

}