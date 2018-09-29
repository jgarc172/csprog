using System;

namespace lab5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Ratio ratio1 = new Ratio(4, 8); //call instance constructor
            Ratio ratio2 = new Ratio(ratio1);  //call instance copy constructor
            Ratio ratio3 = new Ratio();       //call instance constructor
            Console.WriteLine(ratio1);
            Console.WriteLine(ratio2);
            Console.WriteLine(ratio3);
        }
    }

    public class Ratio
    {
        public int Num { set; get; }
        public int Den { set; get; }
        private bool improper = false;

        public Ratio()
        {
            this.Num = 0;
            this.Den = 0;
            this.improper = false;
        }
        public Ratio(int num, int den)
        {
            this.Num = num;
            this.Den = den;
        }

        public Ratio(Ratio original)
            : this(original.Num, original.Den)
        {
        }
        public Ratio sum(Ratio x, Ratio y) //problem: requires throw-away object
        {
            int num = x.Num * y.Den + x.Den * y.Num;
            int den = x.Den * y.Den;
            Ratio temp = new Ratio();

            if (den > num)
                this.improper = true;

            temp.Den = den;
            temp.Num = num;
            return temp;
        }

        public static Ratio staticsum(Ratio x, Ratio y) //solution 1: static method
        {
            int num = x.Num * y.Den + x.Den * y.Num;
            int den = x.Den * y.Den;
            Ratio temp = new Ratio();

            temp.Den = den;
            temp.Num = num;
            return temp;
        }



        public Ratio sum(Ratio x)  //solution 2: instance method
        {
            int num = x.Num * this.Den + x.Den * this.Num;
            int den = x.Den * this.Den;
            Ratio temp = new Ratio();

            if (den > num)
                temp.improper = true;

            temp.Den = den;
            temp.Num = num;
            return temp;
        }

        public override string ToString()
        {
            return $"{Num}/{Den}";
        }
    }
}
