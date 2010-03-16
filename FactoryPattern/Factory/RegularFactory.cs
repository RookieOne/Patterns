using FactoryPattern.Framework;

namespace FactoryPattern.Factory
{
    /// <summary>
    /// Coffee Factory for Regular Store
    /// </summary>
    public class RegularFactory : IFactory
    {
        #region IFactory Members

        /// <summary>
        /// Get Coffee given the Beverage Type
        /// Is Factory Method
        /// </summary>
        /// <param name="beverageType"></param>
        /// <returns></returns>
        public IBeverage GetCoffee(BeverageType beverageType)
        {
            IBeverage coffee = null;

            switch (beverageType)
            {
                case BeverageType.HouseBlend:
                    coffee = new HouseBlend();
                    break;

                case BeverageType.Roast:
                    coffee = new DarkRoast();
                    break;
            }

            return coffee;
        }

        #endregion
    }
}