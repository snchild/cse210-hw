using System;

class Program
{
    static void Main(string[] args)
    {
        string beginningMessage = "";
        string endMessage = "";
        
        Console.WriteLine(beginningMessage);
        
        Scripture s = new Scripture();

        Choose ch = new Choose();

        Memorize memorize = new Memorize();
        memorize.MemorizeScripture(s, ch);

        Console.WriteLine(endMessage);
    }
}