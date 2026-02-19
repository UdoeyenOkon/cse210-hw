public abstract class Activity
{
    protected DateTime _date;
    protected double _duration;
      
    public Activity(DateTime date, double duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetStringRepresentation()
    {
        return $"{_date.ToString("dd MMM yyyy")} Activity ({_duration:F2} min): Distance {GetDistance():F2}km, Speed: {GetSpeed():F2}kph, Pace: {GetPace():F2} min per km.";
    }
}