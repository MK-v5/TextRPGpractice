using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGpractice.Entity_info
{
    public class CharacterClass : Entity
    {
        public static string[] classNames = { "Knight", "Ninja", "Mage", "Demon Hunter" };

        public string cName 
        {
            get { return _classValue.ToString(); }
            set { _classValue = value; _classID = classNames.Length; }
        }

        public int str { get; set; }
        public int def { get; set; }
        public int dex { get; set; }

        protected string knight = classNames[0];
        protected string ninja = classNames[1];
        protected string mage = classNames[2];
        protected string demonHunter = classNames[3];

        private int strMod;
        private int dexMod;
        private int defMod;

        public void SetClassStats(int strM, int dexM, int defM)
        {
            strMod = strM;
            dexMod = dexM;
            defMod = defM;
            str += strMod;
            dex += dexMod;
            def += defMod;
        }
    }

    public class Knight : CharacterClass
    {
        public Knight()
        {
            cName = knight;
            SetClassStats(10, 5, 10);
        }
    }

    public class Ninja : CharacterClass
    {
        public Ninja()
        {
            cName = ninja;
            SetClassStats(10, 5, 10);
        }
    }

    public class Mage : CharacterClass
    {
        public Mage()
        {
            cName = mage;
            SetClassStats(10, 5, 12);
        }
    }

    public class DemonHunter : CharacterClass
    {
        public DemonHunter()
        {
            cName = demonHunter;
            SetClassStats(10, 5, 10);
        }
    }
}
