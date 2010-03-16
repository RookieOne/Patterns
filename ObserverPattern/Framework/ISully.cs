
namespace ObserverPattern.Framework
{
    /// <summary>
    /// Interface for Sully
    /// </summary>
    public interface ISully
    {
        #region Observer Pattern (Subject) Methods

        /// <summary>
        /// Add Observer to collection to be notified
        /// </summary>
        /// <param name="observer"></param>
        void AddObserver(ISullyObserver observer);

        /// <summary>
        /// Remove Observer remove collection to be notified
        /// </summary>
        /// <param name="observer"></param>
        void RemoveObserver(ISullyObserver observer);

        /// <summary>
        /// Notify Observers
        /// </summary>
        void NotifyObservers();

        #endregion
    }
}
