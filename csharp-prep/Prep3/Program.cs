using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
            //string input = Console.ReadLine();
            //int mNumber = int.Parse(input);

        int countguesses = 0;

        Random randomGenerator = new Random();
        int mNumber = randomGenerator.Next(1, 100);
        string answer = "";
        while (answer != "You guessed it!")
        {
            countguesses = countguesses + 1;

            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
            int guess = int.Parse(guessInput);
    
    
            if (guess > mNumber)
            {
                answer = "Lower";
            }
            else if (guess < mNumber)
            {
                answer = "Higher";
            }
            else if (guess == mNumber)
            {
                answer = "You guessed it!";
            }

            Console.WriteLine($"{answer}");

        }

        Console.Write($"Congrats! It took you {countguesses} guess(es)!");
    }   
}