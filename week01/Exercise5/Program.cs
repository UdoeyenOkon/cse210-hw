using System;

class Program
{
    static void Main(string[] args)
    {
         WelcomeMessage();

        Console.Write("Please enter your name: ");
        string Name = Console.ReadLine();

        Console.Write("Please enter your favorite number: ");
        string UserInput = Console.ReadLine();
        int Number = int.Parse(UserInput);
        
        
       
        string UserName = PromptUserName(Name);
        int UserNumber = PromptUserNumber(Number);

        int SquareOfNumber = UserNumber*UserNumber;

        Console.WriteLine($"{UserName}, the square of your number is {SquareOfNumber}");
    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the prgram!");
    }

    static string PromptUserName(string Name)
    {
        return Name;
    }

    static int PromptUserNumber(int Number)
    {
        return Number;
    }

    
}