using System;

class Program
{
    static void Main()
    {
        Reference reference = new Reference("Moroni", 10, 4, 5);
        Scripture scripture = new Scripture(reference, "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.");

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("");
            Console.WriteLine("Please enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }
            scripture.HideRandomWords(3);
        }
        Console.Clear();
        Console.WriteLine(reference.GetDisplayText());
        Console.WriteLine(scripture.GetDisplayText());
    }
}