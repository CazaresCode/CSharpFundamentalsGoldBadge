using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdGameConsole.Drofsnar
{
    public class BirdHunters
    {

        public class VulnerableBirdHunters
        {
        
            public string Name => "VulnerableBirdHunters";
            public int Points { get; }
        }

        public class InvincibleBirdHunter
        {
            public InvincibleBirdHunter() { }

            public string Name => "InvincibleBirdHunter";
            public int AttackLives => -1;

        }
    }
}
