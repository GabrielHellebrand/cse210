using System;
    public class SwimmingActivity : Activity
// This gets the speed and distance of the swimmer as well as how many laps they did.
    {
        private int _laps;

        public SwimmingActivity(DateTime date, int duration, int laps) : base(date, duration)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            return (_laps * 50.0 / 1000.0);
        }

        public override double GetSpeed()
        {
            return (GetDistance() / GetPace().TotalHours);
        }

        public override TimeSpan GetPace()
        {
            return TimeSpan.FromMinutes(GetDuration() / (_laps * 50.0 / 1000.0));
        }
       public override double GetDuration()
    {
        return (_laps * GetDistance() /60.0);
    }
    }