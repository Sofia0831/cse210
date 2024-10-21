public class Circle : Shape 
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return 4*(3.14)*(Math.Pow(_radius, 2));
    }
}