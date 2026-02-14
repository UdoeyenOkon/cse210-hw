public class BreathingActivity : Activity
{
    
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        
    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.Write("Get ready...");
        ShowSpinner();

        Console.WriteLine();

        while (DateTime.Now < endTime)
        {
            Console.Write("Breath in...");
            for(int b = 2; b > 0; b--)
            {
                Console.Write(b);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine();
    
            Console.Write("Breath out...");
            for(int b = 3; b > 0; b--)
            {
                Console.Write(b);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine();
            Console.WriteLine();
           

            Console.Write("Breath in...");
            for(int i = 4; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

             Console.WriteLine();

            Console.Write("Breath out...");
            for(int i = 6; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
             Console.WriteLine();
             Console.WriteLine();

            Console.Write("Breath in...");
            for(int i = 4; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

             Console.WriteLine();

            Console.Write("Breath out...");
            for(int i = 6; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
             Console.WriteLine();
             Console.WriteLine();

            Console.Write("Breath in...");
            for(int i = 4; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

             Console.WriteLine();

            Console.Write("Breath out...");
            for(int i = 6; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
             Console.WriteLine();
             Console.WriteLine();

            Console.Write("Breath in...");
            for(int i = 4; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

             Console.WriteLine();

            Console.Write("Breath out...");
            for(int i = 6; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
             Console.WriteLine();
             Console.WriteLine();
        }  
        
    }

}