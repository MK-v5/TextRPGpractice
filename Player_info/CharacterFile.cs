using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGpractice.Player_info
{
    #region character race

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

    #endregion character race

    #region character class

    public class CharacterClass
    {
        public string[] classNames = { "Knight", "Rogue", "Mage", "Berserker" };

        //class
        public string cName { get; set; }
        public int str { get; set; }
        public int def { get; set; }
        public int dex { get; set; }

        //for class
        public int baseStr = 10;
        public int baseDef = 5;
        public int baseDex = 5;

        public int strMod;
        public int dexMod;
        public int defMod;

        public void SetClassStats(int strM, int dexM, int defM)
        {
            strMod = strM;
            dexMod = dexM;
            defMod = defM;
            str = baseStr + strMod;
            dex = baseDex + dexMod;
            def = baseDef + defMod;
        }
    }

    public class Knight : CharacterClass
    {
        public Knight()
        {
            cName = classNames[0].ToString();
            SetClassStats(10, 5, 10);
        }
    }

    public class Rogue : CharacterClass
    {
        public Rogue()
        {
            cName = classNames[1].ToString();
            SetClassStats(10, 5, 10);
        }
    }

    public class Mage : CharacterClass
    {
        public Mage()
        {
            cName = classNames[2].ToString();
            SetClassStats(10, 5, 10);
        }
    }

    public class Berserker : CharacterClass
    {
        public Berserker()
        {
            cName = classNames[3].ToString();
            SetClassStats(10, 5, 10);
        }
    }

    #endregion character class
}
