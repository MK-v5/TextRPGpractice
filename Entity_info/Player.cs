using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGpractice.Entity_info
{
    public class Player : Entity
    {
        public int level { get; set; }
        public int exp { get; set; }
        public int expCap = 100;

        public void LevelUp()
        {
            int currentCap = expCap;
            level++;
            expCap += currentCap;
            _Race.hp += 15;
            _Race.mp += 15;
            _Race.sp += 15;
            _Class.str += 20;
            _Class.def += 20;
            _Class.dex += 20;
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
