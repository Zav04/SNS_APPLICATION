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
using Class.CPacient;
using Menus.Pacient;


namespace Menus.PacientDemiss
{
    public partial class Pacient_Demiss : Form
    {
        public Pacient_Demiss()
        {
            InitializeComponent();
        }

        private void Pacient_Demiss_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridPacient();
        }
        private void LoadDataToDataGridPacient()
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

            Pacient_Demiss_Table.ReadOnly = true;
            Pacient_Demiss_Table.AllowUserToAddRows = false;

            List<PacientClass> pacientlObjects = GetDataOfPacient();

            foreach (PacientClass dataPacient in pacientlObjects)
            {
                if (dataPacient.Hospital != null && dataPacient.Doctor != null && dataPacient.Room != null)
                    pacientlTable.Rows.Add(dataPacient.ID_Pacient, dataPacient.Name, dataPacient.Age, dataPacient.Rue, dataPacient.District, dataPacient.City, dataPacient.CCNumber,
                        dataPacient.CCNIF, dataPacient.CCSNS, dataPacient.CCSS, dataPacient.DateOfBirth, dataPacient.Status, dataPacient.Observation, dataPacient.TypeIllness,
                        dataPacient.Hospital.Name, dataPacient.Doctor.Name, dataPacient.Room.Id);
            }

            Pacient_Demiss_Table.DataSource = pacientlTable;
        }

        private List<PacientClass> GetDataOfPacient()
        {
            List<PacientClass> listofPacientObejects;
            listofPacientObejects = Class_Manager.GetDataOfPacient();
            return listofPacientObejects;

        }

        private void Pacient_Edit_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Pacient_Demiss_Table.CurrentRow.Selected = true;
        }

        private void Pacient_Demiss_Click(object sender, EventArgs e)
        {

            if (Pacient_Demiss_Table.SelectedRows.Count > 0)
            {

                DialogResult getDialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO DEMISS", "WARNING", MessageBoxButtons.YesNo);

                if (getDialogResult == DialogResult.Yes)
                {
                    string getDataFromRow = GetRowFromList();
                    int getId = int.Parse(getDataFromRow);

                    List<PacientClass> hospiatlObjects = GetDataOfPacient();

                    hospiatlObjects.RemoveAll(del => (del.ID_Pacient == getId));
                    LoadDataToDataGridPacient();

                }
            }
            else
                MessageBox.Show("SELECT A LINE TO DEMISS A PACIENT FROM HOSPITAL", "WARNING", MessageBoxButtons.OK);

        }

        private string GetRowFromList()
        {

            string getDataFromRow = "";
            foreach (DataGridViewRow row in Pacient_Demiss_Table.SelectedRows)
            {
                getDataFromRow = row.Cells[0].Value.ToString();
            }
            return getDataFromRow;
        }

        private void Pacient_Demiss_Back_Click(object sender, EventArgs e)
        {

            this.Close();
            Pacient_Menu pacient_Menu= new Pacient_Menu();
            pacient_Menu.Show();

        }
    }
}
