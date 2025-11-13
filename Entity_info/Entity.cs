using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGpractice.Entity_info
{
    public class Entity
    {
        //for race
        int _attributeId;
        int _attributeName;
        int _attributeValue;
        public int baseHp = 20;
        public int baseMp = 5;
        public int baseSp = 10;

        //for class
        public int baseStr = 8;
        public int baseDef = 9;
        public int baseDex = 11;
    }
}
