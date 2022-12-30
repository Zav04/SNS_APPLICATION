using Class.CHospital;
using Class.CPacient;
using Class.CRoom;
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
using Menus.Pacient;
using Portugal.District;
using Class.CDoctor;
using System.Drawing.Text;
using DoctorSpecialtys;

namespace Menus.PacientTransfer
{
    public partial class Pacient_Transfer : Form
    {
        public Pacient_Transfer()
        {
            InitializeComponent();
        }


        private void Pacient_Transfer_Load(object sender, EventArgs e)
        {
            List<Hospital> hospitals = Class_Manager.GetDataOfHospital();

            foreach (Hospital hospital in hospitals)
            {
                Hospital_Combo.Items.Add(hospital.Name);
            }

            LoadToDataGrid();
        }

        private void LoadToDataGrid()
        {


            DataTable pacientlTable = new DataTable();
            pacientlTable.Columns.Add("ID", typeof(int));
            pacientlTable.Columns.Add("Name", typeof(string));
            pacientlTable.Columns.Add("Age", typeof(string));
            pacientlTable.Columns.Add("Rue", typeof(string));
            pacientlTable.Columns.Add("District", typeof(string));
            pacientlTable.Columns.Add("City", typeof(string));
            pacientlTable.Columns.Add("CC Number", typeof(string));
            pacientlTable.Columns.Add("CC NIF", typeof(ulong));
            pacientlTable.Columns.Add("CC SNS", typeof(ulong));
            pacientlTable.Columns.Add("CC SS", typeof(ulong));
            pacientlTable.Columns.Add("Date of Birth", typeof(string));
            pacientlTable.Columns.Add("Status", typeof(string));
            pacientlTable.Columns.Add("Observation", typeof(string));
            pacientlTable.Columns.Add("Type Illness", typeof(string));
            pacientlTable.Columns.Add("Hospital Name", typeof(string));
            pacientlTable.Columns.Add("Doctor Name", typeof(string));
            pacientlTable.Columns.Add("Room Id", typeof(int));

            Pacient_Transfer_Table.ReadOnly = true;
            Pacient_Transfer_Table.AllowUserToAddRows = false;

            List<PacientClass> pacientlObjects = Class_Manager.GetDataOfPacient();

            foreach (PacientClass dataPacient in pacientlObjects)
            {
                if (dataPacient.Hospital != null && dataPacient.Doctor != null && dataPacient.Room != null)
                    pacientlTable.Rows.Add(dataPacient.ID_Pacient, dataPacient.Name, dataPacient.Age, dataPacient.Rue, dataPacient.District, dataPacient.City, dataPacient.CCNumber,
                        dataPacient.CCNIF, dataPacient.CCSNS, dataPacient.CCSS, dataPacient.DateOfBirth, dataPacient.Status, dataPacient.Observation, dataPacient.TypeIllness,
                        dataPacient.Hospital.Name, dataPacient.Doctor.Name, dataPacient.Room.Id);
            }

            Pacient_Transfer_Table.DataSource = pacientlTable;
        }

