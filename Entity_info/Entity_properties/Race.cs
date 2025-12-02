using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGpractice.Entity_info.Entity_properties
{
    public class Race
    {
        public static string[,] raceNames = 
        {
            {
                "Wolfen", "Cat", "Voxen", "Dragon",
                "Endog", "Kobold", "Owlen", "Bear"
            },

            {
                "aurora", "borealis", " ", " ",
                " ", " ", " ", " "
            }
            
        };

        public string rName { get; set; }

        public int hp { get; set; }
        public int mp { get; set; }
        public int sp { get; set; }

        protected string wolfen = raceNames[0, 0];
        protected string cat = raceNames[0, 1];
        protected string voxen = raceNames[0, 2];
        protected string dragon = raceNames[0, 3];

        protected string endog = raceNames[0, 4];
        protected string kobold = raceNames[0, 5];
        protected string owlen = raceNames[0, 6];
        protected string bear = raceNames[0, 7];
        
        public void SetRaceStats(int hpM, int mpM, int spM)
        {
            hp += hpM;
            mp += mpM;
            sp += spM;
        }
    }

    #region for player

    public class Wolfen : Race
    {
        public Wolfen()
        {
            rName = wolfen;
            SetRaceStats(10, 10, 10);
        }
    }

    public class Cat : Race
    {
        public Cat()
        {
            rName = cat;
            SetRaceStats(11, 12, 13);
        }
    }

    public class Voxen : Race
    {
        public Voxen()
        {
            rName = voxen;
            SetRaceStats(10, 10, 10);
        }
    }

    public class Dragon : Race
    {
        public Dragon()
        {
            rName = dragon;
            SetRaceStats(10, 10, 10);
        }
    }

    #endregion for player end

    #region for enemy

    public class Endog : Race
    {
        public Endog()
        {
            rName = endog;
            SetRaceStats(10, 9, 10);
        }
    }
    public class Kobold : Race
    {
        public Kobold()
        {
            rName = kobold;
            SetRaceStats(10, 9, 10);
        }
    }

    public class Owlen : Race
    {
        public Owlen()
        {
            rName = owlen;
            SetRaceStats(10, 9, 10);
        }
    }
    public class Bear : Race
    {
        public Bear()
        {
            rName = bear;
            SetRaceStats(10, 9, 10);
        }
    }

    #endregion for enemy end

}
