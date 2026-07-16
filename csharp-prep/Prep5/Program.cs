using System;

class Program
{
    static void Main(string[] args)
    {
        welcome();
        string username = usernameInput();
        int favnumber = favnumberInput();
        int squarenumber = squarenumberInput(favnumber);
        int birthyear;
        userYOBInput(out birthyear);
        resultsOutput(username, squarenumber, birthyear);
    }

    static void welcome()
    { Console.WriteLine("Welcome to the program."); }

    static string usernameInput()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int favnumberInput()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static void userYOBInput(out int birthyear)
    {
        Console.Write("Please enter the year you were born: ");
        birthyear = int.Parse(Console.ReadLine());
    }
    static int squarenumberInput(int number)
    {
        int square = number * number;
        return square;
    }
    static void resultsOutput(string name, int square, int birthyear)
    {
        Console.WriteLine($"{name}, your favorite number squared is {square}.");
        Console.WriteLine($"{name}, you will turn {2026 - birthyear} years old this year.");
    }
}