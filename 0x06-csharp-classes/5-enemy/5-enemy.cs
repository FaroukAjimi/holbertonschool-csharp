using System;
/*
    Enemies class
*/
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
        /// pub property
        public string Name
        {
            get { return name;}
            set { name = value;}
        }
        /// zombie init health to 0
        public Zombie()
        {
            this.health = 0;
        }
        /// 2nd public constructor zombie
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = value;
        }
        // getter health
        public int GetHealth()
        {
            return(health);
        }
        /// override tostring
        public override string ToString()
        {
            return (String.Format("Zombie name: {0} / Total Health: {1}", this.name, this.health));
        }
    }
}