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

        DoctorSpecialty specialty;


        /// <summary>
        /// This variable goes to ClassBase_Persons
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pAge"></param>
        /// <param name="pCCNumber"></param>
        /// <param name="pCCNIF"></param>
        /// <param name="pCCSNS"></param>
        /// <param name="pccSS"></param>
        /// <param name="pdateOfBirth"></param>
        /// <param name="dSpecialty"></param>

        public Doctor(string pName, int pAge, string[] pCCNumber, int[] pCCNIF, int[] pCCSNS, int[] pccSS, DateTime pdateOfBirth,DoctorSpecialty dSpecialty) 
            :base(pName, pAge, pCCNumber, pCCNIF, pCCSNS,pccSS, pdateOfBirth)
        {

            specialty = dSpecialty;

        }

    

    }
}
