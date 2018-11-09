using System;

namespace lab12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Height = 5;
            r.Width = 4;
            Console.WriteLine("Area of rectangle is " + r.Area());

            Square sq = new Square();
            sq.Width = 4;
            Console.WriteLine("Area of square is " + sq.Area());
        }
    }
    interface IShape
    {
        double Area();
    }
    class Rectangle : IShape
    {
        public int Height {get; set;}
        public int Width {get; set;}
        public double Area()
        {
            return Height * Width;
        }
    }
    class Square : IShape
    {
        public int Width {get; set;}
        public double Area()
        {
            return Width * Width;
        }
    }
}
