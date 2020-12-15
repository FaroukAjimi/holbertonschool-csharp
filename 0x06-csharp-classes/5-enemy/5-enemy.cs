using System;

namespace Enemies
{
    /// <summary>
    /// this class does nothing
    /// </summary>
    class Zombie
    {
        /// public field health
        private int health;
        /// private name
        private string name = "(No name)";
        /// <summary> getter and setter. </summary>
        public string Name
        {
            get { return name;}
            set { name = value;}
        }
        /// <summary> set zombie to 0. </summary>
        public Zombie()
        {
            this.health = 0;
        }
        /// <summary> zombie init value. </summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = value;
        }
        /// <summary> getter health. </summary> 
        public int GetHealth()
        {
            return(health);
        }
        /// <summary>  override .tostring(). </summary> 
        public override string ToString()
        {
            return ($"Zombie Name: {name} / Total Health: {health}");
        }
    }
}