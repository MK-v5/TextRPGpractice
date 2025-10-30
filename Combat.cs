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
        Random rng = new();
        CreateEnemy encreate = new();
        bool isCombat = false;
        bool yourTurn = true;
        public bool enemyCreated = false;
        public void Encounter()
        {
            if (enemyCreated)
            {
                encreate.SpawnEnemy();
            }
            else
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
                    rng.Next(0, 1);
                    //Console.WriteLine("Turn ended");
                    Thread.Sleep(750);
                    yourTurn = true;
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
        * if wpn = null then attack = str; 
        * block = def + amrDef; 
        * if amr = null then block = def;
        */
        void Attack()
        {
            
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


        #endregion enemy actions
    }
}
