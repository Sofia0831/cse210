public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(string date, string name, int duration, int laps) : base(date, name, duration)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double CalculatePace()
    {
        return _duration/CalculateDistance();
    }

    public override double CalculateSpeed()
    {
        return 60/CalculatePace();
    }
}