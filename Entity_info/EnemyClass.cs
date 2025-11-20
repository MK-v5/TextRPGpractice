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

        public string enemyCn { get; set; }

        public int enemyStr { get; set; }
        public int enemyDef { get; set; }
        public int enemyDex { get; set; }

        private int eStrMod;
        private int eDexMod;
        private int eDefMod;

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
            enemyCn = enemyClassName[0].ToString();
            ecStats(10, 5, 10);
        }
    }

    public class Bandit : EnemyClass
    {
        public Bandit()
        {
            enemyCn = enemyClassName[1].ToString();
            ecStats(10, 5, 10);
        }
    }

    public class DarkMage : EnemyClass
    {
        public DarkMage()
        {
            enemyCn = enemyClassName[2].ToString();
            ecStats(10, 5, 10);
        }
    }

    public class RoyalGuard : EnemyClass
    {
        public RoyalGuard()
        {
            enemyCn = enemyClassName[3].ToString();
            ecStats(10, 5, 10);
        }
    }

    #endregion enemy class region
}