using System;

class Program
{
    static void Main(string[] args)
    {
        journal diary = new journal();
        promptgenerator promptgen = new promptgenerator();
        int option = 0;
        while (option != 5)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?: ");

            if (int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Please enter a valide number.\n");
                continue;
            }
            Console.WriteLine();
            switch (option)
            {
                case 1:
                    writeentry(journal, promptgen);
                    break;
                case 2:
                    journal.displayall();
                    break;
                case 3:
                    Console.Write("Enter Filename: ");
                    journal.loadfile(Console.ReadLine());
                    break;
                case 4:
                    Console.Write("Enter Filename: ");
                case 5:
                    Console.WriteLine("Goodbye!");
                default:
                    Console.WriteLine("Not an option.");
                    break;
            }

            static void entry()
            { }
            static void journal()
            { }
            static void promptgenerator()
            { }
        }
    }
}