public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(DateTime date, double duration, double distance) : base (date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _duration) * 60;
    }

    public override double GetPace()
    {
        return _duration/_distance;
    }

    public override string GetStringRepresentation()
    {
        return $"{_date.ToString("dd MMM yyyy")} Running ({_duration:F2} min): Distance {GetDistance():F2}km, Speed: {GetSpeed():F2}kph, Pace: {GetPace():F2} min per km.";
    }

}