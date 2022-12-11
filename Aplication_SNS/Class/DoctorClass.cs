using System;
using System.Windows.Controls;
using Class.CPerson;
using Portugal.District;
using Portugal.City;
using Class.CHospital;

namespace Class.CDoctor
{

    public enum DoctorSpecialty
    {
        Cardiologist,GeneralMedicine, Orthopedics, Pediatrician,
        Otolaryngologist, Dermatology, Oncology, Psychiatry, Neurology

    }


    public class Doctor : ClassBase_Persons
    {

        private static int idDoctor = 0;

        public Doctor(string pName, uint pAge,string pRue, District pDistrict, City pCity, string pCCNumber, ulong pCCNIF, ulong pCCSNS, ulong pccSS, string pdateOfBirth,DoctorSpecialty dSpecialty) 
                      :base(pName, pAge, pRue, pDistrict, pCity,pCCNumber, pCCNIF, pCCSNS,pccSS, pdateOfBirth)
        {

            this.Specialty = dSpecialty;
            this.ID_Doctor = System.Threading.Interlocked.Increment(ref idDoctor);

        }
        public Doctor(string pName, uint pAge, string pRue, District pDistrict, City pCity, string pCCNumber, ulong pCCNIF, ulong pCCSNS, ulong pccSS, string pdateOfBirth, DoctorSpecialty dSpecialty, ref Hospital dhospital)
              : base(pName, pAge, pRue, pDistrict, pCity, pCCNumber, pCCNIF, pCCSNS, pccSS, pdateOfBirth)
        {

            this.Specialty = dSpecialty;
            this.Hospital = dhospital;
            this.ID_Doctor = System.Threading.Interlocked.Increment(ref idDoctor);

        }
        ~Doctor(){ }


        /// <summary>
        /// Specialty of doctor
        /// The other variables are from class base
        /// </summary>
        public DoctorSpecialty Specialty { get; set; }


        /// <summary>
        /// Get working Hospital
        /// The other variables are from class base
        /// </summary>
        public Hospital Hospital { get; private set; }


        /// <summary>
        /// Get Id From Doctor
        /// The other variables are from class base
        /// </summary>
        public int ID_Doctor { get; set; }


        public void SetHospital(Hospital hospital) { this.Hospital = hospital; }



    }
}
