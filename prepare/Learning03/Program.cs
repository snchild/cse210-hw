using System;

class Program
{
    static void Main(string[] args)
    {
        //instance of 1/1
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction1.GetFractionString());
        
        //instance of 5/1
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction2.GetFractionString());

        //instance of 3/4
        Fraction fraction3 = new Fraction(3,4);
        Console.WriteLine(fraction3.GetDecimalValue());
        Console.WriteLine(fraction3.GetFractionString());

        //instance of 1/3
        Fraction fraction4 = new Fraction(1,3);
        Console.WriteLine(fraction4.GetDecimalValue());
        Console.WriteLine(fraction4.GetFractionString());
    }
}