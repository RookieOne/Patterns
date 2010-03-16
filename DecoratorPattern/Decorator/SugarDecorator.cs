using DecoratorPattern.Framework;

namespace DecoratorPattern.Decorator
{
    /// <summary>
    /// Sugar Decorator
    /// </summary>
    public class SugarDecorator : IBeverage
    {
        #region Properties

        private IBeverage DecoratedBeverage { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor for Sugar Decorator
        /// </summary>
        /// <param name="beverage"></param>
        public SugarDecorator(IBeverage beverage)
        {
            DecoratedBeverage = beverage;
        }

        #endregion

        #region IBeverage Members

        /// <summary>
        /// Get Description and add With Sugar
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            return DecoratedBeverage.GetDescription() + " with Sugar";
        }

        /// <summary>
        /// Get Price and add price for Sugar
        /// </summary>
        /// <returns></returns>
        public double GetPrice()
        {
            return DecoratedBeverage.GetPrice() + .2d;
        }

        #endregion
    }
}
