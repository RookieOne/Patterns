
namespace CommandPattern.UndoableCommands
{
    /// <summary>
    /// Inteface for UndoableCommand
    /// </summary>
    public interface IUndoableCommand
    {
        /// <summary>
        /// Executes the command.
        /// </summary>
        void Execute();

        /// <summary>
        /// Undoes the command execution.
        /// </summary>
        void Undo();
    }
}
