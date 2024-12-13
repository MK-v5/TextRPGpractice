﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGpractice.Character
{
    public class CharacterClasses : Player
    {
        public string[] classNames = { "Knight", "Rogue", "Mage", "Berserker" };
        public string cName;

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

    public class Knight : CharacterClasses
    {
        public Knight()
        {
            cName = classNames[0].ToString();
            SetClassStats(10, 5, 10);
        }
    }
    public class Rogue: CharacterClasses
    {
        public Rogue()
        {
            cName = classNames[1].ToString();
            SetClassStats(10, 5, 10);
        }
    }

    public class Mage : CharacterClasses
    {
        public Mage()
        {
            cName = classNames[2].ToString();
            SetClassStats(10, 5, 10);
        }
    }

    public class Berserker : CharacterClasses
    {
        public Berserker()
        {
            cName = classNames[3].ToString();
            SetClassStats(10, 5, 10);
        }
    }
}
