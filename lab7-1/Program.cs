﻿using System;

namespace lab7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Association Relationship
            Manager CEO = new Manager();
            SwipeCard entry = new SwipeCard();
            CEO.Logon(entry);

            //Aggregation Relationship
            Worker NewHire = new Worker();
            NewHire.WorkerName = "Laura Croft";
            CEO.Workers[0] = NewHire;
            Console.WriteLine("worker {0}", CEO.Workers[0].WorkerName);

            //Composition Relationship
            CEO.HowisTheManager(true);
            Console.WriteLine(CEO.Salary);

        }
    }
    class Project
    {
        private Manager mgr;
        private bool IsSuccess = false;
        public Project(Manager mgr)
        {
            this.mgr = mgr;
        }
        public bool Issuccess
        {
            get { return IsSuccess; }
            set
            {
                IsSuccess = value;
                if (IsSuccess)
                {
                    this.mgr.Salary++;
                }else
                {
                    this.mgr.Salary--;
                }
            }
        }
    }
    class Worker
    {
        public string WorkerName { set; get; }
    }
    class Manager
    {
        public Project project;
        public Worker[] Workers = new Worker[10];
        public double Salary { get; set; }
        public Manager()
        {
            project = new Project(this);
        }
        public void Logon(SwipeCard card)
        {
            card.Swipe(this);
        }
        public string GetManagerName()
        {
            return "Boss";
        }
        public void HowisTheManager(bool good)
        {
            this.project.Issuccess = good;
        }
    }
    class SwipeCard
    {
        public void Swipe(Manager mgr)
        {
            Console.WriteLine("Welcome to XYZ, ");
            Console.WriteLine(mgr.GetManagerName());
        }
    }
}
