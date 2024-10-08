using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("");
        Console.WriteLine("Welcome to the Journal Program!");
        string userInput = "";

        while (userInput != "6")
        {
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Delete");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");

            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Excellent! Your prompt is: {prompt}");
                Console.Write("> ");
                string response = Console.ReadLine();
                journal.AddEntry(new Entry(DateTime.Now.ToString(), prompt, response));
            }
            else if (userInput == "2")
            {
                journal.DisplayAll();
            }
            else if (userInput == "3")
            {
                Console.Write("Enter the filename: ");
                string loadFilename = Console.ReadLine();
                journal.LoadFromFile(loadFilename);
            }
            else if (userInput == "4")
            {
                Console.Write("Enter the filename: ");
                string saveFilename = Console.ReadLine();
                journal.SaveToFile(saveFilename);
            }
            else if (userInput == "5") //Added an option to delete a journal entry or file
            {
                Console.Write("Enter the filename: ");
                string filenameToDelete = Console.ReadLine();
                journal.DeleteFile(filenameToDelete);
            }
            else if (userInput == "6")
            {
                Console.WriteLine("Thank you for using the Journal Program!");
                Console.WriteLine("");
            }
            else 
            {
                Console.WriteLine("Please enter a number from the options provided.");
            }
            
        }   

    }   


}