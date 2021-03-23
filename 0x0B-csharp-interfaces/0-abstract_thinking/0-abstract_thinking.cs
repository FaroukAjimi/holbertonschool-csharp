using System;

    ///<summary> base class </summary>
    class Base
    {
    // properties
    public String name {get; set;}
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
    }
