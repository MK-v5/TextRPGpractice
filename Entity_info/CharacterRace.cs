using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGpractice.Entity_info
{
    public class CharacterRace : Entity
    {
        public static string[] raceNames = { "Wolfen", "Cat", "Voxen", "Dragon" };

        public string rName 
        {
            get { return _raceValue.ToString(); }
            set { _raceValue = value; _raceID = raceNames.Length; }
        }

        public int hp
        {
            get { return _attributeValue ; }
            set { _attributeValue = value; _attributeID = 0; }
        }
        public int mp { get; set; }
        public int sp { get; set; }

        protected string wolfen = raceNames[0];
        protected string cat = raceNames[1];
        protected string voxen = raceNames[2];
        protected string dragon = raceNames[3];

        private int hpMod;
        private int mpMod;
        private int spMod;

        public void SetRaceStats(int hpM, int mpM, int spM)
        {
            hpMod = hpM;
            mpMod = mpM;
            spMod = spM;
            hp += hpMod;
            mp += mpMod;
            sp += mpMod;
        }
    }

    public class Wolfen : CharacterRace
    {
        public Wolfen()
        {
            rName = wolfen;
            SetRaceStats(10, 10, 10);
        }
    }

    public class Cat : CharacterRace
    {
        public Cat()
        {
            rName = cat;
            SetRaceStats(11, 12, 13);
        }
    }

    public class Voxen : CharacterRace
    {
        public Voxen()
        {
            rName = voxen;
            SetRaceStats(10, 10, 10);
        }
    }

    public class Dragon : CharacterRace
    {
        public Dragon()
        {
            rName = dragon;
            SetRaceStats(10, 10, 10);
        }
    }
}
