public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, string name, int duration, double distance) : base(date, name, duration)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculateSpeed()
    {
        return (_distance/_duration)* 60 ;
    }

    public override double CalculatePace()
    {
        return 60/CalculateSpeed();
    }
}