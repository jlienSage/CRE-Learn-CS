using System.Collections.Generic;
using Recap.Three.Models;

namespace Recap.Three.Services
{
    public class BugTrackerService : IBugTrackerService
    {
        private int _nextId = 0;

        private ICollection<Bug> _bugs = new List<Bug>();
        //public int Count => throw new System.NotImplementedException();
        public int Count => _bugs.Count;

        public int AddBug(Bug bug)
        {
            //throw new System.NotImplementedException();
            bug.Id = _nextId++;
            _bugs.Add(bug);
            return bug.Id;
        }

        public Bug GetBug(int id)
        {
            //throw new System.NotImplementedException();
            //_bugs.FindIndex(id);
            foreach (Bug bug in _bugs)
            {
                if (bug.Id == id)
                {
                    return (bug);
                }
            }
            return null;
        }

        public ICollection<Bug> GetBugs()
        {
            //throw new System.NotImplementedException();
            return _bugs;
        }

        public bool RemoveBug(int id)
        {
            //throw new System.NotImplementedException();
            //_bugs.Remove(GetBug(id)!=null);
            Bug bug = GetBug(id);
            if (bug == null)
            {
                return false;
            }
            //bool result =  _bugs.Remove(bug);
            //return result;
            return _bugs.Remove(bug);
        }

        public Bug UpdateBug(Bug bug)
        {
            //throw new System.NotImplementedException();
            Bug bugToUpdate = GetBug(bug.Id);
            bugToUpdate.Description = bug.Description;
            bugToUpdate.IsFixed = bug.IsFixed;
            
            return bug;
        }
    }

}