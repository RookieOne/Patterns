using System;

namespace CommandPattern.Framework
{
    /// <summary>
    /// A Coffee Grinder is an appliance and can be turned on and off
    /// </summary>
    public class CoffeeGrinder : IAppliance
    {
        #region IApplication Members

        /// <summary>
        /// Turns the appliance on.
        /// </summary>
        public void TurnOn()
        {
            Console.WriteLine("Coffee Grinder turned on.");
        }

        /// <summary>
        /// Turns the appliance off.
        /// </summary>
        public void TurnOff()
        {
            Console.WriteLine("Coffee Grinder turned off.");
        }

        #endregion
    }
}
