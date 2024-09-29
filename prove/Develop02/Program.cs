using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        anEntry.DisplayEntry();

        Console.WriteLine("Welcome to the Journal Program!");
        string userInput = Console.ReadLine();

        while (userInput != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            if (userInput == "1")
            {
                
            }
            else if (userInput == "2")
            {

            }
            else if (userInput == "3")
            {

            }
            else if (userInput == "4")
            {

            }
            
        }   

    }   


}