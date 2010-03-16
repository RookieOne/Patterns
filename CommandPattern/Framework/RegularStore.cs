using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandPattern.Commands;

namespace CommandPattern.Framework
{
    /// <summary>
    /// Regular Store uses Open and Close Commands to open and close the store
    /// </summary>
    public class RegularStore : Store
    {
        #region Properties

        private List<ICommand> OpenCommands { get; set; }
        private List<ICommand> CloseCommands { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="RegularStore"/> class.
        /// </summary>
        public RegularStore()
        {
            OpenCommands = new List<ICommand>();
            CloseCommands = new List<ICommand>();
        }

        #endregion

        #region Add Open and Add Close Commands

        /// <summary>
        /// Adds an open command (a command to execute upon opening the store)
        /// </summary>
        /// <param name="command">The command.</param>
        public void AddOpenCommand(ICommand command)
        {
            OpenCommands.Add(command);
        }

        /// <summary>
        /// Adds a close command (a command to execute upon closing the store)
        /// </summary>
        /// <param name="command">The command.</param>
        public void AddCloseCommand(ICommand command)
        {
            CloseCommands.Add(command);
        }

        #endregion

        #region Open / Close Store

        /// <summary>
        /// Opens the store.
        /// </summary>
        public override void OpenStore()
        {
            foreach(ICommand command in OpenCommands)
                command.Execute();
        }

        /// <summary>
        /// Closes the store.
        /// </summary>
        public override void CloseStore()
        {
            foreach (ICommand command in CloseCommands)
                command.Execute();
        }

        #endregion
    }
}
