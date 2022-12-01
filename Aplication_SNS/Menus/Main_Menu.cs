using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using Menus;

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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_MainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginmenu = new Login();
            loginmenu.Show();
        }
    }
}