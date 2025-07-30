using CharacterManager.UserControls;
using Common.Base;
using Common.Base.Enums;

namespace CharacterManager.Forms
{
    public partial class SkillsForm : Form
    {
        public CharacterSkills CharacterSkills => _characterSkills;
        private CharacterSkills _characterSkills;

        private int _skillPointsLeft = 0;
        private List<PropertyControll> _propertyControlls = new();

        public SkillsForm(CharacterSkills characterSkills)
        {
            _characterSkills = characterSkills;
            _skillPointsLeft = characterSkills.SkillPoints;
            InitializeComponent();

            var generalSkills = characterSkills.Skills.Where(x => x.SkillGroup == SkillGroupEnum.General);
            var weaponSkills = characterSkills.Skills.Where(x => x.SkillGroup == SkillGroupEnum.Weapon);
            var magicSkills = characterSkills.Skills.Where(x => x.SkillGroup == SkillGroupEnum.Magic);

            GeneratePropertyControls(generalSkills, 10, 50);
            GeneratePropertyControls(magicSkills, 250, 50);
            GeneratePropertyControls(weaponSkills, 500, 50);
            RefreshButtons();
        }

        private void SkillsForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = $"Skillpoints left: {_skillPointsLeft}";
        }


        private void GeneratePropertyControls(IEnumerable<Skill> skills, int xPos, int startingYpos)
        {
            SkillGroupEnum skillGroup = skills.FirstOrDefault().SkillGroup;
            Label groupName = new()
            {
                Text = skillGroup.ToString(),
                Location = new Point(xPos, startingYpos),
                AutoSize = true,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            this.Controls.Add(groupName);

            for(int i = 0; i < skills.Count(); i++)
            {
                var skill = skills.ElementAt(i);
                int y = (startingYpos + 20) + (30 * i);
                PropertyControll propertyControl = new()
                {
                    PropertyName = skill.Name,
                    PropertyValue = skill.Level.ToString(),
                    GroupName = skillGroup.ToString(),
                    Location = new Point(xPos, y),
                    AutoSize = true
                };
                propertyControl.IncreaseClicked += PropertyControl_IncreaseClicked;
                propertyControl.DecreaseClicked += PropertyControl_DecreaseClicked;
                if (_skillPointsLeft == 0)
                {
                    propertyControl.IncreaseButton.Enabled = false;
                }

                this.Controls.Add(propertyControl);
                _propertyControlls.Add(propertyControl);
            }
            foreach (var skill in skills)
            {
                
            }
        }

        private void PropertyControl_IncreaseClicked(object sender, EventArgs e)
        {
            PropertyControll propertyControl = (PropertyControll)sender;
            propertyControl.DecreaseButton.Enabled = true;

            string skillValue = propertyControl.PropertyValue;
            int skillLevel = int.Parse(skillValue);
            _skillPointsLeft = _skillPointsLeft - (skillLevel + 1);

            skillLevel++;
            propertyControl.PropertyValue = skillLevel.ToString();



            if (_skillPointsLeft < 1)
            {
                foreach (var property in _propertyControlls)
                {
                    property.IncreaseButton.Enabled = false;
                }
            }

            lblTitle.Text = $"Skillpoints left: {_skillPointsLeft}";
            RefreshButtons();
        }

        private void PropertyControl_DecreaseClicked(object sender, EventArgs e)
        {
            PropertyControll propertyControl = (PropertyControll)sender;

            propertyControl.IncreaseButton.Enabled = true;
            string skillValue = propertyControl.PropertyValue;
            int skillLevel = int.Parse(skillValue);
            _skillPointsLeft = _skillPointsLeft + (skillLevel);

            skillLevel--;
            propertyControl.PropertyValue = skillLevel.ToString();

            var currentSkill = _characterSkills.Skills.FirstOrDefault(x => x.Name == propertyControl.PropertyName && x.SkillGroup.ToString() == propertyControl.GroupName);

            if (_skillPointsLeft > 0)
            {
                foreach (var property in _propertyControlls)
                {
                    property.IncreaseButton.Enabled = true;
                }
            }
            if (_skillPointsLeft == _characterSkills.SkillPoints || currentSkill.Level == skillLevel)
            {
                propertyControl.DecreaseButton.Enabled = false;
            }
            lblTitle.Text = $"Skillpoints left: {_skillPointsLeft}";
            RefreshButtons();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            _characterSkills.SkillPoints = _skillPointsLeft;
            foreach (var property in _propertyControlls)
            {
                var currentSkill = _characterSkills.Skills.FirstOrDefault(x => x.Name == property.PropertyName && x.SkillGroup.ToString() == property.GroupName);
                currentSkill.Level = int.Parse(property.PropertyValue);
            }

            this.Close();
        }


        private void RefreshButtons()
        {

            foreach (var property in _propertyControlls)
            {
                var currentSkill = _characterSkills.Skills.FirstOrDefault(x => x.Name == property.PropertyName && x.SkillGroup.ToString() == property.GroupName);
                int skillpointsNeeded = currentSkill.Level + 1;

                if (skillpointsNeeded <= _skillPointsLeft)
                {
                    property.IncreaseButton.Enabled = true;
                }
                else
                {
                    property.IncreaseButton.Enabled = false;

                }
            }
            if (_skillPointsLeft < _characterSkills.SkillPoints)
            {
                btnApply.Enabled = true;
            }
            else
            {
                btnApply.Enabled = false;
            }
        }
    }
}
