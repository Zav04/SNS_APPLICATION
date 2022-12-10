using Class.CHospital;
using Class.ManagerOfData;
using Menus.FHospital;
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

namespace Menus.HospitalEdit
{
    public partial class Hospital_Edit : Form
    {
        public Hospital_Edit()
        {
            InitializeComponent();
        }

        private void Hospital_Edit_Load(object sender, EventArgs e)
        {
            foreach (District district in (District[])Enum.GetValues(typeof(District)))
                comboBox1.Items.Add(district);
            foreach (City city in (City[])Enum.GetValues(typeof(City)))
                comboBox2.Items.Add(city);
            for (int i = 1; i <= 100; i++)
            {
                comboBox3.Items.Add(i);
                comboBox4.Items.Add(i);
                comboBox5.Items.Add(i);
            }

            LoadDataToDataGrid();


        }


        private void LoadDataToDataGrid()
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
            Hospital_Edit_Table.ReadOnly = true;
            Hospital_Edit_Table.AllowUserToAddRows = false;

            List<Hospital> hospiatlObjects = Get_Data_Of_Hospital();

            foreach (var dataHospital in hospiatlObjects)
            {
                hospitalTable.Rows.Add(dataHospital.IdHospital, dataHospital.Name, dataHospital.Rue, dataHospital.District, dataHospital.City, dataHospital.NumberOfFlors, dataHospital.NumberOfRoms, dataHospital.NumberofBeds);

            }

            Hospital_Edit_Table.DataSource = hospitalTable;
        }
        private List<Hospital> Get_Data_Of_Hospital()
        {
            List<Hospital> listofHospitalObejects;
            listofHospitalObejects = Class_Manager.GetDataOfHospital();
            return listofHospitalObejects;

        }

        private void Back_Hospital_Edit_Click(object sender, EventArgs e)
        {
            this.Close();
            Hospital_Menu hospital_Menu = new Hospital_Menu();
            hospital_Menu.Show();
        }

        private void Hospital_Edit_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Hospital_Edit_Table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Hospital_Edit_Table.CurrentRow.Selected = true;
                textBox1.Text = Hospital_Edit_Table.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                textBox2.Text = Hospital_Edit_Table.Rows[e.RowIndex].Cells["Rue"].FormattedValue.ToString();

                comboBox1.SelectedIndex = (int)Enum.Parse<District>(Hospital_Edit_Table.Rows[e.RowIndex].Cells["District"].FormattedValue.ToString());
                comboBox2.SelectedIndex = (int)Enum.Parse<City>(Hospital_Edit_Table.Rows[e.RowIndex].Cells["City"].FormattedValue.ToString());
                comboBox3.SelectedIndex = int.Parse(Hospital_Edit_Table.Rows[e.RowIndex].Cells["Number of Flors"].FormattedValue.ToString());
                comboBox4.SelectedIndex = int.Parse(Hospital_Edit_Table.Rows[e.RowIndex].Cells["Number of Rooms"].FormattedValue.ToString());
                comboBox5.SelectedIndex = int.Parse(Hospital_Edit_Table.Rows[e.RowIndex].Cells["Number of Beds"].FormattedValue.ToString());
            }



        }

        private List<String> GetRowFromList()
        {

            List<String> getDataFromRow = new List<string>();

            foreach (DataGridViewRow row in Hospital_Edit_Table.SelectedRows)
            {
                getDataFromRow.Add(row.Cells[0].Value.ToString());
                getDataFromRow.Add(row.Cells[1].Value.ToString());
                getDataFromRow.Add(row.Cells[2].Value.ToString());
                getDataFromRow.Add(row.Cells[3].Value.ToString());
                getDataFromRow.Add(row.Cells[4].Value.ToString());
                getDataFromRow.Add(row.Cells[5].Value.ToString());
                getDataFromRow.Add(row.Cells[6].Value.ToString());
                getDataFromRow.Add(row.Cells[7].Value.ToString());

            }
            return getDataFromRow;
        }

        private void Hospital_Edit_Edit_Click(object sender, EventArgs e)
        {
            if (Hospital_Edit_Table.SelectedRows.Count > 0)
            {
                DialogResult getDialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO EDIT", "WARNING", MessageBoxButtons.YesNo);
                if (getDialogResult == DialogResult.Yes)
                {
                    List<String> getDataFromRow = GetRowFromList();
                    int getId = int.Parse(getDataFromRow[0]);

                    List<Hospital> hospiatlObjects = Get_Data_Of_Hospital();

                    foreach (var objects in hospiatlObjects)
                    {
                        if (objects.IdHospital == getId)
                        {
                            objects.Name = textBox1.Text;
                            objects.Rue = textBox2.Text;
                            objects.District = Enum.Parse<District>(comboBox1.GetItemText(this.comboBox1.SelectedItem));
                            objects.City = Enum.Parse<City>(comboBox2.GetItemText(this.comboBox2.SelectedItem));
                            objects.NumberOfFlors = uint.Parse(comboBox3.SelectedItem.ToString());
                            objects.NumberOfRoms = uint.Parse(comboBox4.SelectedItem.ToString());
                            objects.NumberofBeds = uint.Parse(comboBox5.SelectedItem.ToString());
                            LoadDataToDataGrid();
                            break;
                        }

                    }

                }
            }
            else
                MessageBox.Show("SELECT A LINE TO EDIT A HOSPITAL FROM APLICATION", "WARNING", MessageBoxButtons.OK);

        }
    }
}
