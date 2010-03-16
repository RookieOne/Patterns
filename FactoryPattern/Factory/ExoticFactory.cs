using FactoryPattern.Framework;

namespace FactoryPattern.Factory
{
    /// <summary>
    /// Coffee Factory for Exotic Store
    /// </summary>
    public class ExoticFactory : IFactory
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
                    coffee = new SpecialHouseBlend();
                    break;

                case BeverageType.Roast:
                    coffee = new AmazonRoast();
                    break;
            }

            return coffee;
        }

        #endregion
    }
}
