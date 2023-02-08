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
        int listLength = GetVerseLength(); //get verse's length

        Console.WriteLine(_reference);

        //show each word one at a time
        for (int i = 0; i< listLength; i++){
            Console.Write($"{_verse[i]} ");
        }
        Console.WriteLine(" "); //makes it so the next words are on a different line

    }
    public int GetCharacterLength(int index) //wip
    {
        Console.WriteLine("running GetCharacterLength");
        int characterLength = _verse[index].Length;
        return characterLength;
    }
    public void ReplaceWord(List<int> words) //wip
    {
        Console.WriteLine("running ReplaceWord");
        
        //do loop through all of that list
        for(int i = 0; i < words.Count; i++){
            int length = GetCharacterLength(words[i]); //get the character length
            //at that index, replace the word with _*numb of characters
            string replacement = new String('_',length);
            _verse[words[i]] = replacement;
        }
        
    }

}