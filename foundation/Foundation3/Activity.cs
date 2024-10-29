public abstract class Activity 
{
    protected string _name;
    protected string _date;
    protected int _duration;

    public Activity(string date, string name, int duration)
    {
        _date = date;
        _name = name;
        _duration = duration;
    }

    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();

    public virtual string Summary()
    {
        return $"{_date} {_name} ({_duration} min) - Distance {CalculateDistance()} km, Speed {CalculateSpeed()} kph, Pace {CalculatePace()} min per km";
    }
    
}