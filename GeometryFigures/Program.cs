using System.Diagnostics;

namespace GeometryFigures;

public class Program
{
    static void Main(string[] args)
    {
        var x = new Triangle(1, 2, 2.24);
        Console.WriteLine(x.GetArea());
        var y = new Circle(5);
        Console.WriteLine(y.GetArea());
    }
}