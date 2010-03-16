using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandPattern.Framework;

namespace CommandPattern.UndoableCommands
{
    /// <summary>
    /// Lights Command turns the Store's lights on and then in the undo turns the lights off
    /// </summary>
    public class LightsCommand : IUndoableCommand
    {
        #region Properties

        private IStore Store { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="LightsCommand"/> class.
        /// </summary>
        /// <param name="store">The store.</param>
        public LightsCommand(IStore store)
        {
            Store = store;
        }

        #endregion

        #region Execute / Undo Methods

        /// <summary>
        /// Turns the Store's lights on        
        /// </summary>
        public void Execute()
        {
            Store.TurnOnLights();
        }

        /// <summary>
        /// Turns the Store's lights off
        /// </summary>
        public void Undo()
        {
           Store.TurnOffLights();
        }

        #endregion
    }
}
