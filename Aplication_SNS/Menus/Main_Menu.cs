using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using Menus;
using System.Diagnostics;

namespace Menus
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void report_MainMenu_Click(object sender, EventArgs e)
        {

        }

        private void pacient_MainMenu_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Button to Close Aplication
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// LogOut go to Login Again
        /// </summary>
        private void logout_MainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginmenu = new Login();
            loginmenu.Show();
        }

        /// <summary>
        /// Event Click InfoVersion Button
        /// Open a Dialog with a Version of aplication
        /// </summary>
        private void infoVersion_MainMenu_Click(object sender, EventArgs e)
        {
            
            string fileVersion = GetAssemblyFileVersion();
            string title = "FileVersion";
            MessageBox.Show("Aplication Version: "+fileVersion, title);


        }

        /// <summary>
        /// Get Version of aplication
        /// </summary>
        /// <returns> Return string with version of aplication</returns>
        private static string GetAssemblyFileVersion()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersion = FileVersionInfo.GetVersionInfo(assembly.Location);
            return fileVersion.FileVersion;
        }

    }
}