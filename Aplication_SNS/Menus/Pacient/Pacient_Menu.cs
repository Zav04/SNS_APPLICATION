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
using Menus.PacientEdit;
using Menus.PacientDemiss;
using Menus.PacientView;
using Menus.PacientWaitingList;

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
            this.Close();
            Pacient_Edit new_edit= new Pacient_Edit();
            new_edit.Show();
        }

        private void Pacient_Dismissal_Click(object sender, EventArgs e)
        {
            this.Close();
            Pacient_Demiss pacientDemiss = new Pacient_Demiss();
            pacientDemiss.Show();
        }

        private void Pacient_View_Click(object sender, EventArgs e)
        {
            this.Close();
            Pacient_View pacientView = new Pacient_View();
            pacientView.Show();
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

        private void Pacient_Waiting_Click(object sender, EventArgs e)
        {
            this.Close();
            Pacient_Waiting_List pacient_Waiting_List= new Pacient_Waiting_List();
            pacient_Waiting_List.Show();

        }
    }
}
