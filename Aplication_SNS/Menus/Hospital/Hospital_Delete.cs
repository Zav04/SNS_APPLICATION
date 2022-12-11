using Class.CHospital;
using Class.ManagerOfData;
using Menus.FHospital;
using Portugal.City;
using Portugal.District;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menus.HospitalDelete
{
    public partial class Hospital_Delete : Form
    {
        public Hospital_Delete()
        {
            InitializeComponent();
        }

        private void Hospital_Delete_Load(object sender, EventArgs e)
        {
            LoadDataToDataGrid();


        }


        private void LoadDataToDataGrid()
        {
            DataTable hospitalTable = new DataTable();
            hospitalTable.Columns.Add("ID", typeof(int));
            hospitalTable.Columns.Add("Name", typeof(string));
            hospitalTable.Columns.Add("Rue", typeof(string));
            hospitalTable.Columns.Add("District", typeof(string));
            hospitalTable.Columns.Add("City", typeof(string));
            hospitalTable.Columns.Add("Number of Flors", typeof(uint));
            hospitalTable.Columns.Add("Number of Rooms", typeof(uint));
            hospitalTable.Columns.Add("Number of Beds", typeof(uint));
            Hospital_Remove_Table.ReadOnly = true;
            Hospital_Remove_Table.AllowUserToAddRows = false;

            List<Hospital> hospiatlObjects = Get_Data_Of_Hospital();

            foreach (var dataHospital in hospiatlObjects)
            {
                hospitalTable.Rows.Add(dataHospital.IdHospital, dataHospital.Name, dataHospital.Rue, dataHospital.District, dataHospital.City, dataHospital.NumberOfFlors, dataHospital.NumberOfRoms, dataHospital.NumberofBeds);

            }

            Hospital_Remove_Table.DataSource = hospitalTable;
        }
        private List<Hospital> Get_Data_Of_Hospital()
        {
            List<Hospital> listofHospitalObejects;
            listofHospitalObejects = Class_Manager.GetDataOfHospital();
            return listofHospitalObejects;

        }

        private List<String> GetRowFromList()
        {

            List<String> getDataFromRow = new List<string>();

            foreach (DataGridViewRow row in Hospital_Remove_Table.SelectedRows)
            {
                getDataFromRow.Add(row.Cells[0].Value.ToString());
                getDataFromRow.Add(row.Cells[1].Value.ToString());
                getDataFromRow.Add(row.Cells[2].Value.ToString());
                getDataFromRow.Add(row.Cells[3].Value.ToString());
                getDataFromRow.Add(row.Cells[4].Value.ToString());
                getDataFromRow.Add(row.Cells[5].Value.ToString());
                getDataFromRow.Add(row.Cells[6].Value.ToString());
                getDataFromRow.Add(row.Cells[7].Value.ToString());

            }
            return getDataFromRow;
        }

        private void Hospital_Remove_Click(object sender, EventArgs e)
        {
            if (Hospital_Remove_Table.SelectedRows.Count > 0)
            {

                DialogResult getDialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE", "WARNING", MessageBoxButtons.YesNo);

                if (getDialogResult == DialogResult.Yes)
                {
                    List<String> getDataFromRow = GetRowFromList();
                    int getId = int.Parse(getDataFromRow[0]);

                    List<Hospital> hospiatlObjects = Get_Data_Of_Hospital();

                    hospiatlObjects.RemoveAll(del=>(del.IdHospital== getId));
                    LoadDataToDataGrid();

                }
            }
            else
               MessageBox.Show("SELECT A LINE TO REMOVE A HOSPITAL FROM APLICATION", "WARNING", MessageBoxButtons.OK);


        }

        private void Back_Hospital_Click(object sender, EventArgs e)
        {

            this.Close();
            Hospital_Menu newhospital_Menu = new Hospital_Menu();
            newhospital_Menu.Show();

        }

        private void Hospital_Remove_Cell_Click(object sender, DataGridViewCellEventArgs e)
        {

            Hospital_Remove_Table.CurrentRow.Selected = true;

        }

    }
}
