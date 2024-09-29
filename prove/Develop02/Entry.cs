public class Entry {
    public string Date {get; set;}
    public int EntryNum {get; set;}
    public string PromptText {get; set;}
    public string EntryText {get; set;}

    public Entry(string date, string promptText, string entryText)
    {
        Date = date;
        PromptText = promptText;
        EntryText = entryText;
    }
    public void DisplayEntry()
    {
        Console.WriteLine("");
        Console.WriteLine($"Entry #{EntryNum} - {Date}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"'{EntryText}'");
    }

}


