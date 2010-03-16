using System;
using CommandPattern.Commands;
using CommandPattern.Framework;
using CommandPattern.UndoableCommands;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseRegularStore();
            UseUpgradedStore();
        }

        private static void UseRegularStore()
        {
            var store = new RegularStore();

            var coffeeGrinder = new CoffeeGrinder();
            var coffeeMaker = new CoffeeMaker();

            store.AddOpenCommand(new LightsOnCommand(store));
            store.AddOpenCommand(new SetAcCommand(store, 75d));
            store.AddOpenCommand(new TurnOnCommand(coffeeGrinder));
            store.AddOpenCommand(new TurnOnCommand(coffeeMaker));


            store.AddCloseCommand(new LightsOffCommand(store));
            store.AddCloseCommand(new SetAcCommand(store, 85d));
            store.AddCloseCommand(new TurnOffCommand(coffeeGrinder));
            store.AddCloseCommand(new TurnOffCommand(coffeeMaker));

            store.OpenStore();

            Console.ReadLine();

            store.CloseStore();

            Console.ReadLine();
        }

        private static void UseUpgradedStore()
        {
            var store = new UpgradedStore();
            store.SetAC(85);

            var coffeeGrinder = new CoffeeGrinder();
            var coffeeMaker = new CoffeeMaker();

            store.AddOpenCommand(new LightsCommand(store));
            store.AddOpenCommand(new ToggleAcCommand(store, 75d));

            var macro = new MacroCommand();
            macro.AddCommand(new TurnOnOffCommand(coffeeGrinder));
            macro.AddCommand(new TurnOnOffCommand(coffeeMaker));

            store.AddOpenCommand(macro);            

            store.OpenStore();

            Console.ReadLine();

            store.CloseStore();

            Console.ReadLine();
        }
    }
}
