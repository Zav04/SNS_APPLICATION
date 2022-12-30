using Class.CDoctor;
using Class.CHospital;
using Class.CPacient;
using Class.CRoom;
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
using Menus.Pacient;

namespace Menus.PacientWaitingList
{
    public partial class Pacient_Waiting_List : Form
    {
        public Pacient_Waiting_List()
        {
            InitializeComponent();
        }


        private void LoadDataToDataGridPacient()
        {
            DataTable PacientlTable = new DataTable();
            PacientlTable.Columns.Add("ID", typeof(int));
            PacientlTable.Columns.Add("Name", typeof(string));
            PacientlTable.Columns.Add("Age", typeof(string));
            PacientlTable.Columns.Add("Rue", typeof(string));
            PacientlTable.Columns.Add("District", typeof(string));
            PacientlTable.Columns.Add("City", typeof(string));
            PacientlTable.Columns.Add("CC Number", typeof(string));
            PacientlTable.Columns.Add("CC NIF", typeof(ulong));
            PacientlTable.Columns.Add("CC SNS", typeof(ulong));
            PacientlTable.Columns.Add("CC SS", typeof(ulong));
            PacientlTable.Columns.Add("Date of Birth", typeof(string));
            PacientlTable.Columns.Add("Status", typeof(string));
            PacientlTable.Columns.Add("Observation", typeof(string));
            PacientlTable.Columns.Add("Type Illness", typeof(string));
            PacientlTable.Columns.Add("Hospital Name", typeof(string));
            PacientlTable.Columns.Add("Doctor Name", typeof(string));
            PacientlTable.Columns.Add("Room Id", typeof(string));

            Pacient_Waiting_List_Table.ReadOnly = true;
            Pacient_Waiting_List_Table.AllowUserToAddRows = false;

            List<PacientClass> pacientlObjects = Class_Manager.GetDataOfPacient();

            foreach (PacientClass dataPacient in pacientlObjects)
            {
                if (dataPacient.Hospital == null && dataPacient.Doctor == null && dataPacient.Room == null)
                    PacientlTable.Rows.Add(dataPacient.ID_Pacient, dataPacient.Name, dataPacient.Age, dataPacient.Rue, dataPacient.District, dataPacient.City, dataPacient.CCNumber,
                        dataPacient.CCNIF, dataPacient.CCSNS, dataPacient.CCSS, dataPacient.DateOfBirth, dataPacient.Status, dataPacient.Observation, dataPacient.TypeIllness,
                        "NA", "NA", "NA");
            }

            Pacient_Waiting_List_Table.DataSource = PacientlTable;
        }

        private void Pacient_Waiting_List_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridPacient();
        }

