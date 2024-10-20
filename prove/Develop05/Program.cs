using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Mindfulness Program!");

        string userinput = "";

        while (userinput != "4")
        {
            Console.WriteLine("Please select a number from the following acitivities to partake in:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");
            Console.Write("What would you like to do? ");

            userinput = Console.ReadLine();

            if (userinput == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (userinput == "2")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if (userinput == "3")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (userinput == "4")
            {
                Console.WriteLine("Thank you for using the Mindfulness Program!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Please enter a number from the options provided.");
                Console.WriteLine();
            }
        }

        ActivityLogger.DisplayActivityCounts();

    }
}