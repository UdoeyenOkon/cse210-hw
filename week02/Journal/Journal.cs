using System.Collections.Generic;
using System.IO;
public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
        
        
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputfile = new StreamWriter (file))
        {
        outputfile.WriteLine(file);
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
    }

}