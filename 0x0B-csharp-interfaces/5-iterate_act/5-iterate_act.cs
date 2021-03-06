﻿using System;
using System.Collections.Generic;

    ///<summary> base class </summary>
    public abstract class Base
    {
     ///<summary> overrider </summary>
    public String name;
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
        public Decoration(string name= "Decoration", int durability= 1, bool isQuestItem = false)
        {
            if (durability <= 0)
                throw new System.ArgumentException("Durability must be greater than 0");
            this.name = name;
            this.durability = durability;
            this.isQuestItem = isQuestItem;            
        }
  
         ///<summary> overrider </summary>
        public void Interact()
        {
            if (this.durability <= 0)
                Console.WriteLine("The {0} has been broken.", this.name);

            else
            {
            if (this.isQuestItem == true)
                Console.WriteLine("You look at the {0}. There's a key inside.", this.name);
            else
                Console.WriteLine("You look at the {0}. Not much to see here.", this.name);
            }
        }

         ///<summary> overrider </summary>
        public void Break(){
            this.durability--;
            if (this.durability > 0)
                Console.WriteLine("You hit the {0}. It cracks.", this.name);
            else if (this.durability == 0)
                Console.WriteLine("You smash the {0}. What a mess.", this.name);
            else
                Console.WriteLine("The {0} is already broken.", this.name);
        }
}
///<summary> overrider </summary>
public class Key : Base, ICollectable{
    ///<summary> overrider </summary>
    public bool isCollected {get; set;}
    
    ///<summary> overrider </summary>
    public Key(string name= "Key", bool isCollected= false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }
    ///<summary> overrider </summary>
    public void Collect(){
        if (this.isCollected == false)
        {
            this.isCollected = true;
            Console.WriteLine("You pick up the {0}.", this.name);
        }
        else if (this.isCollected == true)
            Console.WriteLine("You have already picked up the {0}.", this.name);
    }
}
///<summary> overrider </summary>
public class RoomObjects{
    ///<summary> overrider </summary>
    public static void IterateAction(List<Base> roomObjects, Type type){
            foreach (var item in roomObjects)
        {
            if (typeof(IInteractive).IsAssignableFrom(type))
            {
                try
                {
                    IInteractive changedObj = (IInteractive)item;
                    changedObj.Interact();
                }
                catch {}
            }
            if (typeof(IBreakable).IsAssignableFrom(type))
            {
                try
                {
                    IBreakable changedObj = (IBreakable)item;
                    changedObj.Break();
                }
                catch {}
            }
            if (typeof(ICollectable).IsAssignableFrom(type))
            {
                try
                {
                    ICollectable changedObj = (ICollectable)item;
                    changedObj.Collect();
                }
                catch {}
            }
        }
    }
}
