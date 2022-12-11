using Menus.MainMenu;
using Menus.StaffDoctor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menus.StaffMain
{
    public partial class Staff_Main : Form
    {
        public Staff_Main()
        {
            InitializeComponent();
        }

        private void Staff_Main_Load(object sender, EventArgs e)
        {

        }

        private void BACK_Hospital_Menu_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Menu newMainMenu = new Main_Menu();
            newMainMenu.Show();
        }

        private void Staff_Doctor_Click(object sender, EventArgs e)
        {
            this.Close();
            Staff_Doctor staff_Doctor = new Staff_Doctor();
            staff_Doctor.Show();
        }

        private void Staff_Nurse_Click(object sender, EventArgs e)
        {
            //this.Close();
            //Main_Menu newMainMenu = new Main_Menu();
            //newMainMenu.Show();
        }
    }
}
