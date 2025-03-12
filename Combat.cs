using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPGpractice.Entity_info;

namespace TextRPGpractice
{
    class Combat : States
    {
        bool isCombat = false;
        bool yourTurn = true;
        public void Encounter()
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
        }

        void Attack()
        {

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
