using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        }

        List<int>numbers = new List<int>();
        float average = 0;
        int largestNumber = 0;

        {
            Console.WriteLine("Great a list of numbers, (Enter 0 to end the list) ");
        }

        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input); 
            
                       

            if (number == 0)
            {
                break;
            }
            else
            {
                numbers.Add(number);
            }
        }


        float sumOfNumbers = 0;
        foreach (int number in numbers)
        {
            sumOfNumbers += number;
            average = sumOfNumbers/numbers.Count;
        }
        Console.WriteLine($"Sum is: {sumOfNumbers}");
        Console.WriteLine($"Average is: {average}");
        

        foreach(int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }
        Console.WriteLine($"Largest number is: {largestNumber}");

    }

        

}