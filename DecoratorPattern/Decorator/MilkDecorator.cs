using DecoratorPattern.Framework;

namespace DecoratorPattern.Decorator
{
    /// <summary>
    /// Milk Decorator
    /// </summary>
    public class MilkDecorator : IBeverage
    {
        #region Properties

        private IBeverage DecoratedBeverage { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor for Milk Decorator
        /// </summary>
        /// <param name="beverage"></param>
        public MilkDecorator(IBeverage beverage)
        {
            DecoratedBeverage = beverage;
        }

        #endregion

        #region IBeverage Members

        /// <summary>
        /// Get Description and add With Milk
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            return DecoratedBeverage.GetDescription() + " with Milk";
        }

        /// <summary>
        /// Get Price and add price for Milk
        /// </summary>
        /// <returns></returns>
        public double GetPrice()
        {
            return DecoratedBeverage.GetPrice() + .5d;
        }

        #endregion
    }
}
