using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("Enter your grade percentage: ");
        string gradePercentage = Console.ReadLine();
        int percentage = int.Parse(gradePercentage);
        string letter = ("");
        string Sign = ("");

        if (percentage >= 90)
        {
            letter ="A";
            // Console.WriteLine($"You have scored an A grade.");
        }
        else if (percentage >=80)
        {
            letter ="B";
            // Console.WriteLine($"You have scored a B grade.");
        }
        else if (percentage >=70)
        {
            letter ="C";
            // Console.WriteLine("You have scored a C grade.");
        }
        else if (percentage >=60)
        {
            letter ="D";
            // Console.WriteLine("You have scored a D grade.");
        }
        else
        {
            letter ="F";
            // Console.WriteLine("You have scored a F grade.");
        }

            if (percentage%10 >= 7 && letter !="A" && letter != "F")

                {
                    Sign = "+";
                }
            else if (percentage%10 < 3 && letter != "F")
                {
                    Sign = "-";
                }
            else
                {
                    Sign = " ";
                }

                Console.WriteLine($"You have scored a {letter}{Sign} grade");

                if (percentage >=70)
                {
                    Console.WriteLine("You pass the course.");
                    Console.WriteLine("Congratulations!");
                }
                else
                {
                Console.WriteLine("You fail the course.");
                Console.WriteLine("You are welcome to try again by next semeter.");
                }
    }
}