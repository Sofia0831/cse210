using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorization Tool!");

        //user can add their own scripture to memorize
        Reference theReference = new(book:"", chapter:0, verse:0); 
        Console.WriteLine("To start, enter the scripture reference (Book, Chapter, Verse(s)): ");
        string[] inRef = Console.ReadLine().Split(",");
        
            if (inRef.Length < 2)
            {
                Console.WriteLine("Invalid format. Please enter a reference in the format 'Book, Chapter, Verse(s)'.");
                Environment.Exit(0);
            }

            string book = inRef[0];
            int chapter = int.Parse(inRef[1]);

            if (inRef.Length == 3)
            {
                int verse = int.Parse(inRef[2]);
                theReference = new Reference(book, chapter, verse);
            }
            else if (inRef.Length == 4)
            {
                int startVerse = int.Parse(inRef[2]);
                int endVerse = int.Parse(inRef[3]);
                theReference = new Reference(book, chapter, startVerse, endVerse);
            }
            else
            {
                Console.WriteLine("Invalid format. Please enter a reference with either a single verse or a range (Book, Chapter, Verse or Book, Chapter, StartVerse, EndVerse).");
                Environment.Exit(0);
            }

        Console.WriteLine("\nNext enter the scripture text: ");
        string text = Console.ReadLine();

        Scripture scripture = new Scripture(theReference, text);
        Console.Clear();
        Console.WriteLine($"{theReference.GetDisplayText()}: {scripture.GetDisplayText()}");
        Console.WriteLine("\nPress Enter key to continue or type 'quit' to exit."); 

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            if (!scripture.IsCompletelyHidden())
            {
                scripture.HideRandomWords(3);
                Console.Clear();
                Console.WriteLine($"{theReference.GetDisplayText()}: {scripture.GetDisplayText()}");
            }
            else
            {
                Console.WriteLine("\nGreat work! You memorized that like a pro!");
                break;
            }

            Console.WriteLine("\nPress Enter key to continue or type 'quit' to exit.");
        }
    }

}