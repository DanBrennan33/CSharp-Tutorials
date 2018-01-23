using System;

public abstract class Shape
{
    public abstract double Area { get; set; }

    public abstract double Perimeter { get; set; }

    public override string ToString()
    {
        return GetType().Name;
    }

    public static double GetArea(Shape shape)
    {
        return shape.Area;
    }

    public static double GetPerimeter(Shape shape)
    {
        return shape.Perimeter;
    }
}