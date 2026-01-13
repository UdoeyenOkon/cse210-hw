using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // Console.Write("The magic number is: ");
        // string magicNumber = Console.ReadLine();
        // int magic = int.Parse(magicNumber);

        int guesses = 0;

        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 100);

        {
            Console.WriteLine("The sytem has generated a magic number within the range between 1-100");
        }

        while (true)
        {
            Console.Write("Make a guest of the magic number: ");
            string guessNumber = Console.ReadLine();
            int guess = int.Parse(guessNumber);

            guesses ++;
            
            if (guess < magic)
            {
                Console.WriteLine("Guest higher");
            }
            else if (guess > magic)
            {
                Console.WriteLine("Guest lower");
            }
            else
            {
                Console.WriteLine($"You made the right guess with a total number of {guesses} guesses.");

                // break;
            

                Console.Write("Do you wnat to play the game again? (yes or no): ");
                string answer = Console.ReadLine();

                if (answer != "yes")
                
                    break;
            }      
        }
        Console.WriteLine("Congratulations!");
    }
}