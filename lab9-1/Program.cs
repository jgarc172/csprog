using System;

namespace lab9_1
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
        }
    }

    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Shape Draw");
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Rectangle Draw");
        }
    }
    class Triangle : Shape
    {
        public override void Draw(){
            Console.WriteLine("Triangle Draw");
        }
    }
    class Circle : Shape
    {
        public override void Draw(){
            Console.WriteLine("Circle Draw");
        }
 
    }
}
