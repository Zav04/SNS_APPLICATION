using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Menus.HospitalView;
using Menus.MainMenu;
using Class.CHospital;
using Portugal.District;
using Portugal.City;
using Menus.HospitalInsert;
using Menus.HospitalEdit;
using Menus.HospitalDelete;



namespace Menus.FHospital
{
    public partial class Hospital_Menu : Form
    {
       public Hospital_Menu()
        {
            InitializeComponent();
        }


        private void Hospital_Menu_Load(object sender, EventArgs e)
        {

        }

        private void Hospital_Insert_Click(object sender, EventArgs e)
        {
            this.Close();
            Hospital_Insert hospital_View = new Hospital_Insert();
            hospital_View.Show();

        }

        private void Hospital_Edit_Click(object sender, EventArgs e)
        {
            this.Close();
            Hospital_Edit newHospital_Edit= new Hospital_Edit();
            newHospital_Edit.Show();

        }

        private void Hospital_Delete_Click(object sender, EventArgs e)
        {
            this.Close();
            Hospital_Delete newHospital_Remove = new Hospital_Delete();
            newHospital_Remove.Show();
        }

        private void Hospital_View_Click(object sender, EventArgs e)
        {
            this.Close();
            Hospital_View newHospital_View= new Hospital_View();
            newHospital_View.Show();
        }

        private void BACK_Hospital_Menu_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Menu newMainMenu = new Main_Menu();
            newMainMenu.Show();

        }
    }
}
