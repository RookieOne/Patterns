using CommandPattern.Framework;

namespace CommandPattern.Commands
{
    /// <summary>
    /// Turn On Command turns an appliance on
    /// </summary>
    public class TurnOnCommand : ICommand
    {
        #region Properties

        private IAppliance Appliance { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnOnCommand"/> class.
        /// </summary>
        /// <param name="appliance">The appliance.</param>
        public TurnOnCommand(IAppliance appliance)
        {
            Appliance = appliance;
        }

        #endregion

        #region Execute

        /// <summary>
        /// Executes this command by turning the Appliance on
        /// </summary>
        public void Execute()
        {
            Appliance.TurnOn();
        }

        #endregion
    }
}
