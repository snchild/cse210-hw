public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _currentEntry = "";
    public string _currentFileName = "";
    public void GetFileName()
    {
        Console.WriteLine("What is the name of the file?");
        _currentFileName = Console.ReadLine();
    }
    public void LoadJournal()
    {
        Console.WriteLine("Running LoadJournal");
        GetFileName();
        //load the journal
    }
    public void SaveJournal()
    {
        Console.WriteLine("running SaveJournal");
        GetFileName();
        //save journal
    }
    public void GetNewEntry()
    {
        Console.WriteLine("running get new entry");
        //call displayprompt, chooseprompt, and getresponse
        //put all together as currentEntry
        //add to entries
    }
    public void DisplayJournal()
    {
        Console.WriteLine("running display journal");
        //display the journal
    }
}