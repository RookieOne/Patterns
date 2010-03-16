
namespace DecoratorPattern.NoDecoratorFramework
{
    /// <summary>
    /// Implements IBeverage
    /// </summary>
    public class HouseBlendNoDecorator : NoDecoratorBeverage
    {
        #region IBeverage Members

        /// <summary>
        /// Get Description
        /// </summary>
        /// <returns></returns>
        public override string GetDescription()
        {
            return "House Blend" + GetCondimentDescription();
        }

        /// <summary>
        /// Get Price
        /// </summary>
        /// <returns></returns>
        public override double GetPrice()
        {
            return 5d + GetCondimentPrice();
        }

        #endregion
    }
}
