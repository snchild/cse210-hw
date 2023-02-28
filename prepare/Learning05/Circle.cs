public class Circle : Shape
{
    private double _radius;
    private double _pi = 3.141592;
    public override double GetArea()
    {
        return _pi * _radius * _radius;
    }
    public override void SetDimension(double dimension, double ignoringHere)
    {
        _radius = dimension;
    }
}