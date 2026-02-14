public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
        {
           "*Think of a time when you stood up for someone else.",
           "*Think of a time when you did something really difficult.",
           "*Think of a time when you helped someone in need.",
           "*Think of a time when you did something truly selfless."
        };
    private List<string> _questions = new List<string>
        {
           "*Why was this experience meaningful to you?",
           "*Have you ever done anything like this before?",
           "*How did you get started?",
           "*How did you feel when it was complete?",
           "*What made this time different than other times when you were not as successful?",
           "*What is your favorite thing about this experience?",
           "*What could you learn from this experience that applies to other situations?",
           "*What did you learn about yourself through this experience?",
            "*How can you keep this experience in mind in the future?"
        };
    private Random _random;

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _random = new Random();
    }

     public string GetRandomPrompt()
    {
        int index = _random.Next(0, _prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        int index = _random.Next(0, _questions.Count);
        return _questions[index];
    }

    public void DisplayQuestions()
    {
        Console.WriteLine(_questions);
    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.Write("Get ready...");
        ShowSpinner();

        Console.WriteLine();
      
        Console.WriteLine("Consider the following promt");

          
        Console.WriteLine(GetRandomPrompt() );
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue" );
        string userResponse = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as the relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown();
        Console.WriteLine();
             
        while (DateTime.Now < endTime)
        {   Console.Write(GetRandomQuestion());
            ShowSpinner();
            Console.WriteLine();
        }
        Console.WriteLine($"Your have completed {_duration}-seconds on this activity.");   
        }
          
}
