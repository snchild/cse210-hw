using System;

class Program
{
    static void Main(string[] args)
    {
        string beginningMessage = "";
        string endMessage = "";
        
        Console.WriteLine(beginningMessage);
        
        Scripture s = new Scripture();

        Memorize memorize = new Memorize();
        memorize.MemorizeScripture(s);

        Console.WriteLine(endMessage);
    }
}