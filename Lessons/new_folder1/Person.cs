namespace Exercise
{
    using System;

    public class Person
    {

        //constructor        //constructor
        public Person()
        {
        }
        public Person(string inputName, string inputHairColor)
        {
            tname = inputName;
            hairColor = inputHairColor;
        }

        //backing variables
        private string tname;
        private string hairColor;
        //Properies
        /* public string Name
        {
            get { return name; }
        }
        */
        public string Name
        { 
            get { return tname; }
        }

        public string HairColor
        {
            get { return hairColor; }
            set { hairColor = value; }
        }
        



        public void Say()
        {
            Console.WriteLine("Hello Professor John.");
        }
    }
}