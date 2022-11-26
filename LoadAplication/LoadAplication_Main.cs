using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadAplication
{
    internal static class LoadAplication_Menu
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoadAplication());
        }
    }
}
