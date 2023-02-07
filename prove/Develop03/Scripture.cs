public class Scripture
{
    private string _reference = "Book ch:vs";
    private List<string> _verse;
    private List<string> _newVerse;
    public int GetVerseLength()
    {
        Console.WriteLine("running GetVerseLength");
        return 1;
    }
    public void DisplayVerse()
    {
        Console.WriteLine("running DisplayVerse");
    }
    public int GetCharacterLength()
    {
        Console.WriteLine("running GetCharacterLength");
        return 1;
    }
    public void ReplaceWord()
    {
        Console.WriteLine("running ReplaceWord");
    }

}