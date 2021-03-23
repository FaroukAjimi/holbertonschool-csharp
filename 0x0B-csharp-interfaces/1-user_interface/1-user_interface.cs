using System;

    ///<summary> base class </summary>
    public abstract class Base
    {
     ///<summary> overrider </summary>
    public String name {get; set;}
     ///<summary> overrider </summary>
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
    }
     ///<summary> overrider </summary>
    public interface IInteractive {
         ///<summary> overrider </summary>
        void Interact();
    }
     ///<summary> overrider </summary>
    public interface IBreakable{
         ///<summary> overrider </summary>
         int durability {get; set;}
          ///<summary> overrider </summary>
         void Break();
    }
     ///<summary> overrider </summary>
    public interface ICollectable{
         ///<summary> overrider </summary>
        bool isCollected {get; set;}
         ///<summary> overrider </summary>
        void Collect();
    }
     ///<summary> overrider </summary>
    public class TestObject : Base, IInteractive, IBreakable, ICollectable{
         ///<summary> overrider </summary>
        public void Interact(){} 
         ///<summary> overrider </summary>
        public int durability {get; set;}
         ///<summary> overrider </summary>
        public void Break(){}
         ///<summary> overrider </summary>
        public bool isCollected {get; set;}
         ///<summary> overrider </summary>
        public void Collect(){}
    }
