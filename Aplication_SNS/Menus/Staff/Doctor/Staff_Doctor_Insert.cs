using Class.ManagerOfData;
using Menus.StaffDoctor;
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
using Class.CHospital;
using Class.CDoctor;



namespace Menus.StaffDoctor
{
    public partial class Staff_Doctor_Insert : Form
    {
        public Staff_Doctor_Insert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //if (
            //String.IsNullOrEmpty(textBox1.Text) != true &&
            //String.IsNullOrEmpty(textBox1.Text) != true &&
            //comboBox1.SelectedIndex != -1 &&
            //comboBox2.SelectedIndex != -1 &&
            //comboBox3.SelectedIndex != -1 &&
            //comboBox3.SelectedIndex != -1 &&
            //comboBox4.SelectedIndex != -1 &&
            //comboBox5.SelectedIndex != -1)
            //{

            //    Hospital newInsert = new Hospital(
            //        textBox1.Text,
            //        textBox2.Text,
            //        Enum.Parse<District>(comboBox1.GetItemText(this.comboBox1.SelectedItem)),
            //        Enum.Parse<City>(comboBox2.GetItemText(this.comboBox2.SelectedItem)),
            //        uint.Parse(comboBox3.SelectedItem.ToString()),
            //        uint.Parse(comboBox4.SelectedItem.ToString()),
            //        uint.Parse(comboBox5.SelectedItem.ToString()));

            //    listofHospitalObejects = Class_Manager.GetDataOfHospital();
            //    listofHospitalObejects.Add(newInsert);

            //    MessageBox.Show("HOSPITAL INSERTED", "WARNING", MessageBoxButtons.OK);


            //}
            //else
            //    MessageBox.Show("PROBLEM TO INSERT A NEW HOSPITAL, PLEASE VERIFY THE INPUTS", "ERROR", MessageBoxButtons.OK);

        }

        private void Staff_Doctor_Insert_Load(object sender, EventArgs e)
        {

            {
                foreach (District district in (District[])Enum.GetValues(typeof(District)))
                    District_Combo.Items.Add(district);
                foreach (City city in (City[])Enum.GetValues(typeof(City)))
                    City_Combo.Items.Add(city);
                foreach (DoctorSpecialty doctorSpecialty in (DoctorSpecialty[])Enum.GetValues(typeof(DoctorSpecialty)))
                    Specialty_Combo.Items.Add(doctorSpecialty);

                for (int i = 1; i <= 100; i++)
                {
                    Age_Combo.Items.Add(i);
                }

                Work_Combo.Items.Add("Not Hired");

                List<Hospital> listofDcotorObejects = Get_Data_Of_Hospital();
                foreach (Hospital hospital in listofDcotorObejects)
                {
                    Work_Combo.Items.Add(hospital.Name);
                }


            }
        }

        private List<Hospital> Get_Data_Of_Hospital()
        {
            List<Hospital> listofHospitalObejects;
            listofHospitalObejects = Class_Manager.GetDataOfHospital();
            return listofHospitalObejects;

        }

        private void BACK_Hospital_View_Click(object sender, EventArgs e)
        {
            this.Close();
            Staff_Doctor newStaffDoctor = new Staff_Doctor();
            newStaffDoctor.Show();
        }
    }
}
