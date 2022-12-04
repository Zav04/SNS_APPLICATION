using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class.Hospital;
using Menus.Hospital;

namespace Menus.HospitalView
{
    public partial class Hospital_View : Form
    {

        List<HospitalClass> listofHospitalObejects;

        public Hospital_View(List<HospitalClass> ListofObejects)
        {
            listofHospitalObejects = ListofObejects;
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
            Hospital_View_Table.ReadOnly = true;
            Hospital_View_Table.AllowUserToAddRows = false;
            


            foreach (var dataHospital in listofHospitalObejects)
            {
                hospitalTable.Rows.Add(dataHospital.Name, dataHospital.Rue, dataHospital.NumberOfFlors, dataHospital.NumberOfRoms, dataHospital.NumberofBeds);

            }
            Hospital_View_Table.DataSource= hospitalTable;

        }


    }
}
