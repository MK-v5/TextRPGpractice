using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGpractice.Player_info
{
    public class CharacterRace
    {
        public string[] raceNames = { "Wolfen", "Cat", "Voxen", "Dragon" };

        //race
        public string rName { get; set; }
        public int hp { get; set; }
        public int mp { get; set; }
        public int sp { get; set; }

        //for race
        public int baseHp = 5;
        public int baseMp = 10;
        public int baseSp = 10;

        public int hpMod;
        public int mpMod;
        public int spMod;

        public void SetRaceStats(int hpM, int mpM, int spM)
        {
            hpMod = hpM;
            mpMod = mpM;
            spMod = spM;
            hp = baseHp + hpMod;
            mp = baseMp + mpMod;
            sp = baseSp + mpMod;
        }
    }

    public class Wolfen : CharacterRace
    {
        public Wolfen()
        {
            rName = raceNames[0].ToString();
            SetRaceStats(10, 10, 10);
        }
    }

    public class Cat : CharacterRace
    {
        public Cat() 
        {
            rName = raceNames[1].ToString();
            SetRaceStats(10, 10, 10);
        }
    }

    public class Voxen : CharacterRace
    {
        public Voxen()
        {
            rName = raceNames[2].ToString();
            SetRaceStats(10, 10, 10);
        }
    }

    public class Dragon : CharacterRace
    {
        public Dragon() 
        {
            rName = raceNames[3].ToString();
            SetRaceStats(10, 10, 10);
        }
    }
}
