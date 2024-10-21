public abstract class Shape 
{
    private string _color;

    public abstract double ComputeArea();
    public void SetColor(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }
}