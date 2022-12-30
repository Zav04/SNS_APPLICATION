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
using Pacient.Status;
using Class.CHospital;
using Class.ManagerOfData;
using Class.CPacient;
using Class.CDoctor;
using Menus.Pacient;

namespace Menus.PacientEdit
{
    public partial class Pacient_Edit : Form
    {
        public Pacient_Edit()
        {
            InitializeComponent();
        }

        private void Pacient_Edit_Load(object sender, EventArgs e)
        {
            foreach (Status status in (Status[])Enum.GetValues(typeof(Status)))
                Status_Combo.Items.Add(status);
            LoadDataToDataGridPacient();

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
            PacientlTable.Columns.Add("Room Id", typeof(int));



            Pacient_Edit_Table.ReadOnly = true;
            Pacient_Edit_Table.AllowUserToAddRows = false;

            List<PacientClass> pacientlObjects = GetDataOfPacient();

            foreach (PacientClass dataPacient in pacientlObjects)
            {
                if (dataPacient.Hospital != null && dataPacient.Doctor != null && dataPacient.Room != null)
                    PacientlTable.Rows.Add(dataPacient.ID_Pacient,dataPacient.Name, dataPacient.Age, dataPacient.Rue, dataPacient.District, dataPacient.City, dataPacient.CCNumber,
                        dataPacient.CCNIF, dataPacient.CCSNS, dataPacient.CCSS, dataPacient.DateOfBirth, dataPacient.Status, dataPacient.Observation,dataPacient.TypeIllness,
                        dataPacient.Hospital.Name, dataPacient.Doctor.Name, dataPacient.Room.Id);
            }

            Pacient_Edit_Table.DataSource = PacientlTable;
        }

        private List<PacientClass> GetDataOfPacient()
        {
            List<PacientClass> listofPacientObejects;
            listofPacientObejects = Class_Manager.GetDataOfPacient();
            return listofPacientObejects;

        }

        private List<String> GetRowFromListInPacient()
        {

            List<String> getDataFromRow = new List<string>();

            foreach (DataGridViewRow row in Pacient_Edit_Table.SelectedRows)
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

        private void Hospital_Edit_Edit_Click(object sender, EventArgs e)
        {
            if (Pacient_Edit_Table.SelectedRows.Count > 0)
            {
                DialogResult getDialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO EDIT", "WARNING", MessageBoxButtons.YesNo);
                if (getDialogResult == DialogResult.Yes)
                {
                    List<String> getDataFromRow = GetRowFromListInPacient();
                    int getId = int.Parse(getDataFromRow[0]);

                    List<PacientClass> pacientObjects = GetDataOfPacient();

                    foreach (PacientClass objects in pacientObjects)
                    {
                        if (objects.ID_Pacient == getId)
                        {
                            objects.Status= Enum.Parse<Status>(Status_Combo.GetItemText(this.Status_Combo.SelectedItem));
                            objects.Observation = OBS_Text.Text;
                            LoadDataToDataGridPacient();
                            break;
                        }

                    }

                }
            }
            else
                MessageBox.Show("SELECT A LINE TO EDIT A PACIENT FROM APLICATION", "WARNING", MessageBoxButtons.OK);
        }

        private void Back_Hospital_Edit_Click(object sender, EventArgs e)
        {
            this.Close();
            Pacient_Menu pacient_Menu = new Pacient_Menu();
            pacient_Menu.Show();

        }

        private void Pacient_Edit_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Pacient_Edit_Table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Pacient_Edit_Table.CurrentRow.Selected = true;

                Status_Combo.SelectedIndex = (int)Enum.Parse<Status>(Pacient_Edit_Table.Rows[e.RowIndex].Cells["Status"].FormattedValue.ToString());
                OBS_Text.Text= Pacient_Edit_Table.Rows[e.RowIndex].Cells["Observation"].FormattedValue.ToString();

            }

        }
    }
}
