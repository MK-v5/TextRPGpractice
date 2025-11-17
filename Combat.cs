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
        static CreateEnemy ec = new();

        bool isCombat = false;
        bool yourTurn = true;
        //public bool enemyCreated = false;
        
        int cHp;
        int cEHp;
        int dmg;
        int dmgT;

        public void Encounter()
        {
            Random rng = new();
            if (!ec.enemyCreated)
            {
                isCombat = false;
                ec.raceRand();
            }
            if(ec.enemyCreated == true)
            {
                isCombat = true;
            }

            int currentHp = player.Race.hp;
            int currentEnemyHp = ec.enemy.eRace.enemyHp;
            int damage = player.Class.str - ec.enemy.eClass.enemyDef;
            int damageTaken = ec.enemy.eClass.enemyStr - player.Class.def;
            cHp = currentHp;
            cEHp = currentEnemyHp;
            dmg = damage;
            dmgT = damageTaken;
            while (isCombat)
            {
                if (yourTurn)
                {
                    choices();
                }
                if (!yourTurn)
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
                    Console.WriteLine(cEHp);
                    Thread.Sleep(750);
                    yourTurn = true;
                }
                if (cEHp <= 0)
                {
                    isCombat = false;
                    Console.WriteLine("You Win!");
                    player.exp += 20;
                    Thread.Sleep(750);
                    currentState = states.MainMenu;
                }
                if (cHp <= 0)
                {
                    isCombat = false;
                    Console.WriteLine("You Lose!");
                    Thread.Sleep(1000);
                    currentState = states.MainMenu;
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

            try
            {
                userInput = Int32.Parse(Console.ReadLine());
            }
            catch (Exception excpt)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect input type!!");
                Console.WriteLine(excpt.ToString());
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPlease input a number next time!");
                Console.ResetColor();
                Console.ReadKey();
            }

            if (userInput == 1)
            {
                Attack();
            }
            if (userInput == 2)
            {
                Skill();
            }
            if (userInput == 3) 
            {
                Magic();
            }
            if (userInput == 4) 
            {
                Items();
            }
            if (userInput == 5) 
            {
                Defend();
            }
            if (userInput == 6)
            {
                Run();
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
            cEHp += dmg;
            yourTurn = false;
        }

        void Skill()
        {
            Console.WriteLine("no skills yet..");
            Thread.Sleep(1000);
            yourTurn = false;
        }

        void Magic()
        {
            Console.WriteLine("no magic spells learned..");
            Thread.Sleep(1000);
            yourTurn = false;
        }

        void Items()
        {
            Console.WriteLine("pockets empty..");
            Thread.Sleep(1000);
            yourTurn = false;
        }

        void Defend()
        {
            Console.WriteLine("you forgor..");
            Thread.Sleep(1000);
            yourTurn = false;
        }

        void Run()
        {
            Console.WriteLine("you ditched the fight..");
            Thread.Sleep(1000);
            isCombat = false;
            currentState = states.MainMenu;
        }

        #endregion player actions

        #region enemy actions

        void attackPlayer()
        {
            cHp += dmgT;
            yourTurn = true;
        }

        void Emagic()
        {

        }

        void Eskill()
        {

        }

        void Edefend()
        {

        }

        #endregion enemy actions
    }
}
