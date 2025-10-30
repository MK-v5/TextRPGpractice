using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPGpractice.Entity_info;

namespace TextRPGpractice.Creation
{
    public class CreateEnemy : Combat
    {
        #region enemy stat objects

        public Enemy enemy = new();

        //enemy race
        Endog endog = new();
        Kobold kobold = new();
        Owlen owlen = new();
        Bear bear = new();
        

        //enemy class
        RoyalKnight royalKnight = new();
        Bandit bandit = new();
        DarkMage darkMage = new();
        RoyalGuard royalGuard = new();

        #endregion enemy stat objects

        Random rnd = new Random();
        int enRaceChance;
        int enClassChance;
        public void SpawnEnemy()
        {
            EnemyRaceChoice();
        }

        void EnemyRaceChoice()
        {
            enRaceChance = rnd.Next(0, 3);
            switch (enRaceChance)
            {
                case 0:
                    enemy.eRace = endog;
                    EnemyClassChoice();
                    break;
                case 1:
                    enemy.eRace = kobold;
                    EnemyClassChoice();
                    break;
                case 2:
                    enemy.eRace = owlen;
                    EnemyClassChoice();
                    break;
                case 3:
                    enemy.eRace = bear;
                    EnemyClassChoice();
                    break;
            }
        }

        void EnemyClassChoice()
        {
            enClassChance = rnd.Next(0, 3);
            switch (enClassChance)
            {
                case 0:
                    enemy.eRace = endog;
                    enemyCreated = true;
                    break;
                case 1:
                    enemy.eRace = kobold;
                    enemyCreated = true;
                    break;
                case 2:
                    enemy.eRace = owlen;
                    enemyCreated = true;
                    break;
                case 3:
                    enemy.eRace = bear;
                    enemyCreated = true;
                    break;
            }
        }
    }
}
