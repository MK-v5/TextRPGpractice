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

        Random rnd = new Random();
        int enRaceChance;
        int enClassChance;
        bool isCombat = false;
        bool yourTurn = true;
        bool enemyCreated = false;
        public void Encounter()
        {
            if (enemyCreated)
            {
                CreateEnemy();
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
                    Console.WriteLine("Turn ended");
                    Thread.Sleep(750);
                    yourTurn = true;
                }
            }
        }

        void CreateEnemy()
        {
            enRaceChance = rnd.Next(0, 3);
            enClassChance = rnd.Next(0, 3);
            
        }

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
    }
}
