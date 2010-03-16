using FactoryPattern.Framework;

namespace FactoryPattern.Factory
{
    /// <summary>
    /// Interface for a Coffee Factory
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// Get Coffee given the Beverage Type
        /// Is Factory Method
        /// </summary>
        /// <param name="beverageType"></param>
        /// <returns></returns>
        IBeverage GetCoffee(BeverageType beverageType);
    }
}
