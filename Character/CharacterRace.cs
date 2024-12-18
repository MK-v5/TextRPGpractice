using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGpractice.Character
{
    public class CharacterRace : Player
    {
        public string[] raceNames = { "Wolfen", "Cat", "Voxen", "Dragon" };

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
