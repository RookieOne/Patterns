
namespace DecoratorPattern.Framework
{
    /// <summary>
    /// Implements IBeverage
    /// </summary>
    public class DarkRoast : IBeverage
    {
        #region IBeverage Members

        /// <summary>
        /// Get Description
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            return "Dark Roast";
        }

        /// <summary>
        /// Get Price
        /// </summary>
        /// <returns></returns>
        public double GetPrice()
        {
            return 7d;
        }

        #endregion
    }
}
