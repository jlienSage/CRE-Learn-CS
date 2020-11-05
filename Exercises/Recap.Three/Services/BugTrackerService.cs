using System.Collections.Generic;
using Recap.Three.Models;

namespace Recap.Three.Services
{
    public class BugTrackerService : IBugTrackerService
    {
        private readonly ICollection<Bug> _bugs = new List<Bug>();
        private int _lastId = 0;

        public int Count => _bugs.Count;

        public int AddBug(Bug bug)
        {
            bug.Id = ++_lastId;
            _bugs.Add(bug);
            return _lastId;
        }

        public Bug GetBug(int id)
        {
            return Find(id);
        }

        public ICollection<Bug> GetBugs()
        {
            return _bugs;
        }

        public bool RemoveBug(int id)
        {
            var bug = Find(id);            
            return bug == null ? false : _bugs.Remove(bug);
        }

        public Bug UpdateBug(Bug bug)
        {
            var existingBug = Find(bug.Id);
            if (existingBug == null)
                return null;

            existingBug.Description = bug.Description;
            existingBug.IsFixed = bug.IsFixed;
            return existingBug;
        }

        private Bug Find(int id)
        {
            Bug bug = null;
            foreach(var b in _bugs)
            {
                if (b.Id == id)
                {
                    bug = b;
                    break;
                }
            }

            return bug;
        }
    }
}
