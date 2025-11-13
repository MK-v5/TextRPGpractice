using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPGpractice.Entity_info;

namespace TextRPGpractice.Creation
{
    public class CreateEnemy
    {
        #region enemy stat objects

        public Enemy enemy = new();

        //enemy race
        public Endog endog = new();
        public Kobold kobold = new();
        public Owlen owlen = new();
        public Bear bear = new();
        

        //enemy class
        public RoyalKnight royalKnight = new();
        public Bandit bandit = new();
        public DarkMage darkMage = new();
        public RoyalGuard royalGuard = new();

        #endregion enemy stat objects
        Random rnd = new();
        int enRaceChance = 0;
        int enClassChance = 0;
        public bool enemyCreated;

        public void raceRand()
        {
            enRaceChance = rnd.Next(0, 3);
            switch (enRaceChance)
            {
                case 0:
                    enemy.eRace = endog;
                    classRand();
                    break;
                case 1:
                    enemy.eRace = kobold;
                    classRand();
                    break;
                case 2:
                    enemy.eRace = owlen;
                    classRand();
                    break;
                case 3:
                    enemy.eRace = bear;
                    classRand();
                    break;
            }

            
        }
        void classRand()
        {
            enClassChance = rnd.Next(0, 3);
            switch (enClassChance)
            {
                case 0:
                    enemy.eClass = royalKnight;
                    enemyCreated = true;
                    break;
                case 1:
                    enemy.eClass = bandit;
                    enemyCreated = true;
                    break;
                case 2:
                    enemy.eClass = darkMage;
                    enemyCreated = true;
                    break;
                case 3:
                    enemy.eClass = royalGuard;
                    enemyCreated = true;
                    break;
            }
        }
    }
}
