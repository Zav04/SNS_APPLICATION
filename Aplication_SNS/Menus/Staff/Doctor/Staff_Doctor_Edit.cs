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

namespace Menus.StaffDoctorEdit
{
    public partial class Staff_Doctor_Edit : Form
    {
        public Staff_Doctor_Edit()
        {
            InitializeComponent();
        }

        private void Staff_Doctor_Edit_Load(object sender, EventArgs e)
        {
            foreach (District district in (District[])Enum.GetValues(typeof(District)))
                Combo_Doctor_District_Edit.Items.Add(district);
            foreach (City city in (City[])Enum.GetValues(typeof(City)))
                Combo_Doctor_City_Edit.Items.Add(city);
            foreach (DoctorSpecialty doctorSpecialty in (DoctorSpecialty[])Enum.GetValues(typeof(DoctorSpecialty)))
                Combo_Doctor_Specialty_Edit.Items.Add(doctorSpecialty);
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

            Doctor_Edit_Table.ReadOnly = true;
            Doctor_Edit_Table.AllowUserToAddRows = false;

            List<Doctor> DoctorObjects = Get_Data_Of_Doctors();

            foreach (var dataDoctor in DoctorObjects)
            {
                doctorTable.Rows.Add(dataDoctor.ID_Doctor, dataDoctor.Name, dataDoctor.Age, dataDoctor.Rue, dataDoctor.District, dataDoctor.City, dataDoctor.CCNumber, dataDoctor.CCNIF, dataDoctor.CCSNS, dataDoctor.CCSS, dataDoctor.DateOfBirth, dataDoctor.Specialty);

            }

            Doctor_Edit_Table.DataSource = doctorTable;
        }
        private List<Doctor> Get_Data_Of_Doctors()
        {
            List<Doctor> listofDoctorObejects;
            listofDoctorObejects = Class_Manager.GetDataOfDoctors();
            return listofDoctorObejects;

        }

        private void Doctor_Edit_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Doctor_Edit_Table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Doctor_Edit_Table.CurrentRow.Selected = true;

                Text_Doctor_Name_Edit.Text = Doctor_Edit_Table.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                Text_Doctor_Age_Edit.Text = Doctor_Edit_Table.Rows[e.RowIndex].Cells["Age"].FormattedValue.ToString();
                Text_Doctor_Rue_Edit.Text = Doctor_Edit_Table.Rows[e.RowIndex].Cells["Rue"].FormattedValue.ToString();
                Combo_Doctor_District_Edit.SelectedIndex = (int)Enum.Parse<District>(Doctor_Edit_Table.Rows[e.RowIndex].Cells["District"].FormattedValue.ToString());
                Combo_Doctor_City_Edit.SelectedIndex = (int)Enum.Parse<City>(Doctor_Edit_Table.Rows[e.RowIndex].Cells["City"].FormattedValue.ToString());
                Text_Doctor_CCNumber_Edit.Text = Doctor_Edit_Table.Rows[e.RowIndex].Cells["CC Number"].FormattedValue.ToString();
                Text_Doctor_CCNIF_Edit.Text = Doctor_Edit_Table.Rows[e.RowIndex].Cells["CC NIF"].FormattedValue.ToString();
                Text_Doctor_CCSNS_Edit.Text = Doctor_Edit_Table.Rows[e.RowIndex].Cells["CC SNS"].FormattedValue.ToString();
                Text_Doctor_CCSS_Edit.Text = Doctor_Edit_Table.Rows[e.RowIndex].Cells["CC SS"].FormattedValue.ToString();
                Text_Doctor_DOB_Edit.Text = Doctor_Edit_Table.Rows[e.RowIndex].Cells["Date of Birth"].FormattedValue.ToString();
                Combo_Doctor_Specialty_Edit.SelectedIndex = (int)Enum.Parse<DoctorSpecialty>(Doctor_Edit_Table.Rows[e.RowIndex].Cells["Specialty"].FormattedValue.ToString());

            }

        }


        private List<String> GetRowFromListInTableDoctor()
        {

            List<String> getDataFromRow = new List<string>();

            foreach (DataGridViewRow row in Doctor_Edit_Table.SelectedRows)
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
            if (Doctor_Edit_Table.SelectedRows.Count > 0)
            {
                DialogResult getDialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO EDIT", "WARNING", MessageBoxButtons.YesNo);
                if (getDialogResult == DialogResult.Yes)
                {
                    List<String> getDataFromRow = GetRowFromListInTableDoctor();
                    int getId = int.Parse(getDataFromRow[0]);

                    List<Doctor> DoctorObjects = Get_Data_Of_Doctors();

                    foreach (Doctor objects in DoctorObjects)
                    {
                        if (objects.ID_Doctor == getId)
                        {
                            objects.Name = Text_Doctor_Name_Edit.Text;
                            objects.Age = uint.Parse(Text_Doctor_Age_Edit.Text);
                            objects.Rue = Text_Doctor_Rue_Edit.Text;
                            objects.District = Enum.Parse<District>(Combo_Doctor_District_Edit.GetItemText(this.Combo_Doctor_District_Edit.SelectedItem));
                            objects.City = Enum.Parse<City>(Combo_Doctor_City_Edit.GetItemText(this.Combo_Doctor_City_Edit.SelectedItem));
                            objects.CCNumber = Text_Doctor_CCNumber_Edit.Text;
                            objects.CCNIF = ulong.Parse(Text_Doctor_CCNIF_Edit.Text);
                            objects.CCSNS = ulong.Parse(Text_Doctor_CCSNS_Edit.Text);
                            objects.CCSS = ulong.Parse(Text_Doctor_CCSS_Edit.Text);
                            objects.DateOfBirth = Text_Doctor_DOB_Edit.Text;
                            objects.Specialty = Enum.Parse<DoctorSpecialty>(Combo_Doctor_Specialty_Edit.GetItemText(this.Combo_Doctor_Specialty_Edit.SelectedItem));
                            LoadDataToDataGridDoctor();
                            break;

                        }

                    }

                }
            }
            else
                MessageBox.Show("SELECT A LINE TO EDIT A DOCTOR FROM APLICATION", "WARNING", MessageBoxButtons.OK);

        }

        private void Back_Hospital_Edit_Click(object sender, EventArgs e)
        {
            this.Close();
            Staff_Doctor staff_Doctor = new Staff_Doctor();
            staff_Doctor.Show();
        }
    }
}