        private void Pacient_Tranfer_BT_Click(object sender, EventArgs e)
        {
            if (Pacient_Transfer_Table.SelectedRows.Count > 0)
            {
                List<String> dataFromRow = GetRowFromListInPacient();
                if (Hospital_Combo.SelectedIndex != -1 && Room_Combo.SelectedIndex != -1)
                {
                    if (dataFromRow[14] == Hospital_Combo.SelectedItem.ToString())
                    {
                        List<PacientClass> pacients = Class_Manager.GetDataOfPacient();
                        foreach (PacientClass auxpacient in pacients)
                        {
                            if (auxpacient.ID_Pacient == int.Parse(dataFromRow[0]))
                            {
                                List<Hospital> hospitals = Class_Manager.GetDataOfHospital();
                                foreach (Hospital hospital in hospitals)
                                {
                                    if (dataFromRow[14] == hospital.Name)
                                    {
                                        foreach (Class_Room room in hospital.Rooms)
                                        {
                                            if (room.Id == int.Parse(Room_Combo.Text))
                                            {
                                                auxpacient.Room.Busy = false;
                                                auxpacient.Room = room;
                                                auxpacient.Room.Busy = true;
                                                break;

                                            }
                                        }

                                    }
                                    break;
                                }
                                break;

                            }

                        }

                        MessageBox.Show("PACIENT CHANGE ROOM COMPLETE", "WARNING", MessageBoxButtons.OK);
                        LoadToDataGrid();
                        Hospital_Combo.SelectedIndex = -1;
                        Room_Combo.SelectedIndex = -1;
                        Room_Combo.Items.Clear();

                    }
                    else
                    {
                        PacientClass auxpacientClass = null;
                        Hospital auxHospital = null;
                        Class_Room auxRoom = null;

                        List<PacientClass> pacients = Class_Manager.GetDataOfPacient();
                        foreach (PacientClass auxpacient in pacients)
                        {
                            if (auxpacient.ID_Pacient == int.Parse(dataFromRow[0]))
                            {
                                auxpacientClass = auxpacient;
                                List<Hospital> hospitals = Class_Manager.GetDataOfHospital();
                                foreach (Hospital hospital in hospitals)
                                {
                                    if (Hospital_Combo.SelectedItem.ToString() == hospital.Name)
                                    {
                                        auxHospital = hospital;
                                        foreach (Class_Room room in hospital.Rooms)
                                        {
                                            if (room.Id == int.Parse(Room_Combo.Text))
                                            {
                                                auxRoom = room;
                                                break;
                                            }
                                        }
                                    break;
                                    }
                                    
                                }
                                break;
                            }
                        }

                        object[] hospitalanddoctor = new object[3];

                        SelectDistricHospitalAndDoctor(ref hospitalanddoctor, dataFromRow);
                        if (hospitalanddoctor[0] == null || hospitalanddoctor[1] == null || hospitalanddoctor[2] == null)
                        {
                            MessageBox.Show("THE HOSPITAL YOU WANT TO CHANGE DOES NOT HAVE THE REQUIREMENTS TO MOVE THE PACIENT ", "WARNING", MessageBoxButtons.OK);
                        }
                        else
                        {
                            auxpacientClass.Hospital = auxHospital;
                            auxpacientClass.Room.Busy = false;
                            auxpacientClass.Room = auxRoom;
                            auxpacientClass.Room.Busy = true;
                            MessageBox.Show("THE PACIENT ARE BEING MOVED TO THE NEW HOSPITAL", "WARNING", MessageBoxButtons.OK);
                            LoadToDataGrid();
                            Hospital_Combo.SelectedIndex = -1;
                            Room_Combo.SelectedIndex = -1;
                            Room_Combo.Items.Clear();
                        }

                    }

                }
            }
        }


        private void SelectDistricHospitalAndDoctor(ref object[] list, List<string> listRow)
        {
            List<Hospital> listofHospitalObejects;

            listofHospitalObejects = Class_Manager.GetDataOfHospital();

            foreach (Hospital hospital in listofHospitalObejects)
            {
                if (hospital.Name == Hospital_Combo.SelectedItem.ToString())
                {
                    if (hospital.District.ToString() == listRow[4])
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
                                    if (doctor.Specialty.ToString() == listRow[13])
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

            }

            if (list[0] == null || list[1] == null || list[2] == null)
            {
                list = new object[3];
            }
        }

        private void Pacient_Transfer_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Pacient_Transfer_Table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Pacient_Transfer_Table.CurrentRow.Selected = true;
                Hospital_Combo.SelectedIndex = Hospital_Combo.Items.IndexOf(Pacient_Transfer_Table.Rows[e.RowIndex].Cells["Hospital Name"].FormattedValue.ToString());
            }
        }


        private List<String> GetRowFromListInPacient()
        {

            List<String> getDataFromRow = new List<string>();

            foreach (DataGridViewRow row in Pacient_Transfer_Table.SelectedRows)
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
                getDataFromRow.Add(row.Cells[12].Value.ToString());
                getDataFromRow.Add(row.Cells[13].Value.ToString());
                getDataFromRow.Add(row.Cells[14].Value.ToString());
                getDataFromRow.Add(row.Cells[15].Value.ToString());
                getDataFromRow.Add(row.Cells[16].Value.ToString());


            }
            return getDataFromRow;
        }

        private void HospitalComboIndexChange(object sender, EventArgs e)
        {
            Room_Combo.SelectedIndex = -1;
            Room_Combo.Items.Clear();
            List<Hospital> hospitals = Class_Manager.GetDataOfHospital();
            foreach (Hospital hospital in hospitals)
            {
                if (hospital.Name == Hospital_Combo.Text)
                {
                    foreach (Class_Room room in hospital.Rooms)
                    {
                        if (room.Busy == false)
                        {
                            Room_Combo.Items.Add(room.Id);
                        }
                    }
                    break;
                }

            }

        }

        private void Back_Hospital_Edit_Click(object sender, EventArgs e)
        {
            this.Close();
            Pacient_Menu pacient_Menu = new Pacient_Menu();
            pacient_Menu.Show();

        }
    }
}

