using CommandPattern.Framework;

namespace CommandPattern.Commands
{
    /// <summary>
    /// Turn Off Command turns an appliance off
    /// </summary>
    public class TurnOffCommand : ICommand
    {
        #region Properties

        private IAppliance Appliance { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnOffCommand"/> class.
        /// </summary>
        /// <param name="appliance">The appliance.</param>
        public TurnOffCommand(IAppliance appliance)
        {
            Appliance = appliance;
        }

        #endregion

        #region Execute

        /// <summary>
        /// Executes this command by turning the Appliance off
        /// </summary>
        public void Execute()
        {
            Appliance.TurnOff();
        }

        #endregion
    }
}
