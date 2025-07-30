using CharacterManager.Implementations.Singletones;
using CharacterManager.Properties;

namespace GMHelper
{
    internal static class Program
    {

        public static Guid ClientGuid { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            SignalRClient.InitializeAsync();

            ApplicationConfiguration.Initialize();

            var g = Settings.Default.ClientGuid;
            if (g == Guid.Empty)
            {
                g = Guid.NewGuid();
                Settings.Default.ClientGuid = g;
                Settings.Default.Save();
            }

            ClientGuid = g;

            /////////////////TODO
            //string commonDirectoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Character Manager");
            //// Define the path to the file in the common directory
            //string filePath = Path.Combine(commonDirectoryPath);
            //Character? createdChar = ReadWriteFactory.ReadCharacter(filePath);


            //if (createdChar != null)
            //{
            //    Application.Run(new MainForm(createdChar));
            //}
            //else{
            //    Application.Run(new TitleScreen());
            //}

            Application.Run(new TitleScreen());


        }
    }
}