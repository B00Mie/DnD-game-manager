using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager.Base.redundant
{
    public class Skills
    {

        public Skills(Dictionary<string, int> skills)
        {
            foreach (var skill in skills)
            {
                if (CheckProperty(skill.Key))
                {
                    SetSkillValue(skill.Key, skill.Value);
                }
            }
        }

        public bool CheckProperty(string skillName)
        {
            if (GetType().GetProperty(skillName) != null)
            {
                return true;

            }
            return false;
        }

        public void SetSkillValue(string skillName, int skillValue)
        {
            var prop = GetType().GetProperty(skillName);

            prop.SetValue(this, skillValue);
        }
    }
}
