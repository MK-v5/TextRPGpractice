using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TextRPGpractice.Entity_info.Entity_properties
{
    public class Class
    {
        public static string[] classNames = 
        {   
            "Knight", "Ninja", "Mage", "Demon Hunter",
            "Royal Knight", "Bandit", "Dark Mage", "Royal Guard"
        };

        public string cName {  get; set; }

        public int str { get; set; }
        public int def { get; set; }
        public int dex { get; set; }

        protected string knight = classNames[0];
        protected string ninja = classNames[1];
        protected string mage = classNames[2];
        protected string demonHunter = classNames[3];

        protected string royalKnight = classNames[4];
        protected string bandit = classNames[5];
        protected string darkMage = classNames[6];
        protected string royalGuard = classNames[7];


        private int strMod;
        private int defMod;
        private int dexMod;
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

    #region for player

    public class Knight : Class
    {
        public Knight()
        {
            cName = knight;
            SetClassStats(10, 5, 10);
        }
    }

    public class Ninja : Class
    {
        public Ninja()
        {
            cName = ninja;
            SetClassStats(10, 5, 10);
        }
    }

    public class Mage : Class
    {
        public Mage()
        {
            cName = mage;
            SetClassStats(10, 5, 12);
        }
    }

    public class DemonHunter : Class
    {
        public DemonHunter()
        {
            cName = demonHunter;
            SetClassStats(10, 5, 10);
        }
    }

    #endregion for player end

    #region for enemy

    public class RoyalKnight : Class
    {
        public RoyalKnight()
        {
            cName = royalKnight;
            SetClassStats(10, 5, 10);
        }
    }

    public class Bandit : Class
    {
        public Bandit()
        {
            cName = royalKnight;
            SetClassStats(10, 5, 10);
        }
    }

    public class DarkMage : Class
    {
        public DarkMage()
        {
            cName = royalKnight;
            SetClassStats(10, 5, 10);
        }
    }

    public class RoyalGuard : Class
    {
        public RoyalGuard()
        {
            cName = royalGuard;
            SetClassStats(10, 5, 10);
        }
    }

    #endregion for enemy end
}
