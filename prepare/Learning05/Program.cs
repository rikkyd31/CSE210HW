using System;
using System.Drawing;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapesList = new List<Shape>();
        string color = "Red";
        double side = 3.0;
        double width = 2.0;
        double height = 4.0;
        double radius = 2.0;
        double area;

        shapesList.Add(new Square(color, side));
        shapesList.Add(new Rectangle(color, width, height));
        shapesList.Add(new Circle(color, radius));

        foreach (Shape shape in shapesList)
        {
            color = shape.GetColor();
            area = shape.GetArea();
            Console.WriteLine(color);
            Console.WriteLine(area);
        }
    }
}