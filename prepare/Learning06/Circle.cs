public class Circle : Shape 
{
    private double _radius;

    public override double GetArea()
    {
        return 4*(3.14)*(Math.Pow(_radius, 2));
    }
}