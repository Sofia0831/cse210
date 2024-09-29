public class Journal {
    public List<Entry> Entries {get; private set;} = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        if (string.IsNullOrEmpty(newEntry.EntryText))
        {
            Console.WriteLine("Sorry, entry cannot be empty.");
            return;
        }

        newEntry.EntryNum = Entries.Count + 1;
        Entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (Entries.Count == 0)
        {
            Console.WriteLine("Sorry, there is currently nothing to display");
        }
        else
        {
            foreach (var entry in Entries) 
            {
                entry.DisplayEntry();
            }
        }
    
    }

    public void SaveToFile(string file)
    {  
        if (Entries.Count == 0)
        {
            Console.WriteLine("Sorry, there is currently nothing to save");
        }
        else 
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

    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("Sorry, file not found.");
            return;
        }

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

    public void DeleteFile(string filename) 
    {
        if (File.Exists(filename))
        {
            File.Delete(filename);
            Console.WriteLine("File deleted successfully.");
        }
        else
        {
            Console.WriteLine("Sorry, file not found.");
        }
    }
}