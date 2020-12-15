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
        public int? health {get; set;} = null;

        /// zombie init health to 0
        public Zombie()
        {
            this.health = 0;
        }
    }
}
