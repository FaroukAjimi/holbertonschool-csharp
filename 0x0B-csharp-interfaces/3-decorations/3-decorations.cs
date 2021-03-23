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
    public class Door : Base, IInteractive{
    ///<summary> overrider </summary>
    public Door(string value= "Door"){
            this.name = value;
    }
     ///<summary> overrider </summary>
    public void Interact(){
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
    }
     ///<summary> overrider </summary>
    public class Decoration : Base, IInteractive, IBreakable{
         ///<summary> overrider </summary>
        public bool isQuestItem {get; set;}
         ///<summary> overrider </summary>
        public int durability {get; set;}
         ///<summary> overrider </summary>
        public Decoration(string v1= "Decoration", int v2= 1, bool v3 = false)
        {
            if (v2 <= 0)
                throw new System.ArgumentException("Durability must be greater than 0");
            this.name = v1;
            this.durability = v2;
            this.isQuestItem = v3;            
        }
         ///<summary> overrider </summary>
        public void Interact()
        {
            if (this.durability <= 0)
                Console.WriteLine($"The {this.name} has been broken.");
            else
            {
            if (isQuestItem is true)
                Console.WriteLine($"You look at the {this.name}. There's a key inside.");
            else
                Console.WriteLine($"You look at the {this.name}. Not much to see here");
            }
        }
         ///<summary> overrider </summary>
        public void Break(){
            this.durability--;
            if (this.durability > 0)
                Console.WriteLine($"You hit the {this.name}. It cracks.");
            else if (this.durability == 0)
                Console.WriteLine($"You smash the {this.name}. What a mess.");
            else if (this.durability < 0)
                Console.WriteLine($"The {this.name} is already broken.");
        }
}
