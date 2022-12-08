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
using System.Windows;
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

            //foreach (DataTable sortTable in hospitalTable.Columns)
            //{
            //    sortTable.SortMode = DataGridViewColumnSortMode.NotSortable;
            //}

            List<Hospital> listofHospitalObejects;
            listofHospitalObejects = Class_Manager.GetDataOfHospital();

            foreach (var dataHospital in listofHospitalObejects)
            {
                hospitalTable.Rows.Add(dataHospital.IdHospital, dataHospital.Name, dataHospital.Rue, dataHospital.District, dataHospital.City, dataHospital.NumberOfFlors, dataHospital.NumberOfRoms, dataHospital.NumberofBeds);

            }

            Hospital_Edit_Table.DataSource = hospitalTable;
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

        private void Hospital_Edit_Edit_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("ARE YOU SURE YOU WANT TO EDIT", "WARNING", MessageBoxButtons.YesNo);

            //MessageBox.Show("HOSPITAL INSERTED", "WARNING", MessageBoxButtons.OK);

        }
    }
}
