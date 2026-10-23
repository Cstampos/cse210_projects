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
            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Please enter a valid number.\n");
                continue;
            }
            Console.WriteLine();
            switch (option)
            {
                case 1:
                    entry newentry = new entry();
                    newentry._date = DateTime.Now.ToShortDateString();
                    newentry._prompt = promptgen.getprompt();
                    Console.WriteLine(newentry._prompt);
                    Console.Write("> ");
                    newentry._response = Console.ReadLine();
                    diary._entries.Add(newentry);
                    break;
                case 2:
                    diary.displayall();
                    break;
                case 3:
                    Console.Write("Enter Filename: ");
                    diary.loadfile(Console.ReadLine());
                    break;
                case 4:
                    Console.Write("Enter Filename: ");
                    diary.savefile(Console.ReadLine());
                    break;
                case 5:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Not an option.");
                    break;
            }
        }
    }
}