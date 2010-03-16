namespace CommandPattern.Commands
{
    /// <summary>
    /// Interface for ICommand
    /// Details out a basic interface for a Command Pattern containing an Execute method
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Executes this command.
        /// </summary>
        void Execute();
    }
}