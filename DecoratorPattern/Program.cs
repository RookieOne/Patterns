using System;
using DecoratorPattern.Decorator;
using DecoratorPattern.Framework;
using DecoratorPattern.NoDecoratorFramework;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //NoDecorator();

            WithDecorator();
        }

        private static void NoDecorator()
        {
            var roast = new DarkRoastNoDecorator();

            Console.WriteLine("{0} cost {1}", roast.GetDescription(), roast.GetPrice());
            Console.ReadLine();

            roast.AddMilk();

            Console.WriteLine("{0} cost {1}", roast.GetDescription(), roast.GetPrice());
            Console.ReadLine();

            roast.AddSugar();

            Console.WriteLine("{0} cost {1}", roast.GetDescription(), roast.GetPrice());
            Console.ReadLine();

            var house = new HouseBlendNoDecorator();
            house.AddMilk();

            Console.WriteLine("{0} cost {1}", house.GetDescription(), house.GetPrice());
            Console.ReadLine();
        }

        private static void WithDecorator()
        {
            IBeverage roast = new DarkRoast();

            Console.WriteLine("{0} cost {1}", roast.GetDescription(), roast.GetPrice());
            Console.ReadLine();

            roast = new MilkDecorator(roast);

            Console.WriteLine("{0} cost {1}", roast.GetDescription(), roast.GetPrice());
            Console.ReadLine();

            roast = new SugarDecorator(roast);

            Console.WriteLine("{0} cost {1}", roast.GetDescription(), roast.GetPrice());
            Console.ReadLine();

            IBeverage house = new HouseBlend();

            house = new MilkDecorator(house);

            Console.WriteLine("{0} cost {1}", house.GetDescription(), house.GetPrice());
            Console.ReadLine();
        }

    }
}
