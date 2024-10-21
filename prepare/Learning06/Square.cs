public class Square : Shape
{
    private double _side;

    public override double ComputeArea()
    {
        return _side*4;
    }
}