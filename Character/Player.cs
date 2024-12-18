using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGpractice.Character
{
    public class Player
    {
        //for race
        public int baseHp = 5;
        public int baseMp = 10;
        public int baseSp = 10;

        //for class
        public int baseStr = 10;
        public int baseDef = 5;
        public int baseDex = 5;

        //for combat
        public int baseDmg;
        public int baseAmr;

        //race
        public string rName { get; set; }
        public int hp { get; set; }
        public int mp { get; set; }
        public int sp { get; set; }

        //class
        public string cName { get; set; }
        public int str { get; set; }
        public int def { get; set; }
        public int dex { get; set; }

        //combat
        public int dmg { get; set; }
        public int amr { get; set; }
    }
}
