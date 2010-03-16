
namespace ObserverPattern.Framework
{
    /// <summary>
    /// Interface for Sully Observer
    /// </summary>
    public interface ISullyObserver
    {
        #region Update

        /// <summary>
        /// Gets called by Sully when location has changed and observer needs to be notified
        /// </summary>
        /// <param name="sullysLocation"></param>
        void Update(string sullysLocation);

        #endregion
    }
}
