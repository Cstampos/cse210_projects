using System;

public class entry
{
    public string _date;
    public string _prompt;
    public string _response;
    public void display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_response);
        Console.WriteLine();
    }
}