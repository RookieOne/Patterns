using System;

namespace CommandPattern.Framework
{
    /// <summary>
    /// Abstract base class for a store
    /// Provides implementation for all methods except open and close store
    /// </summary>
    public abstract class Store : IStore
    {
        #region Properties

        /// <summary>
        /// Gets a value indicating whether [lights on].
        /// </summary>
        /// <value><c>true</c> if [lights on]; otherwise, <c>false</c>.</value>
        public bool LightsOn { get; private set; }

        /// <summary>
        /// Gets the current temp.
        /// </summary>
        /// <value>The current temp.</value>
        public double CurrentTemp { get; private set; }

        #endregion

        #region Turn On / Off Lights

        /// <summary>
        /// Turns the lights on.
        /// </summary>
        public void TurnOnLights()
        {
            LightsOn = true;
            Console.WriteLine("Store lights turned on.");
        }

        /// <summary>
        /// Turns the lights off.
        /// </summary>
        public void TurnOffLights()
        {
            LightsOn = false;
            Console.WriteLine("Store lights turned off.");
        }

        #endregion

        #region Set Ac

        /// <summary>
        /// Sets the AC (current temp).
        /// </summary>
        /// <param name="temp">The temp.</param>
        public void SetAC(double temp)
        {
            CurrentTemp = temp;
            Console.WriteLine("Set AC to {0}", temp);
        }

        #endregion

        #region Open / Close Store

        /// <summary>
        /// Opens the store.
        /// </summary>
        public abstract void OpenStore();

        /// <summary>
        /// Closes the store.
        /// </summary>
        public abstract void CloseStore();

        #endregion
    }
}
