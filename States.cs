using Microsoft.VisualBasic;
using System.Diagnostics;
using System.IO.Compression;
using TextRPGpractice.Player_info;

namespace TextRPGpractice
{
    class States
    {
        #region stats
        static Player player = new();

        static Wolfen wolf = new();
        static Cat cat = new();
        static Voxen vox = new();
        static Dragon dragon = new();

        static Knight knight = new();
        static Rogue rogue = new();
        static Mage mage = new();
        static Berserker berserker = new();
        #endregion end stats

        #region save system

        static public SaveSys sav = new();

        #endregion end save system

        #region Enums for states
        //enum for finite state machine
        //all menu states will be pulled from here
        enum states
        {
            MainMenu,
            CharacterCreatorMenu,
            MainGame,
            SaveMenu,
            RaceSelect,
            ClassSelect,
            SetStats,
            CharacterViewer,
            Quitting
        }

        #endregion End Enums for states

        #region Main Region
        static void Main(string[] args)
        {
            int userInput;
            states currentState = states.MainMenu;

            while (currentState != states.Quitting)
            {
                switch (currentState)
                {
                    case states.MainMenu:
                        Console.Clear();
                        Console.WriteLine("Main Menu:");
                        Console.WriteLine("[1] Play");
                        Console.WriteLine("[2] CharacterCreator");
                        Console.WriteLine("[3] Save Menu");
                        Console.WriteLine("[4] Quit");

                        Console.Write("\n>> ");
                        userInput = Int32.Parse(Console.ReadLine());

                        if (userInput == 1)
                        {
                            Console.WriteLine("Game");
                            currentState = states.Quitting;
                        }
                        if (userInput == 2)
                        {
                            currentState = states.CharacterCreatorMenu;
                        }
                        if (userInput == 3)
                        {
                            currentState = states.SaveMenu;
                        }
                        if (userInput == 4)
                        {
                            currentState = states.Quitting;
                        }
                        break;

                    case states.SaveMenu:
                        Console.Clear();
                        Console.WriteLine("Save Menu:");
                        Console.WriteLine("[1] Save 1");
                        Console.WriteLine("[2] Save 2");
                        Console.WriteLine("[3] Save 3");
                        Console.WriteLine("[4] Save 4");
                        Console.WriteLine("[5] Save 5");
                        Console.WriteLine("[6] Save 6");
                        Console.WriteLine("[7] Save 7");
                        Console.WriteLine("[8] Main Menu");
                        Console.Write("\n>> ");
                        userInput = Int32.Parse(Console.ReadLine());

                        if (userInput == 1)
                        {
                            sav.currentSave = 0;
                            sav.SaveGame(player);
                            currentState = states.SaveMenu;
                        }
                        if (userInput == 2)
                        {
                            sav.currentSave = 1;
                            sav.SaveGame(player);
                            currentState = states.SaveMenu;
                        }
                        if (userInput == 3)
                        {
                            sav.currentSave = 2;
                            sav.SaveGame(player);
                            currentState = states.SaveMenu;
                        }
                        if (userInput == 4)
                        {
                            sav.currentSave = 3;
                            sav.SaveGame(player);
                            currentState = states.SaveMenu;
                        }
                        if (userInput == 5)
                        {
                            sav.currentSave = 4;
                            sav.SaveGame(player);
                            currentState = states.SaveMenu;
                        }
                        if (userInput == 6)
                        {
                            sav.currentSave = 5;
                            sav.SaveGame(player);
                            currentState = states.SaveMenu;
                        }
                        if (userInput == 7)
                        {
                            sav.currentSave = 6;
                            sav.SaveGame(player);
                            currentState = states.SaveMenu;
                        }
                        if (userInput == 8)
                        {
                            currentState = states.MainMenu;
                        }
                        break;

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
                            currentState = states.CharacterViewer;
                        }
                        if (userInput == 3) 
                        {
                            currentState = states.MainMenu;
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
                        Console.WriteLine("[2] Rogue");
                        Console.WriteLine("[3] Mage");
                        Console.WriteLine("[4] Berserker");
                        Console.Write("\n>> ");
                        userInput = Int32.Parse(Console.ReadLine());

                        if (userInput == 1)
                        {
                            
                            player.Class = knight;
                            currentState = states.MainMenu;
                        }
                        if (userInput == 2)
                        {
                            player.Class = rogue;
                            currentState = states.MainMenu;
                        }
                        if (userInput == 3)
                        {
                            player.Class = mage;
                            currentState = states.MainMenu;
                        }
                        if (userInput == 4)
                        {
                            player.Class = berserker;
                            currentState = states.MainMenu;
                        }
                        break;
                }
            }
        }

        #endregion End Main Region
    }
}
