using System;

public class Job
{
    public string _jobtitle;
    public string _company;
    public int _start;
    public int _end;
    public void Display()
    {
        Console.WriteLine($"{_jobtitle} ({_company}) {_start}-{_end}");
    }
}