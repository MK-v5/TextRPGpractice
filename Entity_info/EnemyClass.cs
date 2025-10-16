using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGpractice.Entity_info
{
    public class EnemyClass : Entity
    {
        public string[] enemyClassName = { "Royal Knight", "Bandit", "Dark Mage", "Royal Guard" };

        public string EnemyCn;
        public int enemyStr;
        public int enemyDef;
        public int enemyDex;

        public int eStrMod;
        public int eDexMod;
        public int eDefMod;

        public void ecStats(int eStrM, int eDexM, int eDefM)
        {
            eStrMod = eStrM;
            eDexMod = eDexM;
            eDefMod = eDefM;
            enemyStr = baseStr + eStrMod;
            enemyDex = baseDex + eDexMod;
            enemyDef = baseDef + eDefMod;
        }
    }

    #region enemy class region 

    public class RoyalKnight : EnemyClass
    {
        public RoyalKnight() 
        {
            EnemyCn = enemyClassName[0];
            ecStats(10, 5, 10);
        }
    }

    public class Bandit : EnemyClass
    {
        public Bandit()
        {
            EnemyCn = enemyClassName[1];
            ecStats(10, 5, 10);
        }
    }

    public class DarkMage : EnemyClass
    {
        public DarkMage()
        {
            EnemyCn = enemyClassName[2];
            ecStats(10, 5, 10);
        }
    }

    public class RoyalGuard : EnemyClass
    {
        public RoyalGuard()
        {
            EnemyCn = enemyClassName[3];
            ecStats(10, 5, 10);
        }
    }

    #endregion enemy class region
}