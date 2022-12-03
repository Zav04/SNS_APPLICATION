using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class;
using Menus.Hospital;

namespace Menus.HospitalView
{
    public partial class Hospital_View : Form
    {
        public Hospital_View()
        {
            InitializeComponent();
        }

        private void Hospital_View_Load(object sender, EventArgs e)
        {

            DataTable hospitalTable = new DataTable();
            hospitalTable.Columns.Add("Name", typeof(string));
            hospitalTable.Columns.Add("Rue", typeof(string));
            hospitalTable.Columns.Add("Number of Flors", typeof(uint));
            hospitalTable.Columns.Add("Number of Rooms", typeof(uint));
            hospitalTable.Columns.Add("Number of Beds", typeof(uint));

            MyMenuItems.








        }
    }
}
