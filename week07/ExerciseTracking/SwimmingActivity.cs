public class SwimmingActivity : Activity
{
    private double _laps;

    public SwimmingActivity(DateTime date, double duration, int laps) : base (date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50)/1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance()/_duration) * 60;
    }

    public override double GetPace()
    {
        return 60/GetSpeed();
    }

    public override string GetStringRepresentation()
    {
        return $"{_date.ToString("dd MMM yyyy")} Swimming ({_duration:F2} min): Distance {GetDistance():F2}km, Speed: {GetSpeed():F2}kph, Pace: {GetPace():F2} min per km.";
    }
}