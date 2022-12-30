using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class.CPerson;
using Portugal.District;
using Portugal.City;

namespace Class.CNurse
{
    public class NurseClass : ClassBase_Persons
    {

        /// <summary>
        /// Contrcutor of Nurse
        /// </summary>

        public NurseClass(string pName, uint pAge, string pRue, District pDistrict, City pCity, string pCCNumber, uint pCCNIF, uint pCCSNS, uint pccSS, string pdateOfBirth)
            : base(pName, pAge, pRue, pDistrict, pCity, pCCNumber, pCCNIF, pCCSNS, pccSS, pdateOfBirth)
        {

            //this.Specialty = dSpecialty;

        }
        ~NurseClass() { }





    }
}

