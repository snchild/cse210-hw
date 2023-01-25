using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _currentFileName = "";
    public void GetFileName()
    {
        Console.WriteLine("What is the full name of the file?");
        _currentFileName = Console.ReadLine();
    }
    public void LoadJournal() 
    {        
        _entries.Clear(); //clear current journal
        Entry _currentEntry = new Entry();
        
        GetFileName();
        
        //load the journal
        string[] lines = System.IO.File.ReadAllLines(_currentFileName);
        

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");

            string identifier = parts[0];
            string information = parts[1];  

            //use switch case to add the info to the correct attributes
            switch(identifier)
            {
                case "1": //date
                    _currentEntry._date = information;
                    break;
                case "2": //prompt
                    _currentEntry._prompt = information;
                    break;
                case "3": //response
                    _currentEntry._response = information;
                    break;
                case "4": //phone time
                    _currentEntry._phoneTime = information;
                    _entries.Add(_currentEntry);
                    break;
            }          
        }
        
    }
    public void SaveJournal()
    {
        GetFileName();
        
        //save journal
        using (StreamWriter outputFile = new StreamWriter(_currentFileName))
        {
            //loop through the entries
            for (int j = 0; j < _entries.Count ;j++)
            {
                //write each entry using outputFile.
                outputFile.WriteLine($"1:{_entries[j]._date}"); //1 is date
                outputFile.WriteLine($"2:{_entries[j]._prompt}"); //2 is prompt
                outputFile.WriteLine($"3:{_entries[j]._response}"); //3 is response
                outputFile.WriteLine($"4:{_entries[j]._phoneTime}"); //4 is phone time
            }
        }
        Console.WriteLine("Journal has been saved.");
    }
    public void GetNewEntry()
    {
        //create new entry to add to list
        Entry _currentEntry = new Entry();  

        //call displayprompt, chooseprompt, and getresponse
        _currentEntry.DisplayPrompt();
        _currentEntry.GetResponse();
        _currentEntry.GetPhoneTime();
        
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
            Console.WriteLine($"Amount of time on phone today: {_entries[j]._phoneTime}");
        }
    }
}