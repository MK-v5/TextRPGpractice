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

        public void erStats(int eHpM, int eMpM, int eSpM)
        {
            eHpMod = eHpM;
            eMpMod = eMpM;
            eSpMod = eSpM;
            enemyHp = baseHp + eHpMod;
            enemyMp = baseMp + eMpMod;
            enemySp = baseSp + eSpMod;
        }
    }
    #region enemy race region

    public class Endog : EnemyRace
    {
        public Endog()
        {
            enemyRn = enemyRaceName[0];
            erStats(10, 9, 10);
        }
    }
    public class Kobold : EnemyRace
    {
        public Kobold()
        {
            enemyRn = enemyRaceName[1];
            erStats(10, 9, 10);
        }
    }

    public class Owlen : EnemyRace
    {
        public Owlen()
        {
            enemyRn = enemyRaceName[2];
            erStats(10, 9, 10);
        }
    }
    public class Bear : EnemyRace 
    {
        public Bear()
        {
            enemyRn = enemyRaceName[3];
            erStats(10, 9, 10);
        }
    }

    #endregion enemy race region
}
