using Class.CDoctor;
using Class.CHospital;
using Class.ManagerOfData;
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

namespace Menus.StaffDoctorHire
{
    public partial class Staff_Doctor_Hire : Form
    {
        public Staff_Doctor_Hire()
        {
            InitializeComponent();
        }

        private void LoadHospitalDataToDataGrid()
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
            Hospital_Hire_Table.ReadOnly = true;
            Hospital_Hire_Table.AllowUserToAddRows = false;

            List<Hospital> hospiatlObjects = Get_Data_Of_Hospital();

            foreach (var dataHospital in hospiatlObjects)
            {
                hospitalTable.Rows.Add(dataHospital.IdHospital, dataHospital.Name, dataHospital.Rue, dataHospital.District, dataHospital.City, dataHospital.NumberOfFlors, dataHospital.NumberOfRoms, dataHospital.NumberofBeds);

            }

            Hospital_Hire_Table.DataSource = hospitalTable;
        }

        private List<Hospital> Get_Data_Of_Hospital()
        {
            List<Hospital> listofHospitalObejects;
            listofHospitalObejects = Class_Manager.GetDataOfHospital();
            return listofHospitalObejects;

        }

        private void LoadDoctorsDataToDataGrid()
        {
            DataTable doctorTable = new DataTable();
            doctorTable.Columns.Add("ID", typeof(int));
            doctorTable.Columns.Add("Name", typeof(string));
            doctorTable.Columns.Add("Age", typeof(uint));
            doctorTable.Columns.Add("Rue", typeof(string));
            doctorTable.Columns.Add("District", typeof(string));
            doctorTable.Columns.Add("City", typeof(string));
            doctorTable.Columns.Add("CCNumber", typeof(string));
            doctorTable.Columns.Add("CCNIF", typeof(ulong));
            doctorTable.Columns.Add("CCSNS", typeof(ulong));
            doctorTable.Columns.Add("CCSS", typeof(ulong));
            doctorTable.Columns.Add("Date of Birth", typeof(string));
            doctorTable.Columns.Add("Specialty", typeof(string));
            Doctor_Hire_Table.ReadOnly = true;
            Doctor_Hire_Table.AllowUserToAddRows = false;

            List<Doctor> DoctorObjects = Get_Data_Of_Doctor();

            foreach (Doctor doctor in DoctorObjects)
            {
                if (doctor.Hospital == null)
                    doctorTable.Rows.Add(doctor.ID_Doctor, doctor.Name, doctor.Age, doctor.Rue, doctor.District, doctor.City, doctor.CCNumber,
                        doctor.CCNIF, doctor.CCSNS, doctor.CCSS, doctor.DateOfBirth, doctor.Specialty);

            }

            Doctor_Hire_Table.DataSource = doctorTable;
        }
        private List<Doctor> Get_Data_Of_Doctor()
        {
            List<Doctor> listofDoctorObejects;
            listofDoctorObejects = Class_Manager.GetDataOfDoctors();
            return listofDoctorObejects;

        }

        private void Hospital_Hire_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Hospital_Hire_Table.CurrentRow.Selected = true;
        }

        private void Doctor_Hire_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Doctor_Hire_Table.CurrentRow.Selected = true;
        }

        private void Staff_Doctor_Hire_Load(object sender, EventArgs e)
        {
            LoadHospitalDataToDataGrid();
            LoadDoctorsDataToDataGrid();
        }

        private void BACK_Hospital_Menu_Click(object sender, EventArgs e)
        {
            this.Close();
            Staff_Doctor staff_Doctor = new Staff_Doctor();
            staff_Doctor.Show();
        }

        private int GetIdFromHospitalList()
        {

            int idHospital = new int();
            foreach (DataGridViewRow row in Hospital_Hire_Table.SelectedRows)
            {
                idHospital = int.Parse(row.Cells[0].Value.ToString());
            }
            return idHospital;
        }

        private int GetIdFromDoctorList()
        {

            int idDoctor = new int();

            foreach (DataGridViewRow row in Doctor_Hire_Table.SelectedRows)
            {
                idDoctor = int.Parse(row.Cells[0].Value.ToString());
            }
            return idDoctor;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Hospital_Hire_Table.SelectedRows.Count > 0 && Doctor_Hire_Table.SelectedRows.Count > 0)
            {
                DialogResult getDialogResult = MessageBox.Show("ARE YOU SURE YOU WANT HIRE THIS DOCTOR?", "WARNING", MessageBoxButtons.YesNo);
                if (getDialogResult == DialogResult.Yes)
                {
                    int getIdHospital = GetIdFromHospitalList();
                    int getIdDoctor = GetIdFromDoctorList();
                    List<Doctor> objectsDoctor = Class_Manager.GetDataOfDoctors();
                    List<Hospital> objectsHospital = Class_Manager.GetDataOfHospital();

                    foreach (Hospital hObject in objectsHospital)
                    {
                        if (hObject.IdHospital == getIdHospital)
                        {
                            foreach (Doctor dObject in objectsDoctor)
                            {
                                if (dObject.ID_Doctor == getIdDoctor)
                                {
                                    dObject.SetHospital(hObject);
                                    break;
                                }
                            }
                        }

                    }
 
                }
                LoadHospitalDataToDataGrid();
                LoadDoctorsDataToDataGrid();
            }
            else
                MessageBox.Show("SELECT TWO LINE TO HIRE A DOCTOR TO A HOSPITAL", "WARNING", MessageBoxButtons.OK);
        }
    }
}


