
using System.Collections.Generic;
using Recap.Three.Models;

namespace Recap.Three.Services
{
     public class BugTrackerService : IBugTrackerService

    {
        private int _nextId = 0;
        private ICollection<Bug> _bugs = new List<Bug>();

        public int Count => _bugs.Count;

        public int AddBug(Bug bug)
        {
            bug.Id = _nextId++;
            _bugs.Add(bug);
            return bug.Id;
        }

        public Bug GetBug(int id)
        {
            foreach (Bug bug in _bugs)
            {
               if (bug.Id == id)
               {
                   return bug;
               } 
            }
            return null;
        }
        
        public ICollection<Bug> GetBugs()
        {
            return _bugs;
        }

        public bool RemoveBug(int id)
        {
           Bug bug = GetBug(id);
           if (bug == null)
           {
               return false;
           }
          return _bugs.Remove(bug);
           
        }
        
        public Bug UpdateBug(Bug bug)
        {
            Bug bugToUpdate = GetBug(bug.Id);
            bugToUpdate.Description = bug.Description;
            bugToUpdate.IsFixed = bug.IsFixed;

            return bug;
        }
    }
}

    