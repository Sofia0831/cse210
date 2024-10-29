public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(string date, string name, int duration, double speed) : base(date, name, duration)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        return _speed*_duration/60;
    }

    public override double CalculatePace()
    {
        return 60/_speed;
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }
}