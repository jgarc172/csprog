using System;

namespace employee
{
    class Program
    {
        static public void Main(string[] args)
        {
            string name = "John Smith";
            string ssn = "444-56-7777";
            hourlyEmp newHire = new hourlyEmp(ref name, ref ssn, 65.50, 3);
            newHire.setHours(45.45);
            Console.WriteLine("New Employee: \n" + newHire.getName() + "\n" +
               newHire.getSsn() + "\n" + "Hours: " + newHire.getHours());
            newHire.giveRaise(3.2);
            newHire.setHours(40.0);
            newHire.printCheck();

            Console.WriteLine("Employee Object");
            employee abc = new employee(ref name, ref ssn);
            Console.WriteLine(abc.getName());

            Console.WriteLine();
            Administrator adm = new Administrator();
            Console.WriteLine();
            adm.print();
            Console.WriteLine();
            adm.printCheck();
            Console.ReadLine();

        }
    }
    public interface IEmployee
    {
        void printCheck();
    }
    class employee : IEmployee
    {  //base class parent class 
        protected string name;
        protected string ssn;
        protected double netPay;
        public employee()
        {
            netPay = 0;
        }

        public employee(ref string newName, ref string newSsn)
        {
            name = newName;
            ssn = newSsn;
            netPay = 0;
        }

        public void changeName(ref string newName)
        {
            name = newName;
        }

        public void changeSsn(ref string newSsn)
        {
            ssn = newSsn;
        }

        public string getName()
        {
            return name;
        }

        public string getSsn()
        {
            return ssn;
        }
        public virtual void printCheck()
        {
            Console.WriteLine("Paycheck");
        }
    }
    class hourlyEmp : employee, IEmployee  //derived class child class
    {

        private double hours;
        private double payRate;
        public void setHours(double newHours)
        {
            this.hours = newHours;


            //this.setHours(newHours);
            this.netPay = this.payRate * this.hours;
        }

        public void giveRaise(double amount)
        {
            this.payRate += amount;
            this.netPay = this.payRate * hours;
        }

        public double getHours()
        {
            return this.hours;
        }

        public override void printCheck()
        {
            base.printCheck();
            Console.WriteLine("Pay " + this.name + " the sum of " + this.netPay + " Dollars.");
            Console.WriteLine("Check Stub: ");
            Console.WriteLine("Employee number: " + this.ssn);
            Console.WriteLine("This is an hourly employee.  Hours worked: " + this.hours);
            Console.WriteLine("Rate: " + this.payRate + "    Pay: " + this.netPay);
        }

        public hourlyEmp()
        {
            this.payRate = 0;
            this.hours = 0;
        }

        public hourlyEmp(ref string newName,
                             ref string newSsn,
                             double newPayRate,
                             double newHours)
            : base(ref newName, ref newSsn)

        {
            this.payRate = newPayRate;
            this.hours = newHours;
            this.netPay = this.hours * this.payRate;
        }

    }


    class salariedEmp : employee, IEmployee
    {
        protected double salary;
        public void giveRaise(double amount)
        {
            salary += amount;
            netPay += amount;
        }

        public salariedEmp()
        {
            salary = 0;
            netPay = 0;
        }

        public salariedEmp(ref string newName,
                             ref string newSsn,
                             double newWeeklySalary)

                : base(ref newName, ref newSsn)


        {
            salary = newWeeklySalary;
            netPay = salary;
        }


        public override void printCheck()
        {
            base.printCheck();
            Console.WriteLine("Pay " + this.name + " the sum of " + this.netPay + " Dollars.");
            Console.WriteLine("Check Stub: ");
            Console.WriteLine("Employee number: " + this.ssn);
            Console.WriteLine("This is a salaried employee.  Regular pay: ");
            Console.WriteLine(this.salary);
        }
    }
    class Administrator : employee, IEmployee
    {  //base class parent class 
        private string title;
        private string responsibility;
        private string supervisor;
        public void changeSupervisor(string newSupervisor)
        {
            supervisor = newSupervisor;
        }
        public Administrator()
        {
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("SSN: ");
            ssn = Console.ReadLine();
            //base(name, ssn);
            Console.Write("Title: ");
            title = Console.ReadLine();
            Console.Write("Area of Responsibility: ");
            responsibility = Console.ReadLine();
            Console.Write("Supervisor's name: ");
            supervisor = Console.ReadLine();
            Console.Write("Net Pay: ");
            netPay = Convert.ToDouble(Console.ReadLine());
        }
        public void print()
        {
            Console.WriteLine("Administrator's data:");
            Console.WriteLine($"Name: {name} \nTitle: {title} \nArea: {responsibility} \nSupervisor: {supervisor}");
        }


        public override void printCheck()
        {
            base.printCheck();
            Console.WriteLine("Pay " + this.name + " the sum of " + this.netPay + " Dollars.");
            Console.WriteLine("Check Stub: ");
            Console.WriteLine("Employee number: " + this.ssn);
            Console.WriteLine("This is an Administrator.  Regular pay: ");
            Console.WriteLine(this.netPay);
        }
    }

}
