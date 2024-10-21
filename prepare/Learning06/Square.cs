public class Square : Shape
{
    private double _side;

    public override double GetArea()
    {
        return _side*4;
    }
}