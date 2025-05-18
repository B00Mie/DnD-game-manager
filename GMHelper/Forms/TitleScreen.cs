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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();


            openFileDialog.Title = "Load Character";
            openFileDialog.Filter = "Text Files (*.json)|*.json|All Files (*.*)|*.*";
            openFileDialog.InitialDirectory =
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Character Manager");

            // Show the dialog and capture the result
            DialogResult result = openFileDialog.ShowDialog();

            // Check if the user clicked OK
            if (result == DialogResult.OK)
            {
                // Get the selected file path
                string filePath = openFileDialog.FileName;

                var character = ReadWriteFactory.ReadCharacter(filePath);


                this.Hide();
                new MainForm(character).Show();
            }
        }
    }
}