using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menus.StaffMain;
using Menus.StaffDoctor;

namespace Menus.StaffDoctor
{
    public partial class Staff_Doctor : Form
    {
        public Staff_Doctor()
        {
            InitializeComponent();
        }

        private void Staff_Doctor_Load(object sender, EventArgs e)
        {

        }

        private void BACK_Hospital_Menu_Click(object sender, EventArgs e)
        {
            this.Close();
            Staff_Main newStaffMain=new Staff_Main();
            newStaffMain.Show();
        }

        private void Staff_Doctor_Insert_Click(object sender, EventArgs e)
        {
            this.Close();
            Staff_Doctor_Insert newStaffDoctor = new Staff_Doctor_Insert();
            newStaffDoctor.Show();
        }

        private void Staff_Doctor_Hire_Click(object sender, EventArgs e)
        {
            //this.Close();
            //Staff_Main newStaffMain = new Staff_Main();
            //newStaffMain.Show();
        }

        private void Staff_Doctor_Edit_Click(object sender, EventArgs e)
        {
            //this.Close();
            //Staff_Main newStaffMain = new Staff_Main();
            //newStaffMain.Show();
        }

        private void Staff_Doctor_Delete_Click(object sender, EventArgs e)
        {
            //this.Close();
            //Staff_Main newStaffMain = new Staff_Main();
            //newStaffMain.Show();
        }

        private void Staff_Doctor_View_Click(object sender, EventArgs e)
        {
            //this.Close();
            //Staff_Main newStaffMain = new Staff_Main();
            //newStaffMain.Show();
        }
    }
}
