using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class.ManagerOfData;
using Menus.Log;
using Class.ManagerOfData;

namespace LoadAplication
{
    public partial class LoadAplication : Form
    {
        public LoadAplication()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            label1.Visible = true;
            button1.Visible = false;
            button2.Visible=false;
            Class_Manager.ReadDataOfDoctors();
            Class_Manager.ReadDataOfNurse();
            Class_Manager.ReadDataOfPacient();
            Class_Manager.ReadDataOfHospital();
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);

            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                Login newFormLogin = new Login();
                newFormLogin.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void LoadAplication_Load(object sender, EventArgs e)
        {
            //List<Doctor> AuthorList = new List<Doctor>();
            //for (int i = 0; i < 10; i++)
            //{
            //    dynamic newdoct = new Doctor("Bruno", 23, "RUA Ouvinho Favelhos", "30038825ZY0", 271251350, 0124567897, 156354321, "06/06/1999", DoctorSpecialty.Cardiologist);

            //    AuthorList.Add(newdoct);
                
            //}
           
            //Doctor newdoct = new Doctor("Bruno", 23, "RUA Ouvinho Favelhos", "30038825ZY0", 271251350, 0124567897, 156354321, "06/06/1999", DoctorSpecialty.Cardiologist);

            //string name= newdoct.Name;
            //int teste = newdoct.Age;
            //string rue = newdoct.Rue;
            //string cc = newdoct.CCNumber;
            //int teste2 = newdoct.CCNIF;
            //int teste3 = newdoct.CCSNS;
            //int teste4 = newdoct.CCSS;
            //string date = newdoct.DateOfBirth;
            //DoctorSpecialty teste14 = newdoct.Specialty;
        }



    }
}
