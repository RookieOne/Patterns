using FactoryPattern.Framework;

namespace FactoryPattern.NoFactory
{
    public class CoffeeStore
    { 
        public IBeverage GetCoffee(StoreType storeType, BeverageType beverageType)
        {
            IBeverage coffee = null;

            switch(storeType)
            {
                case StoreType.RegularStore :

                    switch (beverageType)
                    {
                        case BeverageType.HouseBlend:
                            coffee = new HouseBlend();
                            break;

                        case BeverageType.Roast:
                            coffee = new DarkRoast();
                            break;
                    }
                    break;

                case StoreType.ExoticStore:

                    switch (beverageType)
                    {
                        case BeverageType.HouseBlend:
                            coffee = new SpecialHouseBlend();
                            break;

                        case BeverageType.Roast:
                            coffee = new AmazonRoast();
                            break;
                    }
                    break;
            }

            return coffee;
        }
    }
}
