using CharacterManager.Implementations.Singletones;
using Common.Base;
using Common.Factories;
using GMHelper.Factories;
using GMHelper.Forms;
using Microsoft.AspNetCore.SignalR.Client;
using System.Data;
using System.Data.Common;

namespace GMHelper
{
    public partial class TitleScreen : Form
    {
        public TitleScreen()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm();
            this.Hide();
            createForm.Show();
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            var data = await SignalRClient.GetCharacters();

            if (data.Any())
            {
                var menu = new ContextMenuStrip();
                foreach (var ch in data)
                {
                    var item = menu.Items.Add(ch.Name);
                    item.Tag = ch;
                    item.Click += (s2, e2) =>
                    {
                        this.Hide();
                        new MainForm(ch).Show();
                    };
                }

                menu.Show(btnLoad, new Point(0, btnLoad.Height));
            }
            else
            {
                MessageBox.Show("No characters found.");
            }

            //OpenFileDialog openFileDialog = new OpenFileDialog();

            //openFileDialog.Title = "Load Character";
            //openFileDialog.Filter = "Text Files (*.json)|*.json|All Files (*.*)|*.*";
            //openFileDialog.InitialDirectory =
            //Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Character Manager");

            //// Show the dialog and capture the result
            //DialogResult result = openFileDialog.ShowDialog();

            //// Check if the user clicked OK
            //if (result == DialogResult.OK)
            //{
            //    // Get the selected file path
            //    string filePath = openFileDialog.FileName;

            //    var character = ReadWriteFactory.ReadCharacter(filePath);


            //    
            //    new MainForm(character).Show();
            //}
        }
    }
}