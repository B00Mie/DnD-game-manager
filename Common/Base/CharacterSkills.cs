namespace Common.Base
{
    public class CharacterSkills
    {
        public int SkillPoints { get; set; } = 0;
        public List<Skill> Skills { get; set; } = new List<Skill>();

        public CharacterSkills() { }
    }
}
