using System;

namespace lab9_2a
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass1 B = new DerivedClass1();
            B.DoWork();
            BaseClass A = new BaseClass();
            A = B;
            A.DoWork();
        }
    }
    class BaseClass
    {
        public virtual void DoWork()
        {
            Console.WriteLine("BaseClass DoWork");
        }
    }
    class DerivedClass1 : BaseClass
    {
        public override void DoWork()
        {
            Console.WriteLine("DerivedClass1 DoWork");
        }
    }
}
