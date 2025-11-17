using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Drawing;
using System.IO.Compression;
using TextRPGpractice.Creation;
using TextRPGpractice.Entity_info;
using static System.Net.Mime.MediaTypeNames;

namespace TextRPGpractice
{
    public class States
    {

        #region character region

        public static Player player = new();
        //public static CreatePlayer createP = new();

        #endregion character region

        #region save system object

        public static SaveSys sav = new();

        #endregion end save system

        #region combat object
        static public Combat comb = new();
        #endregion end combat object

        #region Enums for states
        //enum for finite state machine
        //all menu states will be pulled from here
        public enum states
        {
            MainMenu,
            CharacterCreatorMenu,
            MainGame,
            SaveMenu,
            LoadMenu,
            RaceSelect,
            ClassSelect,
            SetStats,
            CharacterViewer,
            Quitting
        }

        #endregion End Enums for states

        #region Main Region
        public static int userInput;
        public static states currentState;

        public static void Main(string[] args)
        {
            MainMenu();
        }

        static public void MainMenu()
        {
            currentState = states.MainMenu;

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
                        Console.WriteLine("[4] Load Menu");
                        Console.WriteLine("[5] Quit");

                        Console.WriteLine(player.Race);
                        Console.WriteLine(player.Class);

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
                            currentState = states.MainGame;
                        }
                        if (userInput == 2)
                        {
                            currentState = states.CharacterCreatorMenu;
                            CreatePlayer.CreateCharacter();
                        }
                        if (userInput == 3)
                        {
                            currentState = states.SaveMenu;
                        }
                        if (userInput == 4)
                        {
                            currentState = states.LoadMenu;
                        }
                        if (userInput == 5)
                        {
                            currentState = states.Quitting;
                        }
                        break;

                    case states.MainGame:
                        if (player.Race == null && player.Class == null)
                        {
                            Console.WriteLine("no character made just yet");
                            Thread.Sleep(1000);
                            currentState = states.MainMenu;
                        }
                        else
                        {
                            comb.Encounter();
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

                    case states.LoadMenu:
                        Console.Clear();
                        Console.WriteLine("Load Menu:");
                        Console.WriteLine("[1] Save 1");
                        Console.WriteLine("[2] Save 2");
                        Console.WriteLine("[3] Save 3");
                        Console.WriteLine("[4] Save 4");
                        Console.WriteLine("[5] Save 5");
                        Console.WriteLine("[6] Save 6");
                        Console.WriteLine("[7] Save 7");
                        Console.WriteLine("[8] Main Menu");
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
                            sav.currentSave = 0;
                            sav.LoadSave();
                            currentState = states.LoadMenu;
                        }
                        if (userInput == 2)
                        {
                            sav.currentSave = 1;
                            sav.LoadSave();
                            currentState = states.LoadMenu;
                        }
                        if (userInput == 3)
                        {
                            sav.currentSave = 2;
                            sav.LoadSave();
                            currentState = states.LoadMenu;
                        }
                        if (userInput == 4)
                        {
                            sav.currentSave = 3;
                            sav.LoadSave();
                            currentState = states.LoadMenu;
                        }
                        if (userInput == 5)
                        {
                            sav.currentSave = 4;
                            sav.LoadSave();
                            currentState = states.LoadMenu;
                        }
                        if (userInput == 6)
                        {
                            sav.currentSave = 5;
                            sav.LoadSave();
                            currentState = states.LoadMenu;
                        }
                        if (userInput == 7)
                        {
                            sav.currentSave = 6;
                            sav.LoadSave();
                            currentState = states.LoadMenu;
                        }
                        if (userInput == 8)
                        {
                            currentState = states.MainMenu;
                        }
                        break;
                }
            }
        }

        #endregion End Main Region
    }
}
