﻿using System;
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
        public int GetHealth()
        {
            return(health);
        }
    }
}