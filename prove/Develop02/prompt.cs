using System;
using System.Collections.Generic;

public class promptgenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of my day?",
        "What was something new I learned today?",
        "Who made me smile today?",
        "What was the hardest part of my day?",
        "What am I grateful for today?"
    };
    public string getprompt()
    {
        Random random = new Random();
        int number = random.Next(_prompts.Count);
        return _prompts[number];
    }
}