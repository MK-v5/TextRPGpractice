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
        public int hp;
        public int mp;
        public int sp;

        //class
        public int str;
        public int def;
        public int dex;

        //combat
        public int dmg;
        public int amr;
    }
}
