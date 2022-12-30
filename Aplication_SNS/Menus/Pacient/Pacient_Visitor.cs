using Class.CHospital;
using Class.CPacient;
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
using Visitor.DegreeOfKinship;
using Class.Visitor;
using Menus.Pacient;

namespace Menus.PacientVisitor
{
    public partial class Pacient_Visitor : Form
    {
        public Pacient_Visitor()
        {
            InitializeComponent();
        }

        private void Pacient_Visitor_Load(object sender, EventArgs e)
        {

            foreach (District district in (District[])Enum.GetValues(typeof(District)))
                District_Combo.Items.Add(district);
            foreach (City city in (City[])Enum.GetValues(typeof(City)))
                City_Combo.Items.Add(city);
            foreach (DegreeOfKinship degree in (DegreeOfKinship[])Enum.GetValues(typeof(DegreeOfKinship)))
                Degree_Combo.Items.Add(degree);
            for (int i = 1; i <= 150; i++)
            {
                Age_Combo.Items.Add(i);
            }

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

            Pacient_Visitor_Table.ReadOnly = true;
            Pacient_Visitor_Table.AllowUserToAddRows = false;

            List<PacientClass> pacientlObjects = Class_Manager.GetDataOfPacient();

            foreach (PacientClass dataPacient in pacientlObjects)
            {
                if (dataPacient.Hospital != null && dataPacient.Doctor != null && dataPacient.Room != null)
                    pacientlTable.Rows.Add(dataPacient.ID_Pacient, dataPacient.Name, dataPacient.Age, dataPacient.Rue, dataPacient.District, dataPacient.City, dataPacient.CCNumber,
                        dataPacient.CCNIF, dataPacient.CCSNS, dataPacient.CCSS, dataPacient.DateOfBirth, dataPacient.Status, dataPacient.Observation, dataPacient.TypeIllness,
                        dataPacient.Hospital.Name, dataPacient.Doctor.Name, dataPacient.Room.Id);
            }

            Pacient_Visitor_Table.DataSource = pacientlTable;
        }

        private void Pacient_Visitor_Add_Click(object sender, EventArgs e)
        {

            if (
           String.IsNullOrEmpty(Name_Text.Text) != true &&
           Age_Combo.SelectedIndex != -1 &&
           String.IsNullOrEmpty(Rue_Text.Text) != true &&
           District_Combo.SelectedIndex != -1 &&
           City_Combo.SelectedIndex != -1 &&
           String.IsNullOrEmpty(CCNumber_Text.Text) != true &&
           String.IsNullOrEmpty(NIF_Text.Text) != true &&
           String.IsNullOrEmpty(SNS_Text.Text) != true &&
           String.IsNullOrEmpty(SS_Text.Text) != true &&
           String.IsNullOrEmpty(DOB_Text.Text) != true &&
           Degree_Combo.SelectedIndex != -1 &&
           Pacient_Visitor_Table.SelectedRows.Count > 0)
            {

                VisitorClass newInsert = new VisitorClass(Name_Text.Text,
                                    uint.Parse(Age_Combo.SelectedItem.ToString()),
                                    Rue_Text.Text,
                                    Enum.Parse<District>(District_Combo.GetItemText(this.District_Combo.SelectedItem)),
                                    Enum.Parse<City>(City_Combo.GetItemText(this.City_Combo.SelectedItem)),
                                    CCNumber_Text.Text,
                                    ulong.Parse(NIF_Text.Text),
                                    ulong.Parse(SNS_Text.Text),
                                    ulong.Parse(SS_Text.Text),
                                    DOB_Text.Text,
                                    Enum.Parse<DegreeOfKinship>(Degree_Combo.GetItemText(this.Degree_Combo.SelectedItem)));

                List<PacientClass> pacientObejects = Class_Manager.GetDataOfPacient();
                foreach (PacientClass pacient in pacientObejects)
                {
                    if (int.Parse(GetRowFromListInPacient()) == pacient.ID_Pacient)
                    {
                        pacient.InsertOneVisitorToList(newInsert);
                    }
                }

                MessageBox.Show("VISITOR INSERTED", "WARNING", MessageBoxButtons.OK);

            }
        }

        private string GetRowFromListInPacient()
        {

            string getDataFromRow = "";

            foreach (DataGridViewRow row in Pacient_Visitor_Table.SelectedRows)
            {
                getDataFromRow = row.Cells[0].Value.ToString();
            }
            return getDataFromRow;
        }

        private void Pacient_Visitor_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Pacient_Visitor_Table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Pacient_Visitor_Table.CurrentRow.Selected = true;
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

