using System;
using System.Collections.Generic;

namespace lab15_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Racer graham = new Racer(7, "Graham", "HIll", "UK", 14);
            Racer emerson = new Racer(13, "Emerson", "Fittipaldi", "Brazil", 14);
            Racer mario = new Racer(16, "Mario", "Andretti", "USA", 12);
            List<Racer> racers = new List<Racer>(20) { graham, emerson, mario };

            Console.WriteLine("capacity: {0}", racers.Capacity);
            Console.WriteLine("count: {0}", racers.Count);

            Racer mike = new Racer(24, "Michael", "Schumacher", "Germany", 91);
            racers.Add(mike);
            racers.Add(new Racer(27, "Mika", "Hakkinen", "Finland", 20));
            racers.AddRange(new Racer[] {
               new Racer(14, "Niki", "Lauda", "Austria", 25),
               new Racer(21, "Alain", "Prost", "France", 51)});

            List<Racer> racers2 = new List<Racer>(new Racer[] {
               new Racer(12, "Jochen", "Rindt", "Austria", 6),
               new Racer(22, "Ayrton", "Senna", "Brazil", 41) });

            Racer r1 = racers[0];
            Console.WriteLine();
            Console.WriteLine("for loop: ");
            for (int i = 0; i < racers.Count; i++)
                Console.WriteLine(racers[i]);

            Console.WriteLine();
            Console.WriteLine("foreach loop: ");
            foreach (Racer r in racers)
                Console.WriteLine(r);
            Console.WriteLine();

            Console.WriteLine("Removing racer 0");
            Console.WriteLine("count: {0}", racers.Count);
            racers.RemoveAt(0); //Graham removed
            Console.WriteLine("count after removing: {0}", racers.Count);
            if (!racers.Remove(graham))
                Console.WriteLine("Object not found");

            Console.WriteLine("Racer 0 is: " + racers[0]);
            int index = 0;
            int count = 1;
            racers.RemoveRange(index, count);
            int index1 = racers.IndexOf(mario);
            Console.WriteLine("Mario is now at position:" + index1);
        }
    }
    class Racer
    {
        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public int Wins { get; set; }
        public Racer(int id, string firstName, string lastName, string country = null, int wins = 0)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Country = country;
            this.Wins = wins;
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} - {this.Country}";
        }
    }
}
