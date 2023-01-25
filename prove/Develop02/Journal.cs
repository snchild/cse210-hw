public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    //public string _currentEntry = ""; //might not actually need
    public string _currentFileName = "";
    public void GetFileName()
    {
        Console.WriteLine("What is the full name of the file?");
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
        //create new entry to add to list
        Entry _currentEntry = new Entry();  //does this need to be public? i hope not

        //call displayprompt, chooseprompt, and getresponse
        _currentEntry.DisplayPrompt();
        _currentEntry.GetResponse();
        _currentEntry.GetDate();
        
        //add to entries
        _entries.Add(_currentEntry);
    }
    public void DisplayJournal()
    {        
        //loop through the entries
        for (int j = 0; j < _entries.Count ;j++)
        {
            //display each entry
            Console.WriteLine($"\nDate: {_entries[j]._date}");
            Console.WriteLine($"Prompt: {_entries[j]._prompt}");
            Console.WriteLine($"Response: {_entries[j]._response}");
        }
    }
}