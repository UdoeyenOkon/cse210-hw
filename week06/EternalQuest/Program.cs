using System;
// To add creativity and exceed requirement, I implemented a dynamic Level and Rank progression system.
// So, in addition to tracking goal completion and total score, the program now calculates a player’s level based on accumulated points and assigns a corresponding rank title. 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        Console.WriteLine();

        Console.WriteLine("This game has the following Levelling & Ranking system for the goals:");
        Console.WriteLine("Score range: 0-499 = Level 1; with the title 'Investigator'");
        Console.WriteLine("Score range: 500-999 = Level 2; with the title 'Newly Baptized'");
        Console.WriteLine("Score range: 1000-1499 = Level 3; with the title 'Less Active'");
        Console.WriteLine("Score range: 1500-1999 = Level 4; with the title 'Active'");
        Console.WriteLine("Score range: 2000+ = Level 5; with the title 'Pioneer'");

        Console.WriteLine();

        GoalManager manager = new GoalManager(new List<Goal>(), 0);
        manager.Start();

    }


}