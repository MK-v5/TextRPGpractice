using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPGpractice.Entity_info.Entity_properties;
using TextRPGpractice.Equipment_info;


namespace TextRPGpractice.Entity_info
{
    public class Entity
    {
        bool isBoss = false;

        public Race _Race { get; set; }
        public Class? _Class { get; set; }
        public Equipment? _Equipment { get; set; }
    }
}
