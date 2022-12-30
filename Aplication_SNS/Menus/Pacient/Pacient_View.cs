using Class.CPacient;
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

namespace Menus.PacientView
{
    public partial class Pacient_View : Form
    {
        public Pacient_View()
        {
            InitializeComponent();
        }

        private void Pacient_View_Load(object sender, EventArgs e)
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

            Pacient_View_Table.ReadOnly = true;
            Pacient_View_Table.AllowUserToAddRows = false;

            List<PacientClass> pacientlObjects = Class_Manager.GetDataOfPacient();

            foreach (PacientClass dataPacient in pacientlObjects)
            {
                if (dataPacient.Hospital != null && dataPacient.Doctor != null && dataPacient.Room != null)
                    pacientlTable.Rows.Add(dataPacient.ID_Pacient, dataPacient.Name, dataPacient.Age, dataPacient.Rue, dataPacient.District, dataPacient.City, dataPacient.CCNumber,
                        dataPacient.CCNIF, dataPacient.CCSNS, dataPacient.CCSS, dataPacient.DateOfBirth, dataPacient.Status, dataPacient.Observation, dataPacient.TypeIllness,
                        dataPacient.Hospital.Name, dataPacient.Doctor.Name, dataPacient.Room.Id);
            }

            Pacient_View_Table.DataSource = pacientlTable;
        }

        private void Pacient_Demiss_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Pacient_Menu pacient_Menu = new Pacient_Menu();
            pacient_Menu.Show();
        }
    }
}
