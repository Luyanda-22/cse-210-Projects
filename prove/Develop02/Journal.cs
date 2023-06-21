public class Journal
{
    List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();

    }

    public void AddEntry (Entry newEntry)
    {
        entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveFile(string _file)
    {
        List<string> records = new List<string>();
        foreach (Entry entry in entries)
        {
            string entryAsCSV = $"{entry.date} | {entry.question} | {entry.userEntry}";
            records.Add(entryAsCSV);
        }

        File.WriteAllLines(_file, records);
    }


    public void LoadFile(string file)
    {
        List<string> records = File.ReadAllLines(file).ToList();
        foreach (string record in records)
        {
            string[]splitString = record.Split('|'); 
            Entry entry = new Entry(splitString[0], splitString[1], splitString[2]);

            entries.Add(entry);
        }
    }

    public void CloseJournal()
    {
        
    }
}
