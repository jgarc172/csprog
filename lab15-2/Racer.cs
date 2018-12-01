using System;

namespace lab15_2
{
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
