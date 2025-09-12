using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        PromptGenerator prompt = new PromptGenerator();
        Journal journal = new Journal();

        int userOption = 0;
        while (userOption != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");

            string response = Console.ReadLine();
            userOption = int.Parse(response);

            if (userOption <= 0)
            {
                Console.WriteLine("Please enter a valid option.");
            }
            else if (userOption >= 6)
            {
                Console.WriteLine("Please enter a valid option.");
            }
            else if (userOption == 1)
            {
                Entry newEntry = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                newEntry._date = dateText;
                newEntry._promptText = prompt.GetRandomPrompt();
                Console.WriteLine(newEntry._promptText);
                Console.Write("> ");
                newEntry._entryText = Console.ReadLine();

                journal.AddEntry(newEntry);
            }
            else if (userOption == 2)
            {
                journal.DisplayAll();
            }
            else if (userOption == 3)
            {
                Console.WriteLine("What is the filename?");
                Console.Write("> ");
                journal.LoadFromFile(Console.ReadLine());
            }
            else if (userOption == 4)
            {
                Console.WriteLine("What is the filename?");
                Console.Write("> ");
                journal.SaveToFile(Console.ReadLine());
            }
        }
    }
}