using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGpractice.Entity_info
{
    public class Entity
    {
        //general
        protected int _attributeID;
        protected int _attributeValue;

        //for race
        protected int _raceID;
        protected string _raceValue;

        //for class
        protected int _classID;
        protected string _classValue;
        //----
        protected int _armorID;
        protected string _armorName;
        protected int _armorValue;
        //----
        protected int _weaponID;
        protected string _weaponName;
        protected int _weaponValue;

        public int baseStr;
        public int baseDef;
        public int baseDex;
        public int baseHp;
        public int baseMp;
        public int baseSp;
    }
}
