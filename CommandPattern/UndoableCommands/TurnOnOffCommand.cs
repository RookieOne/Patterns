using CommandPattern.Framework;

namespace CommandPattern.UndoableCommands
{
    /// <summary>
    /// Turn On Off Command turns an application on for execution and on undo turns the 
    /// application off
    /// </summary>
    public class TurnOnOffCommand : IUndoableCommand
    {
        #region Properties

        private IAppliance Appliance { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnOnOffCommand"/> class.
        /// </summary>
        /// <param name="appliance">The appliance.</param>
        public TurnOnOffCommand(IAppliance appliance)
        {
            Appliance = appliance;
        }

        #endregion

        #region Execute / Undo Methods

        /// <summary>
        /// Executes the command by turning the appliance on
        /// </summary>
        public void Execute()
        {
            Appliance.TurnOn();
        }

        /// <summary>
        /// Undoes the command execution by turning the appliance off
        /// </summary>
        public void Undo()
        {
            Appliance.TurnOff();
        }

        #endregion
    }
}
