using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menus.PacientInsert;
using Menus.MainMenu;

namespace Menus.Pacient
{
    public partial class Pacient_Menu : Form
    {
        public Pacient_Menu()
        {
            InitializeComponent();
        }

        private void Pacient_Menu_Load(object sender, EventArgs e)
        {

        }

        private void Pacient_Insert_Click(object sender, EventArgs e)
        {
            this.Close();
            Pacient_Insert pacientInsert = new Pacient_Insert();
            pacientInsert.Show();
        }

        private void Pacient_Edit_Click(object sender, EventArgs e)
        {

        }

        private void Pacient_Dismissal_Click(object sender, EventArgs e)
        {

        }

        private void Pacient_View_Click(object sender, EventArgs e)
        {

        }

        private void Pacient_Transfer_Click(object sender, EventArgs e)
        {

        }

        private void Pacient_ListOfVisitor_Click(object sender, EventArgs e)
        {

        }

        private void BACK_Hospital_Menu_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Menu main_Menu= new Main_Menu();
            main_Menu.Show();
        }
    }
}
