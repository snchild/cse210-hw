using System;

class Program
{
    static void Main(string[] args)
    {
        string beginningMessage = "Come try to memorize a scripture.\n";
        string endMessage = "Good job memorizing it.";
        
        Console.WriteLine(beginningMessage);
        
        Scripture s = new Scripture();
        Choose ch = new Choose();

        Memorize memorize = new Memorize();
        memorize.MemorizeScripture(s, ch);

        Console.WriteLine(endMessage);

    }
}