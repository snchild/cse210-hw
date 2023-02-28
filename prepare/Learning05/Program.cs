using System;

class Program
{
    static void Main(string[] args)
    {
        Square s = new Square();
        s.SetColor("blue");
        s.SetDimension(3,0);

        Rectangle r = new Rectangle();
        r.SetColor("red");
        r.SetDimension(7,5);

        Circle c = new Circle();
        c.SetColor("yellow");
        c.SetDimension(2,0);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(s);
        shapes.Add(r);
        shapes.Add(c);

        for(int i = 0; i < shapes.Count; i++)
        {
            Console.WriteLine("For this shape: ");
            Console.WriteLine($"Color: {shapes[i].GetColor()}");
            Console.WriteLine($"Area: {shapes[i].GetArea()} units squared\n");
        }
    }
}