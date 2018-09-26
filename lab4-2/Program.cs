using System;

namespace lab4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            RealEstate Condo = new RealEstate();
            Console.WriteLine(Condo.SomeProperty);
            Condo.PropertyListing = 730;
            Console.WriteLine(Condo.PropertyListing);
            Condo.Name = "Valley of the Deer Condominiums";
            string ad = Condo.Name + "For Sale";
            Console.WriteLine(ad);
            Condo.Price = 685000;
            Console.WriteLine(Condo.Price);
            Console.ReadLine();

            //Create another instance here!
            RealEstate House = new RealEstate();
            Console.WriteLine(House.SomeProperty);
            House.PropertyListing = 730;
            Console.WriteLine(House.PropertyListing);
            House.Name = "Lester Estate";
            Console.WriteLine(House.Name + "For Sale");
        }
    }

    class RealEstate
    {

        public string SomeProperty
        {
            get
            {
                return "This is the property value."; //return literal
            }

        }

        private int propertyListing; //camelCase
        public int PropertyListing   //PascalCase
        {
            get
            {
                return propertyListing * 365; //return after calculation
            }
            set
            {
                if (value < 365) //enforce condition for setting value
                    propertyListing = value;
                else
                    propertyListing = value / 365;
            }
        }

        private string name = "RidgeView Condominium";
        public string Name
        {
            get
            {
                return name + " ";  //can format return value
            }
            set
            {
                name = value;
            }
        }
        public int Price { get; set; } //field built-in
    }
}
