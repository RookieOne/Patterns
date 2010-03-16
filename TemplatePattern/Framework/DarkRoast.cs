using System;

namespace TemplatePattern.Framework
{
    /// <summary>
    /// Dark Roast
    /// </summary>
    public class DarkRoast : Beverage
    {
        #region Add Coffee Grinds and Add Condiments

        /// <summary>
        /// Add Coffee Grinds
        /// </summary>
        protected override void AddCoffeeGrinds()
        {
            Console.WriteLine("Add Dark Roast Grinds");
        }

        /// <summary>
        /// Add Condiments
        /// </summary>
        protected override void AddCondiments()
        {
            Console.WriteLine("Add Sugar");
        }

        #endregion
    }
}
