using System;

namespace TemplatePattern.Framework
{
    /// <summary>
    /// Implements IBeverage
    /// </summary>
    public abstract class Beverage : IBeverage
    {
        #region Prepare

        /// <summary>
        /// Prepare Beverage. Method on IBeverage.
        /// Is a Template Method
        /// </summary>
        public void Prepare()
        {
            BoilWater();
            AddCoffeeGrinds();
            PourIntoCup();
            AddCondiments();
        }

        #endregion

        #region Abstract Methods

        protected abstract void AddCoffeeGrinds();
        protected abstract void AddCondiments();

        #endregion

        #region Boil Water and Pour Into Cup

        /// <summary>
        /// Boil Water
        /// </summary>
        private void BoilWater()
        {
            Console.WriteLine("Boil water");
        }

        /// <summary>
        /// Pour Into Cup
        /// </summary>
        private void PourIntoCup()
        {
            Console.WriteLine("Pour into cup");
        }

        #endregion
    }
}
