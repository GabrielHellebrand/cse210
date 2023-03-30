 using System;
 public class RunningActivity : Activity
// This gets the speed and pace of the runner.
    {
        protected double _distance;

        public RunningActivity(DateTime date, int duration, double distance) : base(date, duration)
        {
            _distance = distance;
        }

        public override double GetDistance()
        {
            return _distance;
        }

        public override double GetSpeed()
        {
            return (_distance / GetPace().TotalHours);
        }

        public override TimeSpan GetPace()
        {
            return TimeSpan.FromMinutes(GetDuration() / _distance);
        }
        public override double GetDuration()
    {
        return (_distance * GetDistance() /60.0);
    }
    }