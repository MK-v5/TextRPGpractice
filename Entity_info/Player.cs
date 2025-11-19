using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGpractice.Entity_info
{
    public class Player
    {
        public int level { get; set; }
        public int exp { get; set; }
        public int expCap = 100;


        public CharacterRace Race { get; set; }
        public CharacterClass Class { get; set; }


        public void LevelUp()
        {
            int currentCap = expCap;
            level++;
            expCap += currentCap;
            Race.hp += 15;
            Race.mp += 15;
            Race.sp += 15;
            Class.str += 20;
            Class.def += 20;
            Class.dex += 20;
        }
    }
}

/*
    //for combat
    public int baseDmg;
    public int baseAmr;

    //combat
    public int dmg { get; set; }
    public int amr { get; set; }
*/
