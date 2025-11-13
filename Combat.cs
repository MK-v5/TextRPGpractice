using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPGpractice.Entity_info;
using TextRPGpractice.Creation;

namespace TextRPGpractice
{
    public class Combat : States
    {
        CreateEnemy ec = new();

        bool isCombat = false;
        bool yourTurn = true;
        //public bool enemyCreated = false;

        public void Encounter()
        {
            Random rng = new Random();
            if (!ec.enemyCreated)
            {
                isCombat = false;
                ec.raceRand();
            }
            if(ec.enemyCreated == true)
            {
                isCombat = true;
            }
            while (isCombat)
            {
                if (yourTurn)
                {
                    choices();
                }
                else
                {
                    var enemychoice = rng.Next(0, 1);
                    if (enemychoice == 0)
                    {
                        Console.WriteLine("Enemy did a useless backflip");
                    }
                    if (enemychoice == 1)
                    {
                        attackPlayer();
                    }
                    Console.WriteLine(ec.enemy.eRace.enemyHp);
                    Thread.Sleep(750);
                    yourTurn = true;
                }
                if (ec.enemy.eRace.enemyHp <= 0)
                {
                    isCombat = false;
                    Console.WriteLine("You Win!");
                    Thread.Sleep(750);
                    Environment.Exit(0);
                }
            }
        }

        #region player actions

        void choices()
        {
            Console.Clear();
            Console.WriteLine("[1] Attack");
            Console.WriteLine("[2] Skill");
            Console.WriteLine("[3] Magic");
            Console.WriteLine("[4] Item");
            Console.WriteLine("[5] Guard");
            Console.WriteLine("[6] Run");

            Console.WriteLine(ec.enemy.eRace.enemyRn);
            Console.WriteLine(ec.enemy.eClass.enemyCn);
            //Console.WriteLine(enemy.eRace.enemyHp);
            //Console.WriteLine(enemy.eClass.enemyStr);

            Console.Write("\n>> ");
            userInput = Int32.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                Attack();
            }
        }


        /*
        * attack - block = Dmg dealt; 
        * attack = str + wpnDmg;
        * dmg - enemy hp;
        * 
        * if wpn = null then attack = str; 
        * block = def + amrDef; 
        * if amr = null then block = def;
        */

        //int attack = player.str -  enemy.hp;
        

        void Attack()
        {
            int dmg = player.Class.str - ec.enemy.eClass.enemyDef;
            dmg -= ec.enemy.eRace.enemyHp;
            yourTurn = false;
        }

        void Skill()
        {

        }

        void Magic()
        {

        }

        void Defend()
        {

        }

        void Run()
        {
            
        }

        #endregion player actions

        #region enemy actions

        void attackPlayer()
        {
            int dmgTaken = ec.enemy.eClass.enemyStr - player.Class.def;
            dmgTaken -= player.Race.hp;
            yourTurn = true;
        }

        #endregion enemy actions
    }
}
