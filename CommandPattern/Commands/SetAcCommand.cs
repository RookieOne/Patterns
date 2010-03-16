using CommandPattern.Framework;

namespace CommandPattern.Commands
{
    /// <summary>
    /// Set Ac Command sets the Ac in a store
    /// </summary>
    public class SetAcCommand : ICommand
    {   
        #region Properties

        private IStore Store { get; set; }
        private double Temp { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SetAcCommand"/> class.
        /// </summary>
        /// <param name="store">The store.</param>
        /// <param name="temp">The temp.</param>
        public SetAcCommand(IStore store, double temp)
        {
            Store = store;
            Temp = temp;
        }

        #endregion

        #region Execute

        /// <summary>
        /// Executes this command by setting the Ac on the Store
        /// </summary>
        public void Execute()
        {
            Store.SetAC(Temp);
        }

        #endregion
    }
}