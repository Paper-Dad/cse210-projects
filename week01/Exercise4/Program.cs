using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter a number: ");
        string attempt = Console.ReadLine();
        int number = int.Parse(attempt);
        while (number != 0)
        {
            numbers.Add(number);
            Console.Write("Enter a number: ");
            attempt = Console.ReadLine();
            number = int.Parse(attempt);
        }
        foreach (int i in numbers)
        {
            sum = i + sum;
        }
        float average = ((float)sum) / numbers.Count;
        int largest = 0;
        foreach (int j in numbers)
        {
            if (j > largest)
            {
                largest = j;
            }
        }

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}