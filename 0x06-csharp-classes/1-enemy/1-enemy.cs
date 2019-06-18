using System;

namespace Enemies
{
    /// <summary>
    /// adding fields and constructor to the class setting the default values to zero
    /// </summary>
    public class Zombie
    {
        ///<summary> defining a public field for zombie called health </summary>///
        public int health;
        /// <summary> setting the health to 0 via the constructor </summary>///
        public Zombie()
        {
            health = 0;
        }
    }
}