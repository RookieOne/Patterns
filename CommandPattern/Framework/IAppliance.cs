
namespace CommandPattern.Framework
{
    /// <summary>
    /// An IAppliance can be turned on and off
    /// </summary>
    public interface IAppliance    
    {
        /// <summary>
        /// Turns the appliance on.
        /// </summary>
        void TurnOn();

        /// <summary>
        /// Turns the appliance off.
        /// </summary>
        void TurnOff();
    }
}
