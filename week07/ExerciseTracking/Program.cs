using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        
            DateTime date = DateTime.Now;
            date = DateTime.Today;
           
        RunningActivity runningActivity = new RunningActivity(date, 30, 10);
        CyclingActivity cyclingActivity = new CyclingActivity(date, 40, 10);
        SwimmingActivity swimmingActivity = new SwimmingActivity(date, 10, 8);        
        
        List<Activity> activities = new List<Activity>();
        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetStringRepresentation());
        }
    }
}