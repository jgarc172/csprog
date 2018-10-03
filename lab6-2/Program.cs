using System;

namespace lab6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ratio sdtv = new Ratio();
            Ratio hd = new Ratio();
            sdtv.Num = 4;
            sdtv.Den = 3;
            hd.Num = 16;
            hd.Den = 9;
            Ratio aspect = new Ratio();
            aspect = aspect.sum(sdtv, hd);
            Console.WriteLine("aspect: {0}", aspect);
            Ratio aspect2 = Ratio.staticsum(sdtv, hd);
            Console.WriteLine("aspect2: {0}", aspect2);
            Ratio aspect3 = hd.sum(sdtv);
            Console.WriteLine("aspect3: {0}", aspect3);
        }
    }

    class Ratio
    {
        public int Num {set; get;}
        public int Den {set; get;}
        public Ratio sum(Ratio other)
        {
            Ratio sum = new Ratio();
            sum.Num = this.Num * other.Den + other.Num * this.Den;
            sum.Den = this.Den * other.Den;
            return sum;
        }
        public Ratio sum(Ratio x, Ratio y)
        {
            
            return x.sum(y);
        }
        public override string ToString()
        {
            return $"{this.Num} / {this.Den}";
        }
        public static Ratio staticsum(Ratio x, Ratio y)
        {
            return x.sum(y);
        }
    }
}
