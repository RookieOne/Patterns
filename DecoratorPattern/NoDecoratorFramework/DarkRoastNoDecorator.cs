
namespace DecoratorPattern.NoDecoratorFramework
{
    /// <summary>
    /// Implements IBeverage
    /// </summary>
    public class DarkRoastNoDecorator : NoDecoratorBeverage
    {
        #region Original IBeverage Members

        /// <summary>
        /// Get Description
        /// </summary>
        /// <returns></returns>
        public override string GetDescription()
        {
            return "Dark Roast" + GetCondimentDescription();
        }

        /// <summary>
        /// Get Price
        /// </summary>
        /// <returns></returns>
        public override double GetPrice()
        {
            return 7d + GetCondimentPrice();
        }

        #endregion


    }
}
