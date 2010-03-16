using System;

namespace ObserverPattern.Framework
{
    /// <summary>
    /// Implements IConsultant
    /// </summary>
    public class Consultant : IConsultant
    {
        #region Properties

        public string Name { get; protected set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructs a consultant with the given name
        /// </summary>
        /// <param name="name"></param>
        public Consultant(string name)
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
            Console.WriteLine("{0} is notified that Sully is at {1} and gets back to coding.", Name, sullysLocation);
        }

        #endregion
    }
}
