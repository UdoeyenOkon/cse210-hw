using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata;
// To exceed the requirement, I have included a code to keep count of the entry in each journal file.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal myJournal = new Journal();

        while (true)
        {
            Console.WriteLine("Please select one of the following choices, by typing the corresponding item number.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            
            Console.Write("What would you like to do? ");
            string userResponse = Console.ReadLine();
            int choice = int.Parse(userResponse);

            string randomPrompt = "";

            if (choice == 1)
            {
                List<string> prompts = new List<string>
             {
                 "Who was the most interesting person I interacted with today?",
                 "What was the best part of my day?",
                 "How did I see the hand of the Lord in my life today?",
                 "What was the strongest emotion I felt today?",
                 "If I had one thing I could do over today, what would it be?"
             };

                PromptGenerator generator = new PromptGenerator(prompts);
                randomPrompt = generator.GetRandomPrompt();
                Console.WriteLine($"{randomPrompt} ");
                string promptResponse = Console.ReadLine();

                Entry newEntry = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                newEntry. _date = dateText;
                newEntry. _promptText = randomPrompt;
                newEntry. _entryText = promptResponse;
                myJournal.AddEntry(newEntry);

                int totalEntries = myJournal.GetEntryCount();
                Console.WriteLine($"Cummulative entry No.: {totalEntries}");
            }

            else if (choice == 2)
            {
                myJournal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.Write("What is the file name to save the file? ");
                string file = Console.ReadLine();
                myJournal.SaveToFile(file);
            }

            else if (choice == 4)
            {
                Console.Write("What is the file name to load? ");
                string file = Console.ReadLine();
                myJournal.LoadFromFile(file);
            }

            else if (choice == 5)
            {
                break;
            }

            else
            {
                Console.WriteLine("Please enter a valid number");
            }
        }

    }
}

