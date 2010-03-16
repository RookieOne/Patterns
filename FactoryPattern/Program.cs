using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactoryPattern.Factory;
using FactoryPattern.Framework;
using FactoryPattern.NoFactory;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseNonFactory();

            UseFactory();           
        }

        private static void UseNonFactory()
        {
            var store = new CoffeeStore();

            IBeverage coffee = null;

            coffee = store.GetCoffee(StoreType.RegularStore, BeverageType.HouseBlend);
            
            Console.WriteLine("{0} made with a price of {1}", coffee.GetDescription(), coffee.GetPrice());
            Console.ReadLine();

            coffee = store.GetCoffee(StoreType.RegularStore, BeverageType.Roast);

            Console.WriteLine("{0} made with a price of {1}", coffee.GetDescription(), coffee.GetPrice());
            Console.ReadLine();

            coffee = store.GetCoffee(StoreType.ExoticStore, BeverageType.HouseBlend);

            Console.WriteLine("{0} made with a price of {1}", coffee.GetDescription(), coffee.GetPrice());
            Console.ReadLine();

            coffee = store.GetCoffee(StoreType.ExoticStore, BeverageType.Roast);

            Console.WriteLine("{0} made with a price of {1}", coffee.GetDescription(), coffee.GetPrice());
            Console.ReadLine();
        }

        private static void UseFactory()
        {
            var store = new CoffeeStoreWithFactory();

            IBeverage coffee = null;

            store.Factory = new RegularFactory();

            coffee = store.GetCoffee(BeverageType.HouseBlend);

            Console.WriteLine("{0} made with a price of {1}", coffee.GetDescription(), coffee.GetPrice());
            Console.ReadLine();

            coffee = store.GetCoffee(BeverageType.Roast);

            Console.WriteLine("{0} made with a price of {1}", coffee.GetDescription(), coffee.GetPrice());
            Console.ReadLine();

            store.Factory = new ExoticFactory();

            coffee = store.GetCoffee(BeverageType.HouseBlend);

            Console.WriteLine("{0} made with a price of {1}", coffee.GetDescription(), coffee.GetPrice());
            Console.ReadLine();

            coffee = store.GetCoffee(BeverageType.Roast);

            Console.WriteLine("{0} made with a price of {1}", coffee.GetDescription(), coffee.GetPrice());
            Console.ReadLine();
        }
    }
}
