public class Entry {
    public string _date;
    public string _entryNum;
    public string _journalPrompt;
    public string _entryText;

    public void DisplayEntry()
    {
        // Console.WriteLine($"{_date} - Prompt: {_journalPrompt} - Entry: {_entryText}");
        Console.WriteLine($"{_date} - Entry {_entryNum}");
        Console.WriteLine($"Prompy: {_journalPrompt}");
        Console.WriteLine($"{_entryText}");
    }

}