using System;

namespace CommandPattern.Framework
{
    /// <summary>
    /// A Coffee Maker is an appliance and can be turned on and off
    /// </summary>
    public class CoffeeMaker : IAppliance
    {
        #region IApplication Members

        /// <summary>
        /// Turns the appliance on.
        /// </summary>
        public void TurnOn()
        {
            Console.WriteLine("Coffee Maker turned on.");
        }

        /// <summary>
        /// Turns the appliance off.
        /// </summary>
        public void TurnOff()
        {
            Console.WriteLine("Coffee Maker turned off.");
        }

        #endregion
    }
}
