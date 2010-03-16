using System.Collections.Generic;
using CommandPattern.UndoableCommands;

namespace CommandPattern.UndoableCommands
{
    /// <summary>
    /// The MacroCommand packages IUndoableCommands and executes / undoes the commands in bulge
    /// </summary>
    public class MacroCommand : IUndoableCommand
    {
        #region Properties

        private List<IUndoableCommand> Commands { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="MacroCommand"/> class.
        /// </summary>
        public MacroCommand()
        {
            Commands = new List<IUndoableCommand>();
        }

        #endregion

        #region Add Command

        /// <summary>
        /// Adds the command to macro.
        /// </summary>
        /// <param name="command">The command.</param>
        public void AddCommand(IUndoableCommand command)
        {
            Commands.Add(command);
        }

        #endregion

        #region Execute / Undo Methods

        /// <summary>
        /// Executes all the commands.
        /// </summary>
        public void Execute()
        {
            foreach(IUndoableCommand command in Commands)
                command.Execute();
        }

        /// <summary>
        /// Calls undo on all the commands.
        /// </summary>
        public void  Undo()
        {
            foreach (IUndoableCommand command in Commands)
                command.Undo();
        }

        #endregion
}
}
