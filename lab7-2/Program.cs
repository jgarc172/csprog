using System;

namespace lab7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager CEO = new Manager();
            Worker NewHire = new Worker();
            NewHire.WorkerName = "Laura Croft";
            CEO.Workers[0] = NewHire;
        }
    }
    class Manager
    {
        public Worker[] Workers = new Worker[10];

    }
    class Worker
    {
        public string WorkerName {get; set;}
    }
}
