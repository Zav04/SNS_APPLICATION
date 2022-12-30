using Class.CDoctor;
using Class.CHospital;
using Class.ManagerOfData;
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
using Menus.StaffDoctor;
using DoctorSpecialtys;

namespace Menus.StaffDoctorDelete
{
    public partial class Staff_Doctor_Delete : Form
    {
        public Staff_Doctor_Delete()
        {
            InitializeComponent();
        }

        private void Staff_Doctor_Delete_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridDoctor();
        }
        private void LoadDataToDataGridDoctor()
        {
            DataTable doctorTable = new DataTable();
            doctorTable.Columns.Add("ID", typeof(int));
            doctorTable.Columns.Add("Name", typeof(string));
            doctorTable.Columns.Add("Age", typeof(string));
            doctorTable.Columns.Add("Rue", typeof(string));
            doctorTable.Columns.Add("District", typeof(string));
            doctorTable.Columns.Add("City", typeof(string));
            doctorTable.Columns.Add("CC Number", typeof(string));
            doctorTable.Columns.Add("CC NIF", typeof(ulong));
            doctorTable.Columns.Add("CC SNS", typeof(ulong));
            doctorTable.Columns.Add("CC SS", typeof(ulong));
            doctorTable.Columns.Add("Date of Birth", typeof(string));
            doctorTable.Columns.Add("Specialty", typeof(DoctorSpecialty));
            doctorTable.Columns.Add("Hospital", typeof(string));

            Doctor_Delete_Table.ReadOnly = true;
            Doctor_Delete_Table.AllowUserToAddRows = false;

            List<Doctor> DoctorObjects = Get_Data_Of_Doctors();

            foreach (var dataDoctor in DoctorObjects)
            {
                if (dataDoctor.Hospital != null)
                    doctorTable.Rows.Add(dataDoctor.ID_Doctor, dataDoctor.Name, dataDoctor.Age, dataDoctor.Rue, dataDoctor.District, dataDoctor.City, dataDoctor.CCNumber, dataDoctor.CCNIF, dataDoctor.CCSNS, dataDoctor.CCSS, dataDoctor.DateOfBirth, dataDoctor.Specialty, dataDoctor.Hospital.Name);
                else
                    doctorTable.Rows.Add(dataDoctor.ID_Doctor, dataDoctor.Name, dataDoctor.Age, dataDoctor.Rue, dataDoctor.District, dataDoctor.City, dataDoctor.CCNumber, dataDoctor.CCNIF, dataDoctor.CCSNS, dataDoctor.CCSS, dataDoctor.DateOfBirth, dataDoctor.Specialty, "Not Working");

            }

            Doctor_Delete_Table.DataSource = doctorTable;
        }
        private List<Doctor> Get_Data_Of_Doctors()
        {
            List<Doctor> listofDoctorObejects;
            listofDoctorObejects = Class_Manager.GetDataOfDoctors();
            return listofDoctorObejects;

        }

        private List<String> GetRowFromListInTableDoctor()
        {

            List<String> getDataFromRow = new List<string>();

            foreach (DataGridViewRow row in Doctor_Delete_Table.SelectedRows)
            {
                getDataFromRow.Add(row.Cells[0].Value.ToString());
                getDataFromRow.Add(row.Cells[1].Value.ToString());
                getDataFromRow.Add(row.Cells[2].Value.ToString());
                getDataFromRow.Add(row.Cells[3].Value.ToString());
                getDataFromRow.Add(row.Cells[4].Value.ToString());
                getDataFromRow.Add(row.Cells[5].Value.ToString());
                getDataFromRow.Add(row.Cells[6].Value.ToString());
                getDataFromRow.Add(row.Cells[7].Value.ToString());
                getDataFromRow.Add(row.Cells[8].Value.ToString());
                getDataFromRow.Add(row.Cells[9].Value.ToString());
                getDataFromRow.Add(row.Cells[10].Value.ToString());
                getDataFromRow.Add(row.Cells[11].Value.ToString());
            }
            return getDataFromRow;
        }

        private void Back_Hospital_Remove_Click(object sender, EventArgs e)
        {
            this.Close();
            Staff_Doctor staff_Doctor = new Staff_Doctor();
            staff_Doctor.Show();
        }


        private void Doctor_Delete_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Doctor_Delete_Table.CurrentRow.Selected = true;
        }

        private void Doctor_Remove_Click(object sender, EventArgs e)
        {

            if (Doctor_Delete_Table.SelectedRows.Count > 0)
            {

                DialogResult getDialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE", "WARNING", MessageBoxButtons.YesNo);

                if (getDialogResult == DialogResult.Yes)
                {
                    List<String> getDataFromRow = GetRowFromListInTableDoctor();
                    int getId = int.Parse(getDataFromRow[0]);

                    List<Doctor> hospiatlObjects = Get_Data_Of_Doctors();

                    hospiatlObjects.RemoveAll(del => (del.ID_Doctor == getId));
                    LoadDataToDataGridDoctor();

                }
            }
            else
                MessageBox.Show("SELECT A LINE TO REMOVE A DOCTOR FROM APLICATION", "WARNING", MessageBoxButtons.OK);
        }
    }
}
