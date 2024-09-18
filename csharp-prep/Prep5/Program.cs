using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int faveNumber = PromptFaveNumber();
        int squareNumber = SquareNumber(faveNumber);
        
        DisplayResult(userName, squareNumber);
        
    }
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;

    }

    static int PromptFaveNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int faveNumber = int.Parse(input);

        return faveNumber;

    }

    static int SquareNumber(int faveNumber)
    {
        int square = faveNumber*faveNumber;
        return square;
    }

    static void DisplayResult(string userName, int squareNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
    }
}