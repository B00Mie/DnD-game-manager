using CharacterManager.Base.redundant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.SkillsImplementation
{
    public class WeaponSkills : Skills
    {
        public WeaponSkills(Dictionary<string, int> skills) : base(skills)
        {
        }

        public int SwordHandling { get; set; }
        public int PolearmHandling { get; set; }
        public int BluntHandling { get; set; }
        /*RANGED*/
        public int CrossbowHandling { get; set; }
        public int BowHandling { get; set; }
    }
}
