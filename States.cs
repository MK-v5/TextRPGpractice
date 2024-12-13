using Microsoft.VisualBasic;
using System.Diagnostics;
using System.IO.Compression;
using TextRPGpractice.Character;

namespace TextRPGpractice
{
    internal class States
    {
        #region stats
        static CharacterRaces race = new();
        static Wolfen wolf = new();
        static Cat cat = new();
        static Voxen vox = new();
        static Dragon dragon = new();

        static CharacterClasses classes = new();
        static Knight knight = new();
        static Rogue rogue = new();
        static Mage mage = new();
        static Berserker berserker = new();
        #endregion end stats

        #region Enums for states
        //enum for finite state machine
        //all menu states will be pulled from here
        enum states
        {
            MainMenu,
            CharacterCreatorMenu,
            MainGame,
            RaceSelect,
            ClassSelect,
            SetStats,
            CharacterViewer,
            Quitting
        }

        #endregion End Enums for states

        #region Main Region
        static void Main()
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
                        Console.WriteLine("[3] Quit");
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
                            currentState = states.Quitting;
                        }
                        break;

                    case states.CharacterCreatorMenu:
                        Console.Clear();
                        Console.WriteLine("Character Creator");
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
                        Console.WriteLine("Race Select");
                        Console.WriteLine("[1] Wolfen");
                        Console.WriteLine("[2] Cat");
                        Console.WriteLine("[3] Voxen");
                        Console.WriteLine("[4] Dragon");
                        Console.Write("\n>> ");
                        userInput = Int32.Parse(Console.ReadLine());

                        if (userInput == 1)
                        {
                            race = wolf;
                            currentState = states.ClassSelect;
                            Console.WriteLine(race.rName);
                            Console.WriteLine(race.hp);
                            Console.WriteLine(race.mp);
                            Console.WriteLine(race.sp);
                            Thread.Sleep(1200);
                        }
                        if (userInput == 2)
                        {
                            race = cat;
                            currentState = states.ClassSelect;
                            Console.WriteLine(race.rName);
                            Console.WriteLine(race.hp);
                            Console.WriteLine(race.mp);
                            Console.WriteLine(race.sp);
                        }
                        if (userInput == 3)
                        {
                            race = vox;
                            currentState = states.ClassSelect;
                            Console.WriteLine(race.rName);
                            Console.WriteLine(race.hp);
                            Console.WriteLine(race.mp);
                            Console.WriteLine(race.sp);
                        }
                        if (userInput == 4)
                        {
                            race = dragon;
                            currentState = states.ClassSelect;
                            Console.WriteLine(race.rName);
                            Console.WriteLine(race.hp);
                            Console.WriteLine(race.mp);
                            Console.WriteLine(race.sp);
                        }
                        break;

                    case states.ClassSelect:
                        Console.Clear();
                        Console.WriteLine("Race Select");
                        Console.WriteLine("[1] Knight");
                        Console.WriteLine("[2] Rogue");
                        Console.WriteLine("[3] Mage");
                        Console.WriteLine("[4] Berserker");
                        Console.Write("\n>> ");
                        userInput = Int32.Parse(Console.ReadLine());

                        if (userInput == 1)
                        {
                            classes = knight;
                            currentState = states.Quitting;
                            Console.WriteLine(classes.cName);
                            Console.WriteLine(race.rName);

                            Console.WriteLine(race.hp);
                            Console.WriteLine(race.mp);

                            Console.WriteLine(classes.str);
                            Console.WriteLine(classes.dex);
                            Console.WriteLine(classes.def);
                        }
                        if (userInput == 2)
                        {
                            classes = rogue;
                            currentState = states.Quitting;
                            Console.WriteLine(classes.cName);
                            Console.WriteLine(race.rName);
                            Console.WriteLine(race.hp);
                            Console.WriteLine(race.str);
                            Console.WriteLine(race.dex);
                        }
                        if (userInput == 3)
                        {
                            classes = mage;
                            currentState = states.Quitting;
                            Console.WriteLine(classes.cName);
                            Console.WriteLine(race.rName);
                            Console.WriteLine(race.hp);
                            Console.WriteLine(race.str);
                            Console.WriteLine(race.dex);
                        }
                        if (userInput == 4)
                        {
                            classes = berserker;
                            currentState = states.Quitting;
                            Console.WriteLine(classes.cName);
                            Console.WriteLine(race.rName);
                            Console.WriteLine(race.hp);
                            Console.WriteLine(race.str);
                            Console.WriteLine(race.dex);
                        }
                        break;
                }
            }
        }

        #endregion End Main Region
    }
}
