using System;

namespace Inheritance
{
    public abstract class Person
    {
        protected abstract decimal Tenure {get;}
        protected abstract string Name {get;}

        public override string ToString()
        {
            return $"My name is {Name}. I have been at Sage {Tenure} years.";
        }
    }
}

