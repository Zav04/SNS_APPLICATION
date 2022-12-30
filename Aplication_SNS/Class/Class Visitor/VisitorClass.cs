using Class.CPerson;
using Portugal.District;
using Portugal.City;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.DegreeOfKinship;
using Class.CDoctor;

namespace Class
{
    public class VisitorClass: ClassBase_Persons
    {

        private static int idVisitor = 0;

        public VisitorClass(string pName, uint pAge, string pRue, District pDistrict, City pCity, string pCCNumber, ulong pCCNIF, ulong pCCSNS, ulong pCCSS, string pdateOfBirth, DegreeOfKinship degree)
            : base(pName, pAge, pRue, pDistrict, pCity, pCCNumber, pCCNIF, pCCSNS, pCCSS, pdateOfBirth)
        {
            this.Degree= degree;
            this.ID_Visitor = System.Threading.Interlocked.Increment(ref idVisitor);
        }

        public int ID_Visitor { get; set; }
        public DegreeOfKinship Degree { get; set; }

    }
}
