 using System;
 public abstract class Activity
    {
        protected DateTime _date;
        protected int _duration;
// This gets the date of the activity as well as how long the activity is.
        public Activity(DateTime date, int duration)
        {
            _date = date;
            _duration = duration;
        }

        public abstract double GetDistance();
        public abstract double GetDuration();
        public abstract double GetSpeed();
        public abstract TimeSpan GetPace();

        public string GetSummary()
        {
            return $"{_date:dd MMM yyyy} {GetType().Name} ({_duration} min) - Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace().Minutes}:{GetPace().Seconds:00} min per km";
        }
    }