public class Journal {
    public List<Entry> Entries {get; private set;} = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        newEntry.EntryNum = Entries.Count + 1;
        Entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in Entries) {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string file)
    {  
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in Entries)
            {
                writer.WriteLine($"{entry.EntryNum}|{entry.Date.ToString()}|{entry.PromptText}|{entry.EntryText}");
            }
        }

        Console.WriteLine("Journal saved successfully! Thank you for your time, I hope you were able to write substantially.");
    }

    public void LoadFromFile(string file)
    {
        Entries.Clear();

        using (StreamReader reader = new StreamReader(file))
        {
            string line;
            while((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');

                int entryNum = int.Parse(parts[0]);
                DateTime date = DateTime.Parse(parts[1]);
                string promptText = parts[2];
                string entryText = parts[3];

                Entries.Add(new Entry(date.ToString(), promptText, entryText){EntryNum = entryNum});
            }
        }

        Console.WriteLine("Journal loaded successfully!");
    }
}