using Class.CPacient;
using Class.ManagerOfData;
using Class.Visitor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menus.Reception;

namespace Menus.ReceptionConcierge
{
    public partial class Reception_Concierge : Form
    {
        public Reception_Concierge()
        {
            InitializeComponent();
        }

        private void Recption_Pacients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Recption_Pacients.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Recption_Pacients.CurrentRow.Selected = true;
            }
            LoadVisitorDataGrid(GetRowFromListInPacient());

        }

        private int GetRowFromListInPacient()
        {
            int getDataFromRow = new int();
            foreach (DataGridViewRow row in Recption_Pacients.SelectedRows)
            {
                getDataFromRow = int.Parse(row.Cells[0].Value.ToString());
            }
            return getDataFromRow;
        }

        private void Reception_Concierge_Load(object sender, EventArgs e)
        {
            LoadPacientDataGrid();
        }

        private void LoadPacientDataGrid()
        {
            DataTable recepctionlTable = new DataTable();
            recepctionlTable.Columns.Add("ID", typeof(int));
            recepctionlTable.Columns.Add("Name", typeof(string));
            recepctionlTable.Columns.Add("Age", typeof(string));
            recepctionlTable.Columns.Add("Rue", typeof(string));
            recepctionlTable.Columns.Add("District", typeof(string));
            recepctionlTable.Columns.Add("City", typeof(string));
            recepctionlTable.Columns.Add("CC Number", typeof(string));
            recepctionlTable.Columns.Add("CC NIF", typeof(ulong));
            recepctionlTable.Columns.Add("CC SNS", typeof(ulong));
            recepctionlTable.Columns.Add("CC SS", typeof(ulong));
            recepctionlTable.Columns.Add("Date of Birth", typeof(string));
            recepctionlTable.Columns.Add("Status", typeof(string));
            recepctionlTable.Columns.Add("Observation", typeof(string));
            recepctionlTable.Columns.Add("Type Illness", typeof(string));
            recepctionlTable.Columns.Add("Hospital Name", typeof(string));
            recepctionlTable.Columns.Add("Doctor Name", typeof(string));
            recepctionlTable.Columns.Add("Room Id", typeof(int));

            Recption_Pacients.ReadOnly = true;
            Recption_Pacients.AllowUserToAddRows = false;

            List<PacientClass> pacientlObjects = Class_Manager.GetDataOfPacient();

            foreach (PacientClass dataPacient in pacientlObjects)
            {
                if (dataPacient.Hospital != null && dataPacient.Doctor != null && dataPacient.Room != null)
                    recepctionlTable.Rows.Add(dataPacient.ID_Pacient, dataPacient.Name, dataPacient.Age, dataPacient.Rue, dataPacient.District, dataPacient.City, dataPacient.CCNumber,
                        dataPacient.CCNIF, dataPacient.CCSNS, dataPacient.CCSS, dataPacient.DateOfBirth, dataPacient.Status, dataPacient.Observation, dataPacient.TypeIllness,
                        dataPacient.Hospital.Name, dataPacient.Doctor.Name, dataPacient.Room.Id);
            }

            Recption_Pacients.DataSource = recepctionlTable;
        }


        private void LoadVisitorDataGrid(int idPacient)
        {
            DataTable recepctionVisitorTable = new DataTable();
            recepctionVisitorTable.Columns.Add("ID", typeof(int));
            recepctionVisitorTable.Columns.Add("Name", typeof(string));
            recepctionVisitorTable.Columns.Add("Age", typeof(string));
            recepctionVisitorTable.Columns.Add("Rue", typeof(string));
            recepctionVisitorTable.Columns.Add("District", typeof(string));
            recepctionVisitorTable.Columns.Add("City", typeof(string));
            recepctionVisitorTable.Columns.Add("CC Number", typeof(string));
            recepctionVisitorTable.Columns.Add("CC NIF", typeof(ulong));
            recepctionVisitorTable.Columns.Add("CC SNS", typeof(ulong));
            recepctionVisitorTable.Columns.Add("CC SS", typeof(ulong));
            recepctionVisitorTable.Columns.Add("Date of Birth", typeof(string));
            recepctionVisitorTable.Columns.Add("Degree", typeof(string));

            Recption_Visitor.ReadOnly = true;
            Recption_Visitor.AllowUserToAddRows = false;

            List<PacientClass> pacientlObjects = Class_Manager.GetDataOfPacient();

            foreach (PacientClass dataPacient in pacientlObjects)
            {
                if (dataPacient.ID_Pacient == idPacient)
                {
                    if (dataPacient.Visitors != null)
                    {

                        foreach (VisitorClass visitor in dataPacient.Visitors)
                        {
                            recepctionVisitorTable.Rows.Add(visitor.ID_Visitor, visitor.Name, visitor.Age, visitor.Rue, visitor.District, visitor.City, visitor.CCNumber,
                                visitor.CCNIF, visitor.CCSNS, visitor.CCSS, visitor.DateOfBirth, visitor.Degree);
                        }
                        break;
                    }
                }
            }

            Recption_Visitor.DataSource = recepctionVisitorTable;
        }

        private void BACK_Reception_Menu_Click(object sender, EventArgs e)
        {
            this.Close();
            Reception_Menu reception_Menu = new Reception_Menu();
            reception_Menu.Show();
        }
    }


}

