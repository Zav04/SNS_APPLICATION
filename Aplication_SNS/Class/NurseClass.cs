using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class NurseClass : ClassBase_Persons
    {

        /// <summary>
        /// Contrcutor of Nurse
        /// </summary>

        public NurseClass(string pName, uint pAge, string pRue, string pCCNumber, uint pCCNIF, uint pCCSNS, uint pccSS, string pdateOfBirth)
            : base(pName, pAge, pRue, pCCNumber, pCCNIF, pCCSNS, pccSS, pdateOfBirth)
        {

            //this.Specialty = dSpecialty;

        }
        ~NurseClass() { }





    }
}

