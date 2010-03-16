
namespace DecoratorPattern.Framework
{
    /// <summary>
    /// Implements IBeverage
    /// </summary>
    public class HouseBlend : IBeverage
    {
        #region IBeverage Members

        /// <summary>
        /// Get Description
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            return "House Blend";
        }

        /// <summary>
        /// Get Price
        /// </summary>
        /// <returns></returns>
        public double GetPrice()
        {
            return 5d;
        }

        #endregion
    }
}
