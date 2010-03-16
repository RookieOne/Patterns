using CommandPattern.Framework;

namespace CommandPattern.Commands
{
    /// <summary>
    /// Lights Off Command turns the lights off in a store
    /// </summary>
    public class LightsOffCommand : ICommand
    {
        #region Properties

        private IStore Store { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="LightsOffCommand"/> class.
        /// </summary>
        /// <param name="store">The store.</param>
        public LightsOffCommand(IStore store)
        {
            Store = store;
        }

        #endregion
        
        #region Execute

        /// <summary>
        /// Executes this command by calling TurnOffLights on Store
        /// </summary>
        public void Execute()
        {
            Store.TurnOffLights();
        }

        #endregion
    }
}