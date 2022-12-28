using Class.CDoctor;
using Class.CPacient;
using Class.ManagerOfData;
using Portugal.City;
using Portugal.District;
using Pacient.Status;
using Menus.Pacient;
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
using System.Windows.Documents;
using Class.CRoom;

namespace Menus.PacientInsert
{
    public partial class Pacient_Insert : Form
    {
        public Pacient_Insert()
        {
            InitializeComponent();
        }

        private void Pacient_Insert_Load(object sender, EventArgs e)
        {
            foreach (District district in (District[])Enum.GetValues(typeof(District)))
                District_Combo.Items.Add(district);
            foreach (City city in (City[])Enum.GetValues(typeof(City)))
                City_Combo.Items.Add(city);
            foreach (Status status in (Status[])Enum.GetValues(typeof(Status)))
                Status_Combo.Items.Add(status);
            foreach (DoctorSpecialty disease in (DoctorSpecialty[])Enum.GetValues(typeof(DoctorSpecialty)))
                Combo_DISEASE.Items.Add(disease);


            for (int i = 1; i <= 150; i++)
            {
                Age_Combo.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<PacientClass> listofPacientObejects;

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
            String.IsNullOrEmpty(DOB_Text.Text) != true)
            {

                object[] hospitalanddoctor = new object[3];
                //int indexCounter = 0;

                SelectDistricHospitalAndDoctor(ref hospitalanddoctor);

                if (hospitalanddoctor[0] == null || hospitalanddoctor[1] == null || hospitalanddoctor[2] == null)
                {
                    SelectHospitalAndDoctor(ref hospitalanddoctor);
                    if (hospitalanddoctor[0] == null || hospitalanddoctor[1] == null || hospitalanddoctor[2] == null)
                    {
                        PacientClass newInsert = new PacientClass(
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
                                   Enum.Parse<Status>(Status_Combo.GetItemText(this.Status_Combo.SelectedItem)),
                                   OBS_Text.Text,
                                   Enum.Parse<DoctorSpecialty>(Combo_DISEASE.GetItemText(this.Combo_DISEASE.SelectedItem)));

                        listofPacientObejects = Class_Manager.GetDataOfPacient();
                        listofPacientObejects.Add(newInsert);

                        Name_Text.ResetText();
                        Age_Combo.SelectedIndex = -1;
                        Rue_Text.ResetText();
                        District_Combo.SelectedIndex = -1;
                        City_Combo.SelectedIndex = -1;
                        CCNumber_Text.ResetText();
                        NIF_Text.ResetText();
                        SNS_Text.ResetText();
                        SS_Text.ResetText();
                        DOB_Text.ResetText();
                        Status_Combo.SelectedIndex = -1;
                        Combo_DISEASE.SelectedIndex = -1;
                        OBS_Text.ResetText();
                        MessageBox.Show("NO HOSPITAL AND DOCTOR AVAILABLE\nPACIENT INSERTED AND IS IN WAITING LIST \nTRY AGAIN LATER", "WARNING", MessageBoxButtons.OK);
                        return;

                    }

                }
                else
                {
                    Hospital hospital = (Hospital)hospitalanddoctor[0];
                    Doctor doctor = (Doctor)hospitalanddoctor[1];
                    Class_Room room = (Class_Room)hospitalanddoctor[2];

                    PacientClass newInsert = new PacientClass(
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
                                       Enum.Parse<Status>(Status_Combo.GetItemText(this.Status_Combo.SelectedItem)),
                                       OBS_Text.Text,
                                       Enum.Parse<DoctorSpecialty>(Combo_DISEASE.GetItemText(this.Combo_DISEASE.SelectedItem)),
                                       hospital,
                                       doctor,
                                       room);

                    listofPacientObejects = Class_Manager.GetDataOfPacient();
                    listofPacientObejects.Add(newInsert);

                    room.Busy = true;
                    doctor.ListOfPacient.Add(newInsert);

                    MessageBox.Show("PACIENT INSERTED", "WARNING", MessageBoxButtons.OK);
                    Name_Text.ResetText();
                    Age_Combo.SelectedIndex = -1;
                    Rue_Text.ResetText();
                    District_Combo.SelectedIndex = -1;
                    City_Combo.SelectedIndex = -1;
                    CCNumber_Text.ResetText();
                    NIF_Text.ResetText();
                    SNS_Text.ResetText();
                    SS_Text.ResetText();
                    DOB_Text.ResetText();
                    Status_Combo.SelectedIndex = -1;
                    Combo_DISEASE.SelectedIndex = -1;
                    OBS_Text.ResetText();
                }
            }
            else
                MessageBox.Show("PROBLEM TO INSERT A NEW PACIENT, PLEASE VERIFY THE INPUTS", "ERROR", MessageBoxButtons.OK);

        }

        private void BACK_Hospital_View_Click(object sender, EventArgs e)
        {
            this.Close();
            Pacient_Menu pacient_Menu = new Pacient_Menu();
            pacient_Menu.Show();
        }


        private void SelectDistricHospitalAndDoctor(ref object[] list)
        {
            List<Hospital> listofHospitalObejects;

            listofHospitalObejects = Class_Manager.GetDataOfHospital();

            foreach (Hospital hospital in listofHospitalObejects)
            {
                if (hospital.District.ToString() == this.District_Combo.GetItemText(this.District_Combo.SelectedItem))
                {

                    if (hospital.GetFreeBeds() != 0)
                    {
                        list[0] = hospital;
                        foreach (Class_Room room in hospital.Rooms)
                        {
                            if (room.Busy == false)
                            {
                                list[2] = room;
                                break;
                            }
                        }
                        if (hospital.Doctors != null)
                        {
                            foreach (Doctor doctor in hospital.Doctors)
                            {
                                if (doctor.Specialty.ToString() == this.Combo_DISEASE.GetItemText(this.Combo_DISEASE.SelectedItem))
                                {
                                    list[1] = doctor;
                                    break;
                                }
                            }
                        }

                        if (list[1] is null)
                        {
                            if (hospital.Doctors != null)
                            {
                                foreach (Doctor doctor in hospital.Doctors)
                                {
                                    if (doctor.Specialty.ToString() == DoctorSpecialty.GeneralMedicine.ToString())
                                    {
                                        list[1] = doctor;
                                        break;
                                    }
                                }
                            }

                        }
                        else break;
                    }

                }

            }

            if (list[0] == null || list[1] == null || list[2] == null)
            {
                list = new object[3];
            }
        }

        private void SelectHospitalAndDoctor(ref object[] list)
        {
            List<Hospital> listofHospitalObejects;

            listofHospitalObejects = Class_Manager.GetDataOfHospital();

            foreach (Hospital hospital in listofHospitalObejects)
            {

                if (hospital.GetFreeBeds() != 0)
                {
                    list[0] = hospital;
                    if (hospital.Doctors != null)
                    {
                        foreach (Doctor doctor in hospital.Doctors)
                        {
                            if (doctor.Specialty.ToString() == this.Combo_DISEASE.GetItemText(this.Combo_DISEASE.SelectedItem))
                            {
                                list[1] = doctor;
                                break;
                            }
                        }
                    }

                    if (list[1] is null)
                    {
                        if (hospital.Doctors != null)
                        {

                            foreach (Doctor doctor in hospital.Doctors)
                            {
                                if (doctor.Specialty.ToString() == DoctorSpecialty.GeneralMedicine.ToString())
                                {
                                    list[2] = doctor;
                                    break;
                                }
                            }

                        }

                    }
                    else break;
                }

            }

            if (list[0] == null || list[1] == null || list[2] == null)
            {
                list = new object[3];
            }

        }
    }
}

