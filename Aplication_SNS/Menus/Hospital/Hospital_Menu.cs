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
using Class;
using Menus.HospitalView;

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
            MyMenuItems.Add(new HospitalClass("Bruno", "Rua", 2, 2, 2));
            MyMenuItems.Add(new HospitalClass("Bruno", "Rua", 3, 3, 3));
            MyMenuItems.Add(new HospitalClass("Bruno", "Rua", 3, 3, 3));
            MyMenuItems.Add(new HospitalClass("Bruno", "Rua", 3, 3, 3));
            MyMenuItems.Add(new HospitalClass("Bruno", "Rua", 3, 3, 3));
            MyMenuItems.Add(new HospitalClass("Bruno", "Rua", 3, 3, 3));
        }

        private void Hospital_Insert_Click(object sender, EventArgs e)
        {

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
            Hospital_View hospital_View= new Hospital_View();
            hospital_View.Show();


        }

    }
}
