using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGpractice.Entity_info
{
    public class EnemyRace : Entity
    {
        public string[] enemyRaceName = { "Endog", "Kobold", "Owlen", "Bear" };

        public string enemyRn;
        public int enemyHp;
        public int enemyMp;
        public int enemySp;

        public int eHpMod;
        public int eMpMod;
        public int eSpMod;

        public void EnemySTATS(int eHpM, int eMpM, int eSpM)
        {
            eHpMod = eHpM;
            eMpMod = eMpM;
            eSpMod = eSpM;
            enemyHp = baseHp + eHpMod;
            enemyMp = baseMp + eMpMod;
            enemySp = baseSp + eSpMod;
        }
    }
}
