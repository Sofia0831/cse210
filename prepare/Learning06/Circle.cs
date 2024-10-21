public class Circle : Shape 
{
    private double _radius;

    public override double ComputeArea()
    {
        return 4*(3.14)*(Math.Pow(_radius, 2));
    }
}