using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandPattern.Commands;
using CommandPattern.UndoableCommands;

namespace CommandPattern.Framework
{
    /// <summary>
    /// Upgraded Store uses Open Commands to open the store and then utilizes undo to close the store
    /// </summary>
    public class UpgradedStore : Store
    {
        #region Properties

        private List<IUndoableCommand> OpenCommands { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradedStore"/> class.
        /// </summary>
        public UpgradedStore()
        {
            OpenCommands = new List<IUndoableCommand>();
        }

        #endregion

        #region Add Open Command

        /// <summary>
        /// Adds an open command to the OpenCommands list
        /// </summary>
        /// <param name="command">The command.</param>
        public void AddOpenCommand(IUndoableCommand command)
        {
            OpenCommands.Add(command);
        }

        #endregion

        #region Open / Close Store

        /// <summary>
        /// Opens the store.
        /// </summary>
        public override void OpenStore()
        {
            foreach (IUndoableCommand command in OpenCommands)
                command.Execute();
        }

        /// <summary>
        /// Closes the store.
        /// </summary>
        public override void CloseStore()
        {
            foreach (IUndoableCommand command in OpenCommands)
                command.Undo();
        }

        #endregion
    }
}
