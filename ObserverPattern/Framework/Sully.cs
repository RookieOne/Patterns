using System;
using System.Collections.Generic;

namespace ObserverPattern.Framework
{
    /// <summary>
    /// Implements ISully
    /// </summary>
    public class Sully : ISully
    {
        #region Properties

        private List<ISullyObserver> Observers { get; set; }
        private string CurrentLocation { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor for Sully. Intialize Observers Collection
        /// </summary>
        public Sully()
        {
            Observers = new List<ISullyObserver>();
        }

        #endregion

        #region Set Location

        /// <summary>
        /// Set Location and Notify Observers
        /// </summary>
        /// <param name="location"></param>
        public void SetLocation(string location)
        {
            Console.WriteLine("Sully is now at {0}", location);
            CurrentLocation = location;
            NotifyObservers();
        }

        #endregion

        #region Observer Pattern (Subject) Methods

        /// <summary>
        /// Add Observer to collection to be notified
        /// </summary>
        /// <param name="observer"></param>
        public void AddObserver(ISullyObserver observer)
        {
            Observers.Add(observer);
        }

        /// <summary>
        /// Remove Observer remove collection to be notified
        /// </summary>
        /// <param name="observer"></param>
        public void RemoveObserver(ISullyObserver observer)
        {
            Observers.Remove(observer);
        }

        /// <summary>
        /// Notify Observers
        /// </summary>
        public void NotifyObservers()
        {
            foreach(ISullyObserver observer in Observers)
                observer.Update(CurrentLocation);
        }

        #endregion
    }
}
