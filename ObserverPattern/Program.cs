using System;
using ObserverPattern.Framework;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var sully = new Sully();
            
            sully.SetLocation("Catapult Office");

            var landon = new ProjectManager("Landon");
            var david = new Consultant("David");
            var john = new Consultant("John");

            Console.ReadLine();

            sully.AddObserver(landon);
            sully.AddObserver(david);
            sully.AddObserver(john);

            sully.SetLocation("Starbucks");

            Console.ReadLine();

            sully.RemoveObserver(david);

            sully.SetLocation("Catalina");

            Console.ReadLine();

            sully.RemoveObserver(john);
            
            var greg = new Consultant("Greg");

            sully.AddObserver(greg);

            sully.SetLocation("It's a Grind");

            Console.ReadLine();
        }
    }
}
