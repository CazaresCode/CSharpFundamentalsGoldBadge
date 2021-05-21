using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdGameConsole.Drofsnar
{
    public class Drofsnar
    {
        public int TotalGamePoints { get; set; } = 5000;
        public int HealthPoints { get; set; } = 3;
        public int RemainingLives { get; set; }
        public bool IsAlive { get; set; }
        /// <summary>
        /// give a new life after 10,000 points, for each 
        /// </summary>
        public bool IsInvincible { get; set; }


        public Drofsnar(int totalGamePoints, int healthPoints, int remainingLives, bool isAlive, bool isInvincible)
        {
            TotalGamePoints = totalGamePoints;
            HealthPoints = healthPoints;
            RemainingLives = remainingLives;
            IsAlive = isAlive;
            IsInvincible = isInvincible;
        }
    }
}
