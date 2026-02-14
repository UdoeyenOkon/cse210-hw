using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "+++Who are people that you appreciate?",
        "+++What are personal strengths of yours?",
        "+++Who are people that you have helped this week?",
        "+++When have you felt the Holy Ghost this month?",
        "+++Who are some of your personal heroes?"
    };

    private Random _random = new Random();

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(0,_prompts.Count);
        return _prompts[index];
    }

    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine(GetRandomPrompt());

        Console.WriteLine("You may begin in: ");
        ShowCountDown();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} responses.");
    }
}