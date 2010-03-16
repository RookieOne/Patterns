using CommandPattern.Framework;

namespace CommandPattern.UndoableCommands
{
    /// <summary>
    /// Toggle Ac Command sets the AC on execution and restores the previous AC temp value
    /// on undo
    /// </summary>
    public class ToggleAcCommand : IUndoableCommand
    {
        #region Properties

        private IStore Store { get; set; }
        private double Temp { get; set; }
        private double PreviousTemp { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ToggleAcCommand"/> class.
        /// </summary>
        /// <param name="store">The store.</param>
        /// <param name="temp">The temp.</param>
        public ToggleAcCommand(IStore store, double temp)
        {
            Store = store;
            Temp = temp;
        }

        #endregion


        #region Execute / Undo Method

        /// <summary>
        /// Sets AC temp on Store
        /// </summary>
        public void Execute()
        {
            PreviousTemp = Store.CurrentTemp;
            Store.SetAC(Temp);
        }

        /// <summary>
        /// Restores previous AC temp
        /// </summary>
        public void Undo()
        {
            Store.SetAC(PreviousTemp);
        }

        #endregion
    }
}
