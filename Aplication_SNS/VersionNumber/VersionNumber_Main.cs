using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VersionNumber
{
    internal static class VersionNumber_Main
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //GET VERSION

            //var version = Assembly.GetExecutingAssembly().GetName().Version;

            //var buildDate = new DateTime(2000, 1, 1)
            //   .AddDays(version.Build).AddSeconds(version.Revision * 2);

            //var displayableVersion = $"{version} ({buildDate})";

            //Console.WriteLine("Current version (inc. build date) = " + displayableVersion);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VersionNumber());
        }
    }
}
