using System;
using System.Collections.Generic;
using System.IO;

public class journal
{
    public List<entry> _entries = new List<entry>();
    public void displayall()
    {
        foreach (entry item in _entries)
        {
            item.display();
        }
    }
    public void savefile(string filename)
    {
        using (StreamWriter file = new StreamWriter(filename))
        {
            foreach (entry item in _entries)
            {
                file.WriteLine($"{item._date}~|~{item._prompt}~|~{item._response}");
            }
        }
    }
    public void loadfile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        _entries.Clear();
        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            entry newentry = new entry();
            newentry._date = parts[0];
            newentry._prompt = parts[1];
            newentry._response = parts[2];
            _entries.Add(newentry);
        }
    }
}