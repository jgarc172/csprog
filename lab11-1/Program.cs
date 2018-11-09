using System;

namespace lab11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Rectangle();
            shapes[1] = new Triangle();
            shapes[2] = new Circle();

            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            Square sq = new Square(12);
            Console.WriteLine("Area of the square = {0}", sq.Area());
        }
    }
}
public abstract class Shape
{
    public abstract void Draw();
}
class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Rectange");
    }
}
class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Triangle");
    }
}
class Circle : Shape
{
     public override void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }
}   
class Square : Shape
{
    private int side;
    public Square(int n)
    {
        side = n;
    }
    public int Area()
    {
        return side * side;
    }
     public override void Draw()
    {
        Console.WriteLine("Drawing a Square");
    }
}
