using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class.CHospital;
using Portugal.City;
using Portugal.District;
using Menus.FHospital;
using Class.ManagerOfData;
using Class.CDoctor;

namespace Menus.HospitalInsert
{
    public partial class Hospital_Insert : Form
    {

        List<Hospital> listofHospitalObejects;
        public Hospital_Insert()
        {
            InitializeComponent();
        }

        private void Hospital_Insert_Load(object sender, EventArgs e)
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

        }


        private void BACK_Hospital_View_Click(object sender, EventArgs e)
        {
            Hospital_Menu hospital_Menu = new Hospital_Menu();
            this.Close();
            hospital_Menu.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(
            String.IsNullOrEmpty(textBox1.Text) != true &&
            String.IsNullOrEmpty(textBox1.Text) != true &&
            comboBox1.SelectedIndex != -1 &&
            comboBox2.SelectedIndex != -1 &&
            comboBox3.SelectedIndex != -1 &&
            comboBox3.SelectedIndex != -1 &&
            comboBox4.SelectedIndex != -1 &&
            comboBox5.SelectedIndex != -1)
            {

                Hospital newInsert = new Hospital(
                    textBox1.Text,
                    textBox2.Text,
                    Enum.Parse<District>(comboBox1.GetItemText(this.comboBox1.SelectedItem)),
                    Enum.Parse<City>(comboBox2.GetItemText(this.comboBox2.SelectedItem)),
                    uint.Parse(comboBox3.SelectedItem.ToString()),
                    uint.Parse(comboBox4.SelectedItem.ToString()),
                    uint.Parse(comboBox5.SelectedItem.ToString()));

                listofHospitalObejects = Class_Manager.GetDataOfHospital();
                listofHospitalObejects.Add(newInsert);

                MessageBox.Show("HOSPITAL INSERTED", "WARNING", MessageBoxButtons.OK);


            }
            else
            MessageBox.Show("PROBLEM TO INSERT A NEW HOSPITAL, PLEASE VERIFY THE INPUTS", "ERROR", MessageBoxButtons.OK);


        }
    }

}
