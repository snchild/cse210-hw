using System;
//using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        
        //declaring the list and inputedNumber variable
        List<int> numbers = new List<int>();
        int inputedNumber = 1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do{
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            inputedNumber = int.Parse(userInput);
            
            //this prevents appending the inputed 0
            if (inputedNumber != 0){
                numbers.Add(inputedNumber);
            }
        }while(inputedNumber != 0);
        
        //print sum, avg, max
        double sumOfNumbers = numbers.Sum();
        Console.WriteLine($"The sum is: {sumOfNumbers}");
        double meanOfNumbers = numbers.Average();
        Console.WriteLine($"The average is: {meanOfNumbers}");
        double maxOfNumbers = numbers.Max();
        Console.WriteLine($"The largest number is: {maxOfNumbers}");

    }
}