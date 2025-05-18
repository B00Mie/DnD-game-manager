using CharacterManager.Forms;
using Common.SkillsImplementation;
using Common.Base;
using Newtonsoft.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GMHelper.Forms
{
    public partial class MainForm : Form
    {
        private readonly Character CurrentCharacter;
        private System.Windows.Forms.ToolTip ToolTip = new();


        public object? lb_item = null;
        public MainForm(Character createdCharacter)
        {
            CurrentCharacter = createdCharacter;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            RedrawStats();
            RedrawSkills();

            foreach (var item in CurrentCharacter.Inventory)
            {
                lbInventory.Items.Add(item);
            }

            ToolTip.InitialDelay = 2000;

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            InventoryItem item = new InventoryItem(txtInventoryItem.Text);

            lbInventory.Items.Add(item);
            txtInventoryItem.Clear();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbInventory.SelectedItem != null)
            {
                txtInventoryItem.Text = lbInventory.SelectedItem.ToString();
                lbInventory.Items.Remove(lbInventory.SelectedItem);
            };

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbInventory.SelectedItem != null)
            {
                lbInventory.Items.Remove(lbInventory.SelectedItem);
            };
        }

        private void lbInventory_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void lbInventory_MouseMove(object sender, MouseEventArgs e)
        {
            // Get the index of the item under the mouse cursor
            int index = lbInventory.IndexFromPoint(e.Location);

            // Check if the mouse is moving over an item
            if (index != ListBox.NoMatches)
            {
                // Get the InventoryItem instance at the hovered index
                InventoryItem item = lbInventory.Items[index] as InventoryItem;

                if (item != null)
                {
                    // Display a tooltip with the Description property value
                    ToolTip.SetToolTip(lbInventory, item.Description);
                }
            }
            else
            {
                // Hide the tooltip if the mouse is not over any item
                ToolTip.Hide(lbInventory);
            }

            //// Handle drag and drop functionality
            //if (e.Button == MouseButtons.Left && _draggedIndex != -1)
            //{
            //    int newIndex = lbInventory.IndexFromPoint(e.Location);
            //    if (newIndex != -1)
            //    {
            //        object draggedItem = lbInventory.Items[_draggedIndex];
            //        lbInventory.Items.RemoveAt(_draggedIndex);
            //        lbInventory.Items.Insert(newIndex, draggedItem);
            //        _draggedIndex = newIndex;
            //    }
            //}

        }

        private void lbInventory_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void addDescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryItem? item = lbInventory.SelectedItem as InventoryItem;

            ModalAddDescription modal = new ModalAddDescription(item.Description);
            if (modal.ShowDialog() == DialogResult.OK)
            {
                string description = modal.InputText;

                if (item != null)
                {
                    item.Description = description;
                    lbInventory.SelectedItem = item;
                }

            }
        }

        private void lbInventory_MouseHover(object sender, EventArgs e)
        {
        }

        private void lbInventory_MouseEnter(object sender, EventArgs e)
        {
        }

        private void lbInventory_MouseLeave(object sender, EventArgs e)
        {
            ToolTip.Hide(lbInventory);
        }

        private void toTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbInventory.SelectedIndex; // Get the index of the selected item
            object selectedItem = lbInventory.SelectedItem; // Get the selected item

            // Remove the selected item from its current position
            lbInventory.Items.RemoveAt(selectedIndex);

            // Insert the selected item at the top of the list
            lbInventory.Items.Insert(0, selectedItem);

            // Select the moved item
            lbInventory.SelectedIndex = 0;
        }

        private void upToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbInventory.SelectedIndex; // Get the index of the selected item
            object selectedItem = lbInventory.SelectedItem; // Get the selected item

            if (selectedIndex != 0 && selectedIndex != -1)
            {
                lbInventory.Items.RemoveAt(selectedIndex);


                lbInventory.Items.Insert(selectedIndex - 1, selectedItem);

                lbInventory.SelectedIndex = selectedIndex - 1;
            }
        }

        private void downToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbInventory.SelectedIndex; // Get the index of the selected item
            object selectedItem = lbInventory.SelectedItem; // Get the selected item

            if (selectedIndex + 1 != lbInventory.Items.Count)
            {
                lbInventory.Items.RemoveAt(selectedIndex);


                lbInventory.Items.Insert(selectedIndex + 1, selectedItem);

                lbInventory.SelectedIndex = selectedIndex + 1;
            }
        }

        private void toBottomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbInventory.SelectedIndex; // Get the index of the selected item
            object selectedItem = lbInventory.SelectedItem; // Get the selected item
            int lastIndex = lbInventory.Items.Count - 1;

            // Remove the selected item from its current position
            lbInventory.Items.RemoveAt(selectedIndex);

            // Insert the selected item at the top of the list
            lbInventory.Items.Insert(lastIndex, selectedItem);

            // Select the moved item
            lbInventory.SelectedIndex = lastIndex;
        }

        private void tsLevelUp_Click(object sender, EventArgs e)
        {
            CurrentCharacter.Level++;
            CurrentCharacter.LevelUp();

            RedrawStats();

        }

        private void RedrawStats()
        {
            lblCharacterName.Text = CurrentCharacter.Name;
            lblCharacterSubtitle.Text = $"Level {CurrentCharacter.Level} {CurrentCharacter.Class.Name}, {CurrentCharacter.Race.Name}";
            lblStrengthVal.Text = CurrentCharacter.Race.Stats.Strength.ToString();
            lblAgilityVal.Text = CurrentCharacter.Race.Stats.Agility.ToString();
            lblIntelligenceVal.Text = CurrentCharacter.Race.Stats.Intelligence.ToString();
            lblUtilityVal.Text = CurrentCharacter.Race.Stats.Utility.ToString();

            int health = (CurrentCharacter.Race.BaseHP) + 25 * (CurrentCharacter.Race.Stats.Strength - CurrentCharacter.Race.BasicStats.Strength);
            lblHealthVal.Text = health.ToString();
            lblMannaVal.Text = (CurrentCharacter.Race.Stats.Intelligence * 5).ToString();
        }

        private void RedrawSkills()
        {

            lsGeneralSkills.Items.Clear();
            lsWeaponSkills.Items.Clear();
            lsMagicSkills.Items.Clear();

            foreach (var skill in CurrentCharacter.CharacterSkills.GenerallSkills.Skills)
            {
                lsGeneralSkills.Items.Add($"{skill.Name}: {skill.Level}");

            }

            foreach (var skill in CurrentCharacter.CharacterSkills.WeaponSkills.Skills)
            {
                lsWeaponSkills.Items.Add($"{skill.Name}: {skill.Level}");

            }

            foreach (var skill in CurrentCharacter.CharacterSkills.MagicSkills.Skills)
            {
                lsMagicSkills.Items.Add($"{skill.Name}: {skill.Level}");

            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CurrentCharacter.Inventory.Clear();
            foreach (var item in lbInventory.Items)
            {
                InventoryItem inventoryItem = item as InventoryItem;
                if (inventoryItem != null)
                {
                    CurrentCharacter.Inventory.Add(inventoryItem);
                }
            }
            string json = JsonConvert.SerializeObject(CurrentCharacter);

            string commonDirectoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Character Manager");

            // Ensure that the directory exists, create it if it doesn't
            if (!Directory.Exists(commonDirectoryPath))
            {
                Directory.CreateDirectory(commonDirectoryPath);
            }

            // Define the path to the file in the common directory
            string filePath = Path.Combine(commonDirectoryPath, $"{CurrentCharacter.Name}.json");

            // Write the JSON string to the file
            File.WriteAllText(filePath, json);

            Application.Exit();
        }

        private void tsAddSkills_Click(object sender, EventArgs e)
        {
            SkillsForm form = new(CurrentCharacter.CharacterSkills);

            if (form.ShowDialog() == DialogResult.OK)
            {
                CurrentCharacter.CharacterSkills = form.CharacterSkills;
                RedrawSkills();
            }
        }

        private void txtInventoryItem_TextChanged(object sender, EventArgs e)
        {
            if (txtInventoryItem.Text.Length > 0 && !string.IsNullOrWhiteSpace(txtInventoryItem.Text))
                btnAddItem.Enabled = true;
            else
                btnAddItem.Enabled = false;
        }
    }
}
