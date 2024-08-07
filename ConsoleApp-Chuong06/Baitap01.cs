using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp_Chuong06
{
    internal class Baitap01
    {
        public static void Test()
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(3, 4);
            Point p3 = new Point(5, 0);
            Point p4 = new Point(3, 7);

            LineSegment line = new LineSegment(p1, p2);
            Circle circle = new Circle(p1, 5);
            Rectangle rectangle = new Rectangle(p1, 3, 4);
            Square square = new Square(p1, 3);
            Triangle triangle = new Triangle(p1, p2, p3);
            Parallelogram parallelogram = new Parallelogram(p1, p2, p3, p4);
            Rhombus rhombus = new Rhombus(p1, p2, p3, p4);

            WriteLine(line);
            WriteLine(circle);
            WriteLine(rectangle);
            WriteLine(square);
            WriteLine(triangle);
            WriteLine(parallelogram);
            WriteLine(rhombus);
            WriteLine();
        }

    }

    public class Baitap02()
    {
        public static void Tester()
        {
            Shape[] shapes = new Shape[]
            {
                new Point(0,0),
                new LineSegment(new Point(0,0), new Point(4,5)),
                new Circle(new Point(1,1),5),
                new Rectangle(new Point(1,1),5,8),
                new Square(new Point(2,2),6),
                new Triangle(new Point(3,3), new Point(6,7), new Point(8,3)),
                new Parallelogram(new Point(0, 0), new Point(3, 4), new Point(5, 0), new Point(2, 2)),
                new Rhombus(new Point(0, 0), new Point(3, 4), new Point(6, 0), new Point(3, -4))
            };

            foreach(Shape shape in shapes)
            {
                shape.Draw();
            }

        }
    }
}

public class Shape
{
    public virtual void Draw()
    {
        WriteLine("Drawing a shape");
    }
}

public class Point : Shape //Điểm
{
    public double X;
    public double Y;
    public Point(double x, double y)
    {
        this.X = x;
        this.Y = y;
    }
    public override string ToString()
    {
        return $"({X},{Y})";
    }

    public override void Draw() 
    {
        WriteLine($"Drawing a point at ({X}, {Y})");
    }
    
}

public class LineSegment  : Shape //đoạn thẳng
{
    public Point Start;
    public Point End;

    public LineSegment(Point start, Point end)
    {
        this.Start = start;
        this.End = end;
    }

    public override void Draw()
    {
        WriteLine($"Drawing a line segment from {Start} to {End}");
    }

    public override string ToString()
    {
        return $"Line Segment from {Start} to {End}";
    }
} 

public class Circle : Shape //Hinh tron
{
    public Point Center;
    public double Radius;

    public Circle(Point center, double radius)
    {
        this.Center = center;
        this.Radius = radius;
    }

    public override void Draw()
    {
        WriteLine($"Drawing a circle with center at {Center} and radius {Radius}");
    }

    public override string ToString()
    {
        return $"Circle with center at {Center} and radius {Radius}";
    }
}

public class Rectangle : Shape //Hinh chu nhat
{
    public Point TopLeft;
    public double Width;
    public double Height;

    public Rectangle(Point topLeft, double width, double height)
    {
        this.TopLeft = topLeft;
        this.Width = width;
        this.Height = height;
    }

    public override void Draw()
    {
        WriteLine($"Drawing a rectangle with top left corner at {TopLeft}, width {Width}, and height {Height}");
    }

    public override string ToString()
    {
        return $"Rectangle with top left corner at {TopLeft}, width {Width}, and height {Height}";
    }
}

public class Square : Shape //hinh vuong
{
    public Point TopLeft;
    public double SideLength;

    public Square(Point topLeft, double sideLength)
    {
        this.TopLeft = topLeft;
        this.SideLength = sideLength;
    }

    public override void Draw()
    {
        WriteLine($"Drawing a square with top left corner at {TopLeft} and side lenght {SideLength}");
    }

    public override string ToString()
    {
        return $"Square with top left corner at {TopLeft} and side length {SideLength}";
    }
}

public class Triangle : Shape  //tam giac
{
    public Point Vertex1;
    public Point Vertex2;
    public Point Vertex3;

    public Triangle(Point vertex1, Point vertex2, Point vertex3)
    {
        this.Vertex1 = vertex1;
        this.Vertex2 = vertex2;
        this.Vertex3 = vertex3;
    }

    public override void Draw()
    {
        WriteLine($"Drawing a triangle with vertices at {Vertex1}, {Vertex2}, and {Vertex3}");
    }

    public override string ToString()
    {
        return $"Triangle with vertices at {Vertex1}, {Vertex2}, and {Vertex3}";
    }
}

public class Parallelogram : Shape  //Hinh binh hanh
{
    public Point Vertex1;
    public Point Vertex2;
    public Point Vertex3;
    public Point Vertex4;

    public Parallelogram(Point vertex1, Point vertex2, Point vertex3, Point vertex4)
    {
        this.Vertex1 = vertex1;
        this.Vertex2 = vertex2;
        this.Vertex3 = vertex3;
        this.Vertex4 = vertex4;
    }

    public override void Draw()
    {
        WriteLine($"Drawing a parallelogram with vertices at {Vertex1}, {Vertex2}, {Vertex3}, and {Vertex4}");
    }

    public override string ToString()
    {
        return $"Parallelogram with vertices at {Vertex1}, {Vertex2}, {Vertex3}, and {Vertex4}";
    }
}

public class Rhombus : Shape //Hinh thoi
{
    public Point Vertex1;
    public Point Vertex2;
    public Point Vertex3;
    public Point Vertex4;

    public Rhombus(Point vertex1 , Point vertex2, Point vertex3, Point vertex4)
    {
        this.Vertex1 = vertex1;
        this.Vertex2 = vertex2;
        this.Vertex3 = vertex3;
        this.Vertex4 = vertex4;
    }

    public override void Draw()
    {
        WriteLine($"Drawing a rhombus with vertices at {Vertex1}, {Vertex2}, {Vertex3}, and {Vertex4}");
    }

    public override string ToString()
    {
        return $"Rhombus with vertices at {Vertex1}, {Vertex2}, {Vertex3}, and {Vertex4}";
    }
}