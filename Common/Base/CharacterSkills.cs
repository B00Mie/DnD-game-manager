namespace Common.Base
{
    public class CharacterSkills
    {
        public int Id { get; set; } = 0;
        public int CharacterId { get; set; } = 0;
        public int SkillPoints { get; set; } = 0;
        public SkillGroup GenerallSkills { get; set; } = new SkillGroup();
        public SkillGroup MagicSkills { get; set; }= new SkillGroup();
        public SkillGroup WeaponSkills { get; set; } = new SkillGroup();


        public SkillGroup GetSkillGroupByName(string groupName)
        {
            return groupName switch
            {
                "General" => GenerallSkills,
                "Magic" => MagicSkills,
                "Weapon" => WeaponSkills,
                _ => new SkillGroup()
            };
        }
    }
}
