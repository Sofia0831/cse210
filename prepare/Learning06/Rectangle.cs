public class Rectangle : Shape 
{
    private double _length;
    private double _width;

    public override double ComputeArea()
    {
        return (2*_length) + (2*_width);
    }
}