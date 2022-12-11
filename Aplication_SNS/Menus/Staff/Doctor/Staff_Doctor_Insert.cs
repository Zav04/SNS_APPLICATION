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
using Menus.StaffDoctor;



namespace Menus.StaffDoctorInsert
{
    public partial class Staff_Doctor_Insert : Form
    {
        public Staff_Doctor_Insert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Doctor> listofDoctorObejects;
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
            Specialty_Combo.SelectedIndex != -1)
            {

                    Doctor newInsert = new Doctor(
                                        Name_Text.Text,
                                        uint.Parse(Age_Combo.SelectedItem.ToString()),
                                        Rue_Text.Text,
                                        Enum.Parse<District>(District_Combo.GetItemText(this.District_Combo.SelectedItem)),
                                        Enum.Parse<City>(City_Combo.GetItemText(this.City_Combo.SelectedItem)),
                                        CCNumber_Text.Text,
                                        ulong.Parse(NIF_Text.Text),
                                        ulong.Parse(SNS_Text.Text),
                                        ulong.Parse(SS_Text.Text),
                                        DOB_Text.Text,
                                        Enum.Parse<DoctorSpecialty>(Specialty_Combo.GetItemText(this.Specialty_Combo.SelectedItem)));



                listofDoctorObejects = Class_Manager.GetDataOfDoctors();
                listofDoctorObejects.Add(newInsert);

                MessageBox.Show("DOCTOR INSERTED", "WARNING", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("PROBLEM TO INSERT A NEW DOCTOR, PLEASE VERIFY THE INPUTS", "ERROR", MessageBoxButtons.OK);

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

            }
        }

        private void BACK_Hospital_View_Click(object sender, EventArgs e)
        {
            this.Close();
            Staff_Doctor newStaffDoctor = new Staff_Doctor();
            newStaffDoctor.Show();
        }
    }
}
