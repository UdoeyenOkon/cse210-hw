using System.Drawing;

public class Goal
{
        protected string _shortName;
        protected string _description;
        protected int _points;

        public Goal(string shortName, string description, string points)
        {
            _shortName = shortName;
            _description = description;
            _points = int.Parse(points);
        }

        public virtual int RecordEvent()
        {
            return 0;
        }

        public virtual bool IsComplete()
        {
            return false;
        }

        public virtual string GetDetailsString()
        {
            return $"[ ] {_shortName} ({_description})";
        }

        public virtual string GetStringRepresentation()
        {
            return $"Goal|{_shortName}|{_description}|{_points}";
        }
    
}