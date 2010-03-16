using System;

namespace TemplatePattern.Framework
{
    /// <summary>
    /// House Blend Coffee
    /// </summary>
    public class HouseBlend : Beverage
    {
        #region Add Coffee Grinds and Add Condiments

        /// <summary>
        /// Add Coffee Grinds
        /// </summary>
        protected override void AddCoffeeGrinds()
        {
            Console.WriteLine("Add House Blend Coffee Grinds");
        }

        /// <summary>
        /// Add Condiments
        /// </summary>
        protected override void AddCondiments()
        {
            Console.WriteLine("Add Milk and Sugar");
        }

        #endregion
    }
}
