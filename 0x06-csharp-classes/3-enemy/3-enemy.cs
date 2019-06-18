using System;

namespace Enemies
{
    /// <summary>
    /// adding fields and constructor to the class setting the default values to zero
    /// </summary>
    public class Zombie
    {
        ///<summary> defining a private field for zombie called health </summary>///
        private int health;
        /// <summary> setting the health to 0 via the constructor </summary>///
        public Zombie()
        {
            health = 0;
        }
        ///<summary> overriding constructor to get and set value </summary>///
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
            {
                health = value;
            }
        }
        ///<summary> method that returns the value of health of the zombie object </summary>///
        public int GetHealth()
        {
            return health;
        }
    }
}