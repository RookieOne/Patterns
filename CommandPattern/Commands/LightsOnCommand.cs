using CommandPattern.Framework;

namespace CommandPattern.Commands
{
    /// <summary>
    /// Lights On Command turns the lights on in a store
    /// </summary>
    public class LightsOnCommand : ICommand
    {
        #region Properties

        private IStore Store { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="LightsOnCommand"/> class.
        /// </summary>
        /// <param name="store">The store.</param>
        public LightsOnCommand(IStore store)
        {
            Store = store;
        }

        #endregion

        #region Execute

        /// <summary>
        /// Executes this command by calling TurnOnLights on Store
        /// </summary>
        public void Execute()
        {
            Store.TurnOnLights();
        }

        #endregion
    }
}
