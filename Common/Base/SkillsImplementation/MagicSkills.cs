using CharacterManager.Base.redundant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.SkillsImplementation
{
    public class MagicSkills : Skills
    {
        public MagicSkills(Dictionary<string, int> skills) : base(skills)
        {
        }

        public int Water { get; set; }
        public int Fire { get; set; }
        public int Dark { get; set; }
        public int Ice { get; set; }
        public int Energy { get; set; }
        public int Air { get; set; }
        public int Stone { get; set; }
        public int Light { get; set; }
        public int Magma { get; set; }
        public int Chaos { get; set; }
        public int Metal { get; set; }
        public int Psy { get; set; }
        public int Blood { get; set; }
        public int Vacuum { get; set; }
        public int Death { get; set; }
        public int Life { get; set; }
    }
}
