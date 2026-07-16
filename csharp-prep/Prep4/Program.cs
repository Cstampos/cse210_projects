using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int numberlist = -1;

        while (numberlist != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished. ");
            string userinput = Console.ReadLine();
            numberlist = int.Parse(userinput);
            if (numberlist != 0)
            { numbers.Add(numberlist); }
        }

        int sum = 0;
        foreach (int number in numbers)
        { sum += number; }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int maxnum = numbers[0];
        foreach (int number in numbers)
        {
            if (number > maxnum)
            { maxnum = number; }
        }

        Console.WriteLine($"The max is: {maxnum}");
    }
}