using Common.Base.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Base
{
    public class Skill
    {
        public int Id { get; set; } = 0;
        public int CharacterId { get; set; } = 0;
        public SkillGroupEnum SkillGroup { get; set; } = SkillGroupEnum.General;
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; }
    }
}
