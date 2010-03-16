using FactoryPattern.Framework;

namespace FactoryPattern.Factory
{
    /// <summary>
    /// Coffee Store that utilizes a Factory to get the correct coffee
    /// </summary>
    public class CoffeeStoreWithFactory
    {
        #region Properties

        public IFactory Factory { get; set; }

        #endregion

        #region Get Coffee

        /// <summary>
        /// Get Coffee given beverage type
        /// </summary>
        /// <param name="beverageType"></param>
        /// <returns></returns>
        public IBeverage GetCoffee(BeverageType beverageType)
        {
            if (Factory == null)
                return null;

            return Factory.GetCoffee(beverageType);
        }

        #endregion
    }
}
