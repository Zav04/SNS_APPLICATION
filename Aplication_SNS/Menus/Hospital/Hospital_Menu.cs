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
using Class.Hospital;
using Portugal.District;
using Portugal.City;
using Menus.HospitalInsert;

namespace Menus.Hospital
{
    public partial class Hospital_Menu : Form
    {
        public List<HospitalClass> MyMenuItems = new List<HospitalClass>();
        public Hospital_Menu()
        {
            InitializeComponent();
        }


        private void Hospital_Menu_Load(object sender, EventArgs e)
        {
            MyMenuItems.Add(new HospitalClass("Bruno", "Rua", District.Braga, City.Guimarães, 2, 2, 2));
            MyMenuItems.Add(new HospitalClass("Bruno", "Rua", District.Braga, City.Guimarães, 3, 3, 3));
            MyMenuItems.Add(new HospitalClass("Bruno", "Rua", District.Braga, City.Guimarães, 4, 4, 4));
            MyMenuItems.Add(new HospitalClass("Bruno", "Rua", District.Braga, City.Guimarães, 5, 5, 5));
            MyMenuItems.Add(new HospitalClass("Bruno", "Rua", District.Braga, City.Guimarães, 6, 6, 6));
            MyMenuItems.Add(new HospitalClass("Bruno", "Rua", District.Braga, City.Guimarães, 7, 7, 7));
        }

        private void Hospital_Insert_Click(object sender, EventArgs e)
        {
            this.Close();
            Hospital_Insert hospital_View = new Hospital_Insert(MyMenuItems);
            hospital_View.Show();

        }

        private void Hospital_Edit_Click(object sender, EventArgs e)
        {

        }

        private void Hospital_Delete_Click(object sender, EventArgs e)
        {

        }

        private void Hospital_View_Click(object sender, EventArgs e)
        {
            this.Close();
            Hospital_View hospital_View= new Hospital_View(MyMenuItems);
            hospital_View.Show();
        }

        private void BACK_Hospital_Menu_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Menu mainMenu = new Main_Menu();
            mainMenu.Show();

        }
    }
}
