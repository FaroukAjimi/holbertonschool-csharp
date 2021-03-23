using System;

    ///<summary> base class </summary>
    public abstract class Base
    {
    ///<summary> properties </summary>
    public String name {get; set;}
     ///<summary> overrider </summary>
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
    }
