﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGpractice.Player_info
{
    public class Player
    {
        public CharacterRace Race { get; set; }
        public CharacterClass Class { get; set; }
    }
}

/*
    //for combat
    public int baseDmg;
    public int baseAmr;

    //combat
    public int dmg { get; set; }
    public int amr { get; set; }
*/
