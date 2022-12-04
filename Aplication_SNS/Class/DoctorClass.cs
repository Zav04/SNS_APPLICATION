using System;
using System.Windows.Controls;
using Class.CPerson;
using Portugal.District;
using Portugal.City;

namespace Class.CDoctor
{

    public enum DoctorSpecialty
    {
        Cardiologist,GeneralMedicine, Orthopedics, Pediatrician,
        Otolaryngologist, Dermatology, Oncology, Psychiatry, Neurology

    }


    public class Doctor : ClassBase_Persons
    {

       //private DoctorSpecialty specialty;

        public Doctor(string pName, uint pAge,string pRue, District pDistrict, City pCity, string pCCNumber, uint pCCNIF, uint pCCSNS, uint pccSS, string pdateOfBirth,DoctorSpecialty dSpecialty) 
            :base(pName, pAge, pRue, pDistrict, pCity,pCCNumber, pCCNIF, pCCSNS,pccSS, pdateOfBirth)
        {

            this.Specialty = dSpecialty;

        }
        ~Doctor(){ }


        /// <summary>
        /// Specialty of doctor
        /// The other variables are from class base
        /// </summary>
        public DoctorSpecialty Specialty { get; set; }
 


    }
}
