using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percetnage? ");
        string gradeAnswer = Console.ReadLine();
        int grade = int.Parse(gradeAnswer);
        
        string letter;

        if(grade >= 90)
        {
            letter = "A";
        }
        else if(grade >= 80)
        {
            letter = "B";
        }
        else if(grade >= 70)
        {
            letter = "C";
        }
        else if(grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}.");

        if(grade >= 70)
        {
            Console.WriteLine("Congradulations on passing!");
        }
        else{
            Console.WriteLine("Try better next time.");
        }
    }
}