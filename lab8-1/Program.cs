using System;

namespace lab8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John Smith";
            string ssn = "444-56-7777";
            HourlyEmp newHire = new HourlyEmp(ref name, ref ssn, 65.50, 3);
            newHire.setHours(45.45);
            Console.Write($"New Employee: {newHire.getName()} \n {newHire.getSsn()} \n Hours: {newHire.getHours()} \n");
            newHire.giveRaise(3.2);
            newHire.setHours(40.0);
            newHire.printCheck();

            Console.WriteLine("Employee Object");
            Employee abc = new Employee(ref name, ref ssn);
            Console.WriteLine(abc.getName());

        }
    }
    public class Employee
    {
        protected string name;
        protected string ssn;
        protected double netPay;
        public Employee(ref string newName, ref string newSSN)
        {
            this.name = newName;
            this.ssn = newSSN;
        }
        public string getName()
        {
            return this.name;
        }
        public string getSsn(){
            return this.ssn;
        }
        public void printCheck()
        {
            var check = $"Pay to: {this.name} \n";
            check += $"Amount: ${this.netPay} \n";
            Console.WriteLine(check);
        }
    }
    public class HourlyEmp : Employee
    {
        private double payRate;
        private double hours;
        public HourlyEmp(ref string newName,
                         ref string newSSN,
                         double newPayRate,
                         double newHours)
            : base(ref newName, ref newSSN)
        {
            this.payRate = newPayRate;
            this.hours = newHours;
            this.netPay = this.hours * this.payRate;
        }
        public void setHours(double newHours){
            this.hours = newHours;
        }
        public double getHours()
        {
            return this.hours;
        }
        public void giveRaise(double amount)
        {
            this.payRate += amount;
            this.netPay = this.payRate * hours;
        }
    }
}
