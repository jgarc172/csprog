using System;

namespace lab9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Guy joe1 = new Guy("Joe", 37, 100);
            Guy joe2 =  joe1;
            Console.WriteLine(joe1);
            Console.WriteLine(joe2);
        }
    }
    class Guy
    {
        private readonly string name;
        public string  Name {get {return name;}}
        private readonly int age;
        public int Age {get {return age;}}
        public int Cash {get; private set;}
        public Guy(string name, int age, int cash)
        {
            this.name = name;
            this.age = age;
            Cash = cash;
        }
        public override string ToString()
        {
            return $"{this.name} is {this.age} years old and has {Cash} bucks";
        }
    }
}
