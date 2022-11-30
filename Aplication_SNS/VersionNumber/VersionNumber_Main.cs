namespace VersionNumber
{
    internal static class VersionNumber_Main
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new VersionNumber());
        }
    }
}