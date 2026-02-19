public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(DateTime date, double duration, double speed) : base (date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * _duration) /60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60/_speed;
    }

    public override string GetStringRepresentation()
    {
        return $"{_date.ToString("dd MMM yyyy")} Cycling ({_duration:F2} min): Distance {GetDistance():F2}km, Speed: {GetSpeed():F2}kph, Pace: {GetPace():F2} min per km.";

    }

}