public class Rectangle : Shape
{
    private double _length;
    private double _width;
    public override double GetArea()
    {
        return _length * _width;
    }
    public override void SetDimension(double dimension1,double dimension2)
    {
        _length = dimension1;
        _width = dimension2;
    }
}