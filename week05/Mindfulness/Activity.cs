using System.Text;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DispayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("You have done a good job. Well done!!");
    }

    public void ShowSpinner()
    {
        List<string>animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("|");
        animationString.Add("-");
        animationString.Add("\\");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);

        int i = 0;
        
        while (DateTime.Now < endTime)     
        {
            string s = animationString[i];
            Console.Write (s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if(i >= animationString.Count)
            {
                i = 0;
            }
        }
    }

 public void ShowCountDown()
    {
        for(int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}