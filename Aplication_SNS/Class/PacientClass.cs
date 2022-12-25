using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class.CPerson;
using Portugal.District;
using Portugal.City;
using Class.CHospital;
using Class.CRoom;
using Class.CDoctor;

namespace Class.CPacient
{
    public class PacientClass : ClassBase_Persons 
    {

        /// <summary>
        /// Contrcutor of Nurse
        /// </summary>

        public PacientClass(string pName, uint pAge, string pRue, District pDistrict, City pCity, string pCCNumber, uint pCCNIF, uint pCCSNS, uint pccSS, string pdateOfBirth,
            Hospital hospital, Doctor doctor, Class_Room room, DoctorSpecialty typeIllness)
            : base(pName, pAge, pRue, pDistrict, pCity, pCCNumber, pCCNIF, pCCSNS, pccSS, pdateOfBirth)
        {

            //this.Specialty = dSpecialty;

        }
        ~PacientClass() { }



    }
}
