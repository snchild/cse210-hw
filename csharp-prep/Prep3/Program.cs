using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 101); 
        
        bool isCorrect = false;
        
        do{
            //asking for a guess
            Console.WriteLine("What is your guess? ");
            string guess = Console.ReadLine();
            int guessNumber = int.Parse(guess);

            //checking the guess
            if (guessNumber == randomNumber)
            {
                Console.WriteLine("You got it!");
                isCorrect = true;
            }
            else if(guessNumber > randomNumber)
            {
                Console.WriteLine("Lower");
            }
            else{
                Console.WriteLine("Higher");
            }
        }while(isCorrect == false);

    }
}