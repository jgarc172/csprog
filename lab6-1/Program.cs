using System;

namespace lab6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.getFields();
            mc.setFields();
            mc.getFields();
            MyClass.modFields();
            mc.getFields();
            mc = new MyClass();
            mc.getFields();
        }
    }

    class MyClass
    {
        private static int x = 20; //static fields
        private static int y;
        private static int z = 25;
        private int abc = 1000; //instance field
        public void getFields()
        {
            Console.WriteLine("static: {0},{1},{2} \ninstance: {3}", MyClass.x, MyClass.y, MyClass.z, this.abc);
        }
        public void setFields()
        {
            MyClass.x = 3;
            MyClass.y = 4;
            MyClass.z = 5;
            this.abc += 1000;
        }
        public static void modFields()
        {
            MyClass.x = 6;
            MyClass.y = 7;
            MyClass.z = 8;
        }
    }
}
