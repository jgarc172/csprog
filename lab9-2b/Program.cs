using System;

namespace lab9_2a
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass2 C = new DerivedClass2();
            C.DoWork();
            BaseClass D = new BaseClass();
            D = C;
            D.DoWork();
        }
    }
    class BaseClass
    {
        public int WorkField;
        public virtual void DoWork()
        {
            Console.WriteLine("BaseClass DoWork");
        }
    }
    class DerivedClass2 : BaseClass
    {
        public new int WorkField;
        public new void DoWork()
        {
            base.DoWork();
            WorkField++;
            Console.WriteLine("DerivedClass2 DoWork");
        }
    }
}
