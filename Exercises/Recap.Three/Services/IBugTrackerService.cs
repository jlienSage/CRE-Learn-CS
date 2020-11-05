using System.Collections.Generic;
using Recap.Three.Models;

namespace Recap.Three.Services
{
    /// <summary>
    /// Bug tracker service interface.
    /// </summary>
    public interface IBugTrackerService
    {
        /// <summary>
        /// The total number of reported bugs.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Gets all bugs.
        /// </summary>
        ICollection<Bug> GetBugs();

        /// <summary>
        /// Get a specifice bug.
        /// </summary>
        Bug GetBug(int id);

        /// <summary>
        /// Add a new bug.
        /// </summary>
        int AddBug(Bug bug);

        /// <summary>
        /// Update an existing bug.
        /// </summary>
        Bug UpdateBug(Bug bug);

        /// <summary>
        /// Remove a bug.
        /// </summary>
        bool RemoveBug(int id);
    }
}
