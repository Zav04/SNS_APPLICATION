using Class.CPacient;
using Class.ManagerOfData;
using Class.Visitor;
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
using Class.CHospital;
using Menus.Reception;


namespace Menus.ReceptionStats
{
    public partial class Reception_Statistics : Form
    {
        public Reception_Statistics()
        {
            InitializeComponent();
        }

        private void BACK_Reception_Menu_Click(object sender, EventArgs e)
        {

            this.Close();
            Reception_Menu reception_Menu= new Reception_Menu();
            reception_Menu.Show();

        }



        private void Reception_Statistics_Load(object sender, EventArgs e)
        {
            DataTable recepctionStatsTable = new DataTable();
            recepctionStatsTable.Columns.Add("Name of Hospital", typeof(string));
            recepctionStatsTable.Columns.Add("Number of beds", typeof(uint));
            recepctionStatsTable.Columns.Add("Number of available beds", typeof(uint));
            recepctionStatsTable.Columns.Add("Numbers of people hospitalized", typeof(uint));
            recepctionStatsTable.Columns.Add("Number of People with Cardiologist", typeof(uint));
            recepctionStatsTable.Columns.Add("Number of People with GeneralMedicine", typeof(uint));
            recepctionStatsTable.Columns.Add("Number of People with Orthopedics", typeof(uint));
            recepctionStatsTable.Columns.Add("Number of People with Pediatrician", typeof(uint));
            recepctionStatsTable.Columns.Add("Number of People with Otolaryngologist", typeof(uint));
            recepctionStatsTable.Columns.Add("Number of People with Dermatology", typeof(uint));
            recepctionStatsTable.Columns.Add("Number of People with Oncology", typeof(uint));
            recepctionStatsTable.Columns.Add("Number of People with Psychiatry", typeof(uint));
            recepctionStatsTable.Columns.Add("Number of People with Neurology", typeof(uint));

            Recption_Stats.ReadOnly = true;
            Recption_Stats.AllowUserToAddRows = false;

            string sHospital;
            uint nBeds = 0, aBeds = 0, nPH = 0, nPC = 0, nPGM = 0, nPO = 0, nPP = 0, nPOT = 0, nPD = 0, nPON = 0, nPPSY = 0, nPN = 0;

            List<Hospital> objectHospitals = Class_Manager.GetDataOfHospital();

            foreach (Hospital hospital in objectHospitals)
            {
                sHospital = hospital.Name;
                nBeds = hospital.NumberofBeds;
                aBeds = (uint)hospital.GetFreeBeds();

                if (hospital.Pacients != null)
                    nPH = (uint)hospital.Pacients.Count();
                else
                    nPH = 0;

                if (hospital.Pacients != null)
                {
                    foreach (PacientClass pacients in hospital.Pacients)
                    {
                        switch (pacients.TypeIllness)
                        {
                            case DoctorSpecialty.Cardiologist:
                                nPC++;
                                break;
                            case DoctorSpecialty.GeneralMedicine:
                                nPGM++;
                                break;
                            case DoctorSpecialty.Orthopedics:
                                nPO++;
                                break;
                            case DoctorSpecialty.Pediatrician:
                                nPP++;
                                break;
                            case DoctorSpecialty.Otolaryngologist:
                                nPOT++;
                                break;
                            case DoctorSpecialty.Dermatology:
                                nPD++;
                                break;
                            case DoctorSpecialty.Oncology:
                                nPON++;
                                break;
                            case DoctorSpecialty.Psychiatry:
                                nPPSY++;
                                break;
                            case DoctorSpecialty.Neurology:
                                nPN++;
                                break;
                            default:
                                break;
                        }
                    }
                }

                recepctionStatsTable.Rows.Add(sHospital, nBeds, aBeds, nPH, nPC, nPGM, nPO, nPP, nPOT, nPD, nPON, nPPSY, nPN);
                    sHospital = "";
                    nBeds = 0; aBeds = 0; nPH = 0; nPC = 0; nPGM = 0; nPO = 0; nPP = 0; nPOT = 0; nPD = 0; nPON = 0; nPPSY = 0; nPN = 0;
                
            }

            Recption_Stats.DataSource = recepctionStatsTable;

        }
    }
}
