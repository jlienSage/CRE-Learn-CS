using System;

namespace Inheritance
{     
    public class Chris : Person
    {
        public string Department {get;} = "QA";
        protected override decimal Tenure {get;} = 2;
        protected override string Name {get;} = "C_Brown";

        public override string ToString()
        {          
            string message = base.ToString() + $" I work in {Department}.";
            return message;
        }   
    }
}
