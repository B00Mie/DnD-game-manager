namespace Common.Base
{
    public class SkillGroup
    {
        public int Id { get; set; } = 0;
        public string GroupName { get; set; } = string.Empty;
        public List<Skill> Skills { get; set; } = new List<Skill>();
    }
}
