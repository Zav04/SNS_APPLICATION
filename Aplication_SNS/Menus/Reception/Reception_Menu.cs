using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menus.MainMenu;
using Menus.ReceptionConcierge;
using Menus.ReceptionStats;

namespace Menus.Reception
{
    public partial class Reception_Menu : Form
    {
        public Reception_Menu()
        {
            InitializeComponent();
        }

        private void Reception_Concierge_Click(object sender, EventArgs e)
        {
            this.Close();
            Reception_Concierge reception_Concierge = new Reception_Concierge();
            reception_Concierge.Show();
        }

        private void Hospital_Stats_Click(object sender, EventArgs e)
        {
            this.Close();
            Reception_Statistics reception_Statistics= new Reception_Statistics();
            reception_Statistics.Show();
        }

        private void Reception_Menu_Load(object sender, EventArgs e)
        {

        }

        private void BACK_Reception_Menu_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Menu main_Menu=new Main_Menu();
            main_Menu.Show();
        }
    }
}
