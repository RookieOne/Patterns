using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern.Framework
{
    /// <summary>
    /// Interface for a Store.
    /// A store has Lights and a Temperature set by AC
    /// A store can be opened and closed
    /// </summary>
    public interface IStore
    {
        /// <summary>
        /// Gets a value indicating whether [lights on].
        /// </summary>
        /// <value><c>true</c> if [lights on]; otherwise, <c>false</c>.</value>
        bool LightsOn { get; }

        /// <summary>
        /// Gets the current temp.
        /// </summary>
        /// <value>The current temp.</value>
        double CurrentTemp { get; }

        /// <summary>
        /// Turns the lights on.
        /// </summary>
        void TurnOnLights();

        /// <summary>
        /// Turns the lights off.
        /// </summary>
        void TurnOffLights();

        /// <summary>
        /// Sets the AC (current temp).
        /// </summary>
        /// <param name="temp">The temp.</param>
        void SetAC(double temp);

        /// <summary>
        /// Opens the store.
        /// </summary>
        void OpenStore();

        /// <summary>
        /// Closes the store.
        /// </summary>
        void CloseStore();        
    }
}
