using CharacterManager.Context;
using CharacterManager.Implementations.Singletones;
using Common.Base;
using Common.Enums;
using Common.Factories;

namespace GMHelper.Forms
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void txtCharacterName_TextChanged(object sender, EventArgs e)
        {
            lblCharacterName.Text = txtCharacterName.Text;
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
            Array races = Enum.GetValues(typeof(RaceEnum));

            // Iterate over the enum values and add them to the ComboBox
            cbRace.Items.Add("— Select Item —");
            cbRace.SelectedIndex = 0;
            foreach (RaceEnum race in races)
            {
                cbRace.Items.Add(race);
            }
        }

        private void cbRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRace.Text = cbRace.SelectedItem.ToString();

            RaceEnum selectedRace = (RaceEnum)cbRace.SelectedIndex;

            BasicStats stats = RaceFactory.CreateStatsByRace(selectedRace);

            lblAgilityVal.Text = stats.Agility.ToString();
            lblStrengthVal.Text = stats.Strength.ToString();
            lblIntelligenceVal.Text = stats.Intelligence.ToString();
            lblUtilityVal.Text = stats.Utility.ToString();
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            Character character = new(txtCharacterName.Text, (RaceEnum)cbRace.SelectedIndex, "ClassPlaceholder")
            {
                CreatedBy = SignalRClient.UserId
            };

            await SignalRClient.SendMessageAsync(character.CreatedBy.ToString(), "Character created & user connected!");

            await SignalRClient.InsertCharacter(character);

            this.Hide();

            new MainForm(character).Show();
        }
    }
}
