public class SimpleGoal : Goal
{
    private bool _isComplete;

        public SimpleGoal(string shortName, string description, string points, bool isComplete) : base(shortName, description, points)
        {
            _isComplete = isComplete;
        }

        public override int RecordEvent()
        {
            if (!_isComplete)
            {
                _isComplete = true;
                return _points;
            }
            return 0;
        }

        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override string GetDetailsString()
        {
            return _isComplete ?
                $"[X] {_shortName} ({_description})" :
                $"[ ] {_shortName} ({_description})";
        }

        public override string GetStringRepresentation()
        {
            return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
        }
}
