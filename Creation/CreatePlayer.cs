using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPGpractice.Entity_info;
using static System.Net.Mime.MediaTypeNames;

namespace TextRPGpractice.Creation
{
    public class CreatePlayer : States
    {

        #region player stat objects

        //Character Race
        public static Wolfen wolf = new();
        public static Cat cat = new();
        public static Voxen vox = new();
        public static Dragon dragon = new();

        //Character Classes
        public static Knight knight = new();
        public static Ninja ninja = new();
        public static Mage mage = new();
        public static DemonHunter demonHunter = new();

        #endregion end stats

        public static void CreateCharacter()
        {
            currentState = states.CharacterCreatorMenu;

            while (currentState != states.Quitting)
            {
                switch (currentState)
                {
                    case states.CharacterCreatorMenu:
                        Console.Clear();
                        Console.WriteLine("Character Creator:");
                        Console.WriteLine("[1] Create Character");
                        Console.WriteLine("[2] View Characters");
                        Console.WriteLine("[3] Main Menu");
                        Console.Write("\n>> ");
                        userInput = Int32.Parse(Console.ReadLine());

                        if (userInput == 1)
                        {
                            currentState = states.RaceSelect;
                        }
                        if (userInput == 2)
                        {
                            //currentState = states.CharacterViewer;
                            Console.WriteLine("it isn't doing anything yet.");
                            Thread.Sleep(750);
                            currentState = states.CharacterCreatorMenu;
                        }
                        if (userInput == 3)
                        {
                            MainMenu();
                        }
                        break;

                    case states.RaceSelect:
                        Console.Clear();
                        Console.WriteLine("Race Select:");
                        Console.WriteLine("[1] Wolfen");
                        Console.WriteLine("[2] Cat");
                        Console.WriteLine("[3] Voxen");
                        Console.WriteLine("[4] Dragon");
                        Console.Write("\n>> ");
                        userInput = Int32.Parse(Console.ReadLine());

                        if (userInput == 1)
                        {

                            player.Race = wolf;
                            currentState = states.ClassSelect;
                        }
                        if (userInput == 2)
                        {
                            player.Race = cat;
                            currentState = states.ClassSelect;
                        }
                        if (userInput == 3)
                        {
                            player.Race = vox;
                            currentState = states.ClassSelect;
                        }
                        if (userInput == 4)
                        {
                            player.Race = dragon;
                            currentState = states.ClassSelect;
                        }
                        break;

                    case states.ClassSelect:
                        Console.Clear();
                        Console.WriteLine("Race Select:");
                        Console.WriteLine("[1] Knight");
                        Console.WriteLine("[2] Ninja");
                        Console.WriteLine("[3] Mage");
                        Console.WriteLine("[4] Demon Hunter");
                        Console.Write("\n>> ");
                        userInput = Int32.Parse(Console.ReadLine());

                        if (userInput == 1)
                        {

                            player.Class = knight;
                            currentState = states.MainMenu;
                            MainMenu();
                        }
                        if (userInput == 2)
                        {
                            player.Class = ninja;
                            currentState = states.MainMenu;
                            MainMenu();
                        }
                        if (userInput == 3)
                        {
                            player.Class = mage;
                            currentState = states.MainMenu;
                            MainMenu();
                        }
                        if (userInput == 4)
                        {
                            player.Class = demonHunter;
                            currentState = states.MainMenu;
                            MainMenu();
                        }
                        break;
                }
            }
        }
    }
}
