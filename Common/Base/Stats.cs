using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Base
{
    public class Stats
    {
        public int Id { get; set; } = 0;
        public int CharacterId { get; set; } = 0;
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
        public int Utility { get; set; }

        public int WaterMagickLvl { get; set; }
        public int IceMagickLvl { get; set; }
        public int EnergyMagickLvl { get; set; }

        public Stats() { }

        public Stats(int str, int agi, int intel, int uti)
        {
            Strength = str;
            Agility = agi;
            Intelligence = intel;
            Utility = uti;

            WaterMagickLvl = 0;
            EnergyMagickLvl = 0;
            IceMagickLvl = 0;
        }
        
    }
}
