using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Class
{
    public class PacientClass : ClassBase_Persons 
    {

        /// <summary>
        /// Contrcutor of Nurse
        /// </summary>

        public PacientClass(string pName, int pAge, string pRue, string pCCNumber, int pCCNIF, int pCCSNS, int pccSS, string pdateOfBirth, Doctor teste)
            : base(pName, pAge, pRue, pCCNumber, pCCNIF, pCCSNS, pccSS, pdateOfBirth)
        {

            //this.Specialty = dSpecialty;

        }
        ~PacientClass() { }



    }
}
