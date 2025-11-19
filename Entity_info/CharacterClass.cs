using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGpractice.Entity_info
{
    public class CharacterClass : Entity
    {
        public string[] classNames = { "Knight", "Ninja", "Mage", "Demon Hunter" };

        public string cName { get; set; }

        public int str { get; set; }
        public int def { get; set; }
        public int dex { get; set; }

        private int strMod;
        private int dexMod;
        private int defMod;

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

    public class Ninja : CharacterClass
    {
        public Ninja()
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

    public class DemonHunter : CharacterClass
    {
        public DemonHunter()
        {
            cName = classNames[3].ToString();
            SetClassStats(10, 5, 10);
        }
    }
}