        private void Pacient_Waiting_List_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Pacient_Waiting_List_Table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Pacient_Waiting_List_Table.CurrentRow.Selected = true;
            }
        }

        private string GetRowFromList()
        {

            string getDataFromRow = "";
            foreach (DataGridViewRow row in Pacient_Waiting_List_Table.SelectedRows)
            {
                getDataFromRow = row.Cells[0].Value.ToString();
            }
            return getDataFromRow;
        }

        private void Inserted(object[] list, int id)
        {
            List<PacientClass> listofPacientObejects=Class_Manager.GetDataOfPacient();

            Hospital hospital = (Hospital)list[0];
            Doctor doctor = (Doctor)list[1];
            Class_Room room = (Class_Room)list[2];

            foreach (PacientClass pacient in listofPacientObejects)
            {
                if (pacient.ID_Pacient== id)
                {
                    pacient.Hospital = hospital;
                    pacient.Doctor= doctor;
                    doctor.SetPacient(pacient);
                    pacient.Room=room;
                    room.Busy = true;
                }
            }
            MessageBox.Show("PACIENT ADMITED", "WARNING", MessageBoxButtons.OK);
        }

        private void WaitingList()
        {
            MessageBox.Show("NO HOSPITAL AND DOCTOR AVAILABLE\nPACIENT STILL IN WAITING LIST \nTRY AGAIN LATER", "WARNING", MessageBoxButtons.OK);
        }

        private void Pacient_Try_Admit_Click(object sender, EventArgs e)
        {
            if (Pacient_Waiting_List_Table.SelectedRows.Count > 0)
            {
                List<PacientClass> auxpacients = Class_Manager.GetDataOfPacient();
                PacientClass auxpacientClass = null;
                int getIDTable = int.Parse(GetRowFromList());
                foreach (PacientClass pacient in auxpacients)
                {
                    if (pacient.ID_Pacient == getIDTable)
                    {
                        auxpacientClass = pacient;
                        break;
                    }

                }

                object[] hospitalanddoctor = new object[3];

                SelectDistricHospitalAndDoctor(ref hospitalanddoctor, auxpacientClass);
                if (hospitalanddoctor[0] == null || hospitalanddoctor[1] == null || hospitalanddoctor[2] == null)
                {
                    SelectHospitalAndDoctor(ref hospitalanddoctor, auxpacientClass);
                    if (hospitalanddoctor[0] == null || hospitalanddoctor[1] == null || hospitalanddoctor[2] == null)
                    {
                        WaitingList();
                    }
                    else
                    {
                        Inserted(hospitalanddoctor, getIDTable);
                        LoadDataToDataGridPacient();
                    }
                }
                else
                {
                    Inserted(hospitalanddoctor, getIDTable);
                    LoadDataToDataGridPacient();
                }
            }
            else
                MessageBox.Show("SELECT A LINE TO ADMIT A PACIENT", "WARNING", MessageBoxButtons.OK);
        }

        private void SelectDistricHospitalAndDoctor(ref object[] list, PacientClass pacientObject)
        {
            List<Hospital> listofHospitalObejects;

            listofHospitalObejects = Class_Manager.GetDataOfHospital();

            foreach (Hospital hospital in listofHospitalObejects)
            {
                if (hospital.District.ToString() == pacientObject.District.ToString())
                {

                    if (hospital.GetFreeBeds() != 0)
                    {
                        list[0] = hospital;
                        foreach (Class_Room room in hospital.Rooms)
                        {
                            if (room.Busy == false)
                            {
                                list[2] = room;
                                break;
                            }
                        }
                        if (hospital.Doctors != null)
                        {
                            foreach (Doctor doctor in hospital.Doctors)
                            {
                                if (doctor.Specialty.ToString() == pacientObject.TypeIllness.ToString())
                                {
                                    list[1] = doctor;
                                    break;
                                }
                            }
                        }

                        if (list[1] is null)
                        {
                            if (hospital.Doctors != null)
                            {
                                foreach (Doctor doctor in hospital.Doctors)
                                {
                                    if (doctor.Specialty.ToString() == DoctorSpecialty.GeneralMedicine.ToString())
                                    {
                                        list[1] = doctor;
                                        break;
                                    }
                                }
                            }

                        }
                        else break;
                    }

                }

            }

            if (list[0] == null || list[1] == null || list[2] == null)
            {
                list = new object[3];
            }
        }

        private void SelectHospitalAndDoctor(ref object[] list, PacientClass pacientObject)
        {
            List<Hospital> listofHospitalObejects;

            listofHospitalObejects = Class_Manager.GetDataOfHospital();

            foreach (Hospital hospital in listofHospitalObejects)
            {

                if (hospital.GetFreeBeds() != 0)
                {
                    list[0] = hospital;
                    if (hospital.Doctors != null)
                    {
                        foreach (Doctor doctor in hospital.Doctors)
                        {
                            if (doctor.Specialty.ToString() == pacientObject.TypeIllness.ToString())
                            {
                                list[1] = doctor;
                                break;
                            }
                        }
                    }

                    if (list[1] is null)
                    {
                        if (hospital.Doctors != null)
                        {

                            foreach (Doctor doctor in hospital.Doctors)
                            {
                                if (doctor.Specialty.ToString() == DoctorSpecialty.GeneralMedicine.ToString())
                                {
                                    list[2] = doctor;
                                    break;
                                }
                            }

                        }

                    }
                    else break;
                }

            }

            if (list[0] == null || list[1] == null || list[2] == null)
            {
                list = new object[3];
            }

        }

        private void Pacient_Demiss_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Pacient_Menu pacient_Menu = new Pacient_Menu();
            pacient_Menu.Show();

        }
    }
}

