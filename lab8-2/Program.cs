using System;

namespace lab8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var arabel = new GenericCustomer("Arabel Jones");
            var bella = new Nevermore60Customer("Bella Noche");
            Console.WriteLine(bella.Name);
        }
    }
    class GenericCustomer
    {
        private string name;
        public GenericCustomer()
        {
            this.name = "";
        }
        public GenericCustomer(string aName)
        {
            this.name = aName;
        }
        public string Name
        {
            get {return name;}
            set {name = value;}
        }
    }
    class Nevermore60Customer : GenericCustomer
    {
        private string referrerName;
        //private uint highCostMinutesUsed;
        public Nevermore60Customer(string aName)
        : this(aName, "")
        {

        }
        public Nevermore60Customer(string aName, string refName)
        : base(aName)
        {
            this.referrerName = refName;
        }
    }
}
