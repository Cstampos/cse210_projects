using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomgen = new Random();
        int randomnumber = randomgen.Next(1, 11);
        int guess = -1;

        while (guess != randomnumber)
        {
            Console.Write("What number do you think it is?: ");
            guess = int.Parse(Console.ReadLine());
            if (randomnumber > guess)
            { Console.WriteLine("Guess Higher"); }
            else if (randomnumber < guess)
            { Console.WriteLine("Guess Lower"); }
            else
            { Console.WriteLine("You guessed it! Good job!"); }
        }
    }
}