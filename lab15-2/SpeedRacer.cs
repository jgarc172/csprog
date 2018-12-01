using System;
using System.Collections.Generic;

namespace lab15_2
{
    class SpeedRacer
    {
        static void Main(string[] args)
        {
            Racer graham = new Racer(7, "Graham", "HIll", "UK", 14);
            Racer emerson = new Racer(13, "Emerson", "Fittipaldi", "Brazil", 14);
            Racer mario = new Racer(16, "Mario", "Andretti", "USA", 12);

            LinkedList<Racer> racers = new LinkedList<Racer>();
            racers.AddFirst(graham);
            racers.AddFirst(emerson);
            racers.AddFirst(mario);
            Console.WriteLine("count: {0}", racers.Count);

            Racer mike = new Racer(24, "Michael", "Schumacher", "Germany", 91);
            racers.AddLast(mike);
            racers.AddLast(new Racer(27, "Mika", "Hakkinen", "Finland", 20));
            Console.WriteLine("count: {0}", racers.Count);

            Racer r1 = racers.First.Value;

            Console.WriteLine("foreach loop: ");
            foreach (Racer r in racers)
                Console.WriteLine(r);
            Console.WriteLine();

            Console.WriteLine("Removing racer 0");
            racers.RemoveFirst();

            if (!racers.Remove(graham))
                Console.WriteLine("Object not found");

            Console.WriteLine("Racer 0 is: " + racers.First.Value);
            try
            {
                LinkedListNode<Racer> index1 = racers.Find(mario);
                racers.Remove(index1);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Not Found");
            }
            Console.WriteLine();
            foreach (Racer r in racers)
                Console.WriteLine(r);

            /*            racers.AddRange(new Racer[] {
                           new Racer(14, "Niki", "Lauda", "Austria", 25),
                           new Racer(21, "Alain", "Prost", "France", 51)});

                        LinkedList<Racer> racers2 = new LinkedList<Racer>(new Racer[] {
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

                        */
        }
    }
}
