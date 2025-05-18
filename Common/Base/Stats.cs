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
        public int Strength;
        public int Agility;
        public int Intelligence;
        public int Utility;

        public int WaterMagickLvl;
        public int IceMagickLvl;
        public int EnergyMagickLvl;

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
