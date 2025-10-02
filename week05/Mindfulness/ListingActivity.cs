using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _responses = new List<string>();


    public ListingActivity(string name, string description) : base(name, description)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }
    public void Run()
    {
        int duration = DisplayStartingMessage();
        Console.Clear();
        Console.Write("Get Ready");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        Console.WriteLine("");
        ShowCountDown(5);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            GetListFromUser();
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {_responses.Count} items!");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count);
        Console.WriteLine($"--{_prompts[index]}--");
    }

    public void GetListFromUser()
    {
        Console.Write(">");
        string response = Console.ReadLine();
        _responses.Add(response);
    }
}