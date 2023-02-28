public class Square : Shape
{
    private double _side;
    public override double GetArea()
    {
        return _side * _side;
    }
    public override void SetDimension(double dimension, double ignoringHere)
    {
        _side = dimension;
    }
}