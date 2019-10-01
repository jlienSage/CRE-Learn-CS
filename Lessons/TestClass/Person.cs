using System;
using TestClass;



public class MyPerson
{
    private string name = "Lisa Wallace"; //Backing store

    public string Name
    {
        get
        {
            return name;
        }
    }
    private string HairColor = "Blonde"; //Backing store
    public string Color
    {
        get
        {
            return HairColor;
        }
        set
        {
            HairColor = value;
        }
    }
}








