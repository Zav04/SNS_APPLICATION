using Class.CDoctor;
using Class.ManagerOfData;
using Menus.StaffDoctor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoctorSpecialtys;



namespace Menus.StaffDoctorView
{
    public partial class Staff_Doctor_View : Form
    {
        public Staff_Doctor_View()
        {
            InitializeComponent();
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
            doctorTable.Columns.Add("Hospital", typeof(string));


            Doctor_View_Table.ReadOnly = true;
            Doctor_View_Table.AllowUserToAddRows = false;

            List<Doctor> DoctorObjects = Get_Data_Of_Doctors();

            foreach (var dataDoctor in DoctorObjects)
            {
                if (dataDoctor.Hospital != null)
                    doctorTable.Rows.Add(dataDoctor.ID_Doctor, dataDoctor.Name, dataDoctor.Age, dataDoctor.Rue, dataDoctor.District, dataDoctor.City, dataDoctor.CCNumber, dataDoctor.CCNIF, dataDoctor.CCSNS, dataDoctor.CCSS, dataDoctor.DateOfBirth, dataDoctor.Specialty, dataDoctor.Hospital.Name);
                else
                    doctorTable.Rows.Add(dataDoctor.ID_Doctor, dataDoctor.Name, dataDoctor.Age, dataDoctor.Rue, dataDoctor.District, dataDoctor.City, dataDoctor.CCNumber, dataDoctor.CCNIF, dataDoctor.CCSNS, dataDoctor.CCSS, dataDoctor.DateOfBirth, dataDoctor.Specialty, "Not Working");

            }

            Doctor_View_Table.DataSource = doctorTable;
        }
        private List<Doctor> Get_Data_Of_Doctors()
        {
            List<Doctor> listofDoctorObejects;
            listofDoctorObejects = Class_Manager.GetDataOfDoctors();
            return listofDoctorObejects;

        }

        private void Staff_Doctor_View_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridDoctor();
        }

        private void Back_Doctor_View_Click(object sender, EventArgs e)
        {
            this.Close();
            Staff_Doctor staff_Doctor = new Staff_Doctor();
            staff_Doctor.Show();
        }
    }
}
