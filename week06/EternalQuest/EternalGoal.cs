public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, string points) : base(shortName, description, points)
        {
        }
        public override int RecordEvent()
        {
            return _points;
        }

        public override string GetDetailsString()
        {
            return $"[ ] {_shortName} ({_description})";
        }
        public override string GetStringRepresentation()
        {
            return $"EternalGoal|{_shortName}|{_description}|{_points}";
        }


}