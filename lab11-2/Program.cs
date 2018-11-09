using System;

namespace lab11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle();
            cir.Draw();
            Console.WriteLine(cir.X);
            Console.WriteLine(cir.Y);
        }
    }

    public abstract class Shape
    {
        protected int _x = 100;
        protected int _y = 150;
        public abstract int X { get; }
        public abstract int Y { get; }
        public abstract void Draw();
    }
    class Circle : Shape
    {
        public override int X
        {
            get
            {
                return _x + 10;
            }
        }
        public override int Y
        {
            get
            {
                return _y + 10;
            }
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }
}