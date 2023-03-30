using System;
public class CyclingActivity : Activity
{
    protected double _speed;

// This gets the speed of the cycling activity at the gym.
    public CyclingActivity(DateTime date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }
    public override double GetDuration()
    {
        return (_speed * GetDistance() /60.0);
    }
    public override double GetDistance()
    {
        return (_speed * GetDuration() / 60.0);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override TimeSpan GetPace()
    {
        return TimeSpan.FromMinutes(1 / (_speed / 60.0));
    }
}