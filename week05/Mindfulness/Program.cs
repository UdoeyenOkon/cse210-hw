using System;
using System.ComponentModel.Design;
using System.Net;
using System.Runtime.InteropServices;

// To show creativity and exceed the requirement, I have done the following:
// 1. Kept a log of how many times activities were performed.
// 2. Ensured thjat no random prompts/questions are selected until they have all been used at least once in that session.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine();
       
        int count = 0;
        int count1 = 0;
        int count2 = 0;
        int count3 = 0;

        
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the menu: ");
            // string userInput = Console.ReadLine();
            if (!int.TryParse(Console.ReadLine(), out int option))
        {
            Console.WriteLine("Invalid input.");
            continue;
        }
        
            if (option == 1)
                {
                    Console.Write("How long, in seconds, would you like for your session? ");
                    string userInput = Console.ReadLine();
                    int duration = int.Parse(userInput);
                    BreathingActivity activity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", duration);
                    activity.DispayStartingMessage();
                    activity.Run();
                    activity.DisplayEndingMessage();
                    activity.ShowSpinner();
                    count1++;
                }

                else if (option == 2)
                {
                    Console.Write("How long, in seconds, would you like for your session? ");
                    string userInput = Console.ReadLine();
                    int duration = int.Parse(userInput);
                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration);
                    reflectingActivity.DispayStartingMessage();
                    reflectingActivity.Run();
                    reflectingActivity.DisplayEndingMessage();
                    reflectingActivity.ShowSpinner();
                    count2++;
                }

                else if (option == 3)
                {
                    Console.Write("How long, in seconds, would you like for your session? ");
                    if (!int.TryParse(Console.ReadLine(), out int duration))
                    {
                        Console.WriteLine("Invalid input.");
                        return;
                    }

                    ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration );
                    listingActivity.DispayStartingMessage();
                    listingActivity.Run();
                    listingActivity.DisplayEndingMessage();
                    listingActivity.ShowSpinner();
                    count3++;
                    
                }

                else if (option == 4)
                    {
                        break;
                    }

                else
                {
                    Console.WriteLine("Please select a valid option!!!");
                    
                }
            count++;
        }
        Console.WriteLine($"You performed {count1} Breathing Activity, {count2} Reflection Activity, and {count3} Listing Activity.");
        Console.WriteLine($"All together, total number of activities you performed were: {count}.");
        
    }   
}   