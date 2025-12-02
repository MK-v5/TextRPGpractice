using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPGpractice.Entity_info.Entity_properties;
using TextRPGpractice.Weapon_info;

namespace TextRPGpractice.Entity_info
{
    public class Entity
    {
        protected enum entityType
        {
            Humanoid,
            Non_humanoid
        }

        protected entityType ET;
        bool isBoss = false;

        public Race _Race { get; set; }
        public Class? _Class { get; set; }
        public Equipment? _Equipment { get; set; }
    }
}
