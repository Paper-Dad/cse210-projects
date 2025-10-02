using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:");

        int userOption = 0;
        while (userOption != 4)
        {
            Console.Clear();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");

            string response = Console.ReadLine();
            userOption = int.Parse(response);

            if (userOption <= 0)
            {
                Console.WriteLine("Please enter a valid option.");
            }
            else if (userOption >= 5)
            {
                Console.WriteLine("Please enter a valid option.");
            }
            else if (userOption == 1)
            {
                Console.Clear();
                BreathingActivity breathe1 = new BreathingActivity("Breathing Activity", "This Activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathe1.Run();
            }
            else if (userOption == 2)
            {
                Console.Clear();
                ReflectingActivity reflect1 = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflect1.Run();
            }
            else if (userOption == 3)
            {
                Console.Clear();
                ListingActivity list1 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                list1.Run();
            }
            else if (userOption == 4)
            {
            }
        }
    }
}