using System;

namespace ObserverPattern.Framework
{
    /// <summary>
    /// Project Manager implements IProjectManager
    /// </summary>
    public class ProjectManager : IProjectManager
    {
        #region Properties

        public string Name { get; protected set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructs a project manager with the given name
        /// </summary>
        /// <param name="name"></param>
        public ProjectManager(string name)
        {
            Name = name;
        }

        #endregion

        #region ISullyObserver Members

        /// <summary>
        /// Gets called by Sully when location has changed and observer needs to be notified
        /// </summary>
        /// <param name="sullysLocation"></param>
        public void Update(string sullysLocation)
        {
            Console.WriteLine("{0} is notified that Sully is at {1} and updates SharePoint.", Name, sullysLocation);
        }

        #endregion
    }
}
