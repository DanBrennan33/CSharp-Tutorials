using System;

public class Example
{
    public static void Main()
    {
        Shape[] shapes = { new Rectangle(10, 12), new Square(5),
                        new Circle(3) };
        foreach (var shape in shapes)
        {
            Console.WriteLine("{0}: area = {1} perimeter = {2}", shape, Shape.GetArea(shape), Shape.GetPerimeter(shape));
            var rect = shape as Rectangle;
            if (rect != null)
            {
                Console.WriteLine("   Is Square: {0}, Diagonal: {1}", rect.IsSquare(), rect.Diagonal);
                continue;
            }
            var sq = shape as Square;
            if (sq != null)
            {
                Console.WriteLine("   Diagonal: {0}", sq.Diagonal);
                continue;
            }
        }
    }
}
// The example displays the following output:
//         Rectangle: area, 120; perimeter, 44
//            Is Square: False, Diagonal: 15.62
//         Square: area, 25; perimeter, 20
//            Diagonal: 7.07
//         Circle: area, 28.27; perimeter, 18.85