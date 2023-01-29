public class Fraction
{
    private int _numer = 0;
    private int _denom;
    public Fraction()
    {
        _numer = 1;
        _denom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _numer = wholeNumber;
        _denom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _numer = top;
        _denom = bottom;
    }
    public int GetTop()
    {
        return _numer;
    }
    public int GetBottom()
    {
        return _denom;
    }
    public void SetTop(int top)
    {
        _numer = top;
    }
    public void SetBottom(int bottom)
    {
        _denom = bottom;
    }
    public string GetFractionString()
    {
        return _numer + "/" + _denom;
    }
    public double GetDecimalValue()
    {
        return (double)_numer / _denom;
    }
}