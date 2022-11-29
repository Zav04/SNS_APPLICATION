using System;
using System.Windows.Controls;

namespace Class
{

    public enum DoctorSpecialty
    {
        Cardiologist,GeneralMedicine, Orthopedics, Pediatrician,
        Otolaryngologist, Dermatology, Oncology, Psychiatry, Neurology

    }


    public class Doctor : ClassBase_Persons
    {

       //private DoctorSpecialty specialty;

        public Doctor(string pName, int pAge,string pRue, string pCCNumber, int pCCNIF, int pCCSNS, int pccSS, string pdateOfBirth,DoctorSpecialty dSpecialty) 
            :base(pName, pAge, pRue, pCCNumber, pCCNIF, pCCSNS,pccSS, pdateOfBirth)
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
