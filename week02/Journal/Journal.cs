using System.Collections.Generic;
using System.Formats.Asn1;
using System.IO;
public class Journal
{
     private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    
        public int GetEntryCount()
    {
        return _entries.Count;
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
           foreach (var entry in _entries)
            {
                outputfile.WriteLine($"{entry._date} - {entry._promptText}");
                outputfile.WriteLine(entry._entryText);
                outputfile.WriteLine();
            }
        }
    }

    public void LoadFromFile(string file)
    {
  
        string[] lines = System.IO.File.ReadAllLines(file);
        Entry entry = null;
        string entryText = "";
        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];
            if (!string.IsNullOrEmpty(line))
            {
                if (line.Contains(" - "))
                {
                    if (entry != null)
                    {
                        entry._entryText = entryText.Trim();
                        _entries.Add(entry);
                    }
                    entry = new Entry();
                    string[] parts = line.Split(new string[] { " - " }, StringSplitOptions.None);
                    if (parts.Length >= 2)
                    {
                        entry._date = parts[0];
                        entry._promptText = parts[1];
                    }
                    else
                    {
                        // Handle the case where the line doesn't contain " - " in the expected format
                        Console.WriteLine("Skipping invalid line: " + line);
                        entry = null;
                    }
                    entryText = "";
                }
                else
                {
                    if (entry != null)
                    {
                        entryText += line + Environment.NewLine;
                    }
                }
            }
        }
    if (entry != null)
    {
        entry._entryText = entryText.Trim();
        _entries.Add(entry);
    }
    }
}