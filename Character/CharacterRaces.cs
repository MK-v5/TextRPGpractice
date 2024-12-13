using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGpractice.Character
{
    public class CharacterRaces : Player
    {
        public string[] raceNames = { "Wolfen", "Cat", "Voxen", "Dragon" };
        public string rName;

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

    public class Wolfen : CharacterRaces
    {
        public Wolfen()
        {
            rName = raceNames[0].ToString();
            SetRaceStats(10, 10, 10);
        }
    }

    public class Cat : CharacterRaces
    {
        public Cat() 
        {
            rName = raceNames[1].ToString();
            SetRaceStats(10, 10, 10);
        }
    }

    public class Voxen : CharacterRaces 
    {
        public Voxen()
        {
            rName = raceNames[2].ToString();
            SetRaceStats(10, 10, 10);
        }
    }

    public class Dragon : CharacterRaces
    {
        public Dragon() 
        {
            rName = raceNames[3].ToString();
            SetRaceStats(10, 10, 10);
        }
    }
}
