using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Journal Program!");
        
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        anEntry.DisplayEntry();
    }   


}