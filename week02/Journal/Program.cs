using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal myJournal = new Journal();


        Entry anEntry = new Entry();
        anEntry.Display();


        PromptGenerator prompt = new PromptGenerator();
        prompt.GetRandomPrompt();


    }
}