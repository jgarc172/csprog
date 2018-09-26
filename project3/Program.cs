using System;

namespace project3
{
    class Program
    {
        static void Main(string[] args)
        {
           GreetingCard festivus = new GreetingCard(1);
           festivus.From = "Jose";
           festivus.To = "Nancy";
           festivus.Occasion = "Festivus";
           festivus.Greeting = "May you have a very Merry Festivus";
           Console.WriteLine(festivus);
           Console.WriteLine();

           GreetingCard bday = new GreetingCard(2);
           bday.From = "Nancy";
           bday.To = "Jose";
           bday.Occasion = "Birthday";
           bday.Greeting = "Happy belated Birthday!";
           Console.WriteLine(bday);
        }
    }

    class GreetingCard
    {
        private int number;
        public GreetingCard(int number)
        {
            this.number = number;
        }
        public String From { get; set;}
        public String To { get; set;}
        public String Occasion { get; set;}
        public String Greeting { get; set;}

        public override String ToString()
        {
            String card = $"card {number}\n";
            card += $"From: {From}\n";
            card += $"To: {To}\n";
            card += $"Occassion: {Occasion}\n";
            card += $"Greeting: {Greeting}\n";
            return card;
        }
    }
}
