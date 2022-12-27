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
using Pacient.Status;

namespace Class.CPacient
{
    public class PacientClass : ClassBase_Persons
    {

        /// <summary>
        /// Overload Contructor of Pacient
        /// </summary>

        public PacientClass(string pName, uint pAge, string pRue, District pDistrict, City pCity, string pCCNumber, uint pCCNIF, uint pCCSNS, uint pccSS, string pdateOfBirth, Status pStatus)
            : base(pName, pAge, pRue, pDistrict, pCity, pCCNumber, pCCNIF, pCCSNS, pccSS, pdateOfBirth)
        {

            this.Status = pStatus;

        }

        public PacientClass(string pName, uint pAge, string pRue, District pDistrict, City pCity, string pCCNumber, uint pCCNIF, uint pCCSNS, uint pccSS, string pdateOfBirth, Status pStatus,
                  Hospital hospital, Doctor doctor, Class_Room room, DoctorSpecialty typeIllness)
                 : base(pName, pAge, pRue, pDistrict, pCity, pCCNumber, pCCNIF, pCCSNS, pccSS, pdateOfBirth)
        {

            this.Status = pStatus;
            this.Hospital= hospital;
            this.Doctor= doctor;
            this.Room= room;
            this.TypeIllness= typeIllness;

        }

        public PacientClass(string pName, uint pAge, string pRue, District pDistrict, City pCity, string pCCNumber, uint pCCNIF, uint pCCSNS, uint pccSS, string pdateOfBirth, Status pStatus,
            Hospital hospital, Doctor doctor, Class_Room room, DoctorSpecialty typeIllness, List<VisitorClass> visitors )
            : base(pName, pAge, pRue, pDistrict, pCity, pCCNumber, pCCNIF, pCCSNS, pccSS, pdateOfBirth)
        {

            this.Status = pStatus;
            this.Hospital = hospital;
            this.Doctor = doctor;
            this.Room = room;
            this.TypeIllness = typeIllness;
            this.Visitors= visitors;

        }
        /// <summary>
        /// Destructor of Pacient
        /// </summary>
        ~PacientClass() { }


        public Status Status { get; set; }

        public Hospital Hospital { get; set; }

        public Doctor Doctor { get; set; }

        public Class_Room Room { get; set; }
        
        public DoctorSpecialty TypeIllness { get; set; }

        public List<VisitorClass> Visitors { get; set; }

        public List<VisitorClass> GetVisitorList()
        {
            List<VisitorClass> visitors= new List<VisitorClass>();
            return visitors;
        }

        public void SetVisitorList(List<VisitorClass> visitors)
        {
            this.Visitors = visitors;
        }

        public void DeleteVisitorFromList(int idVisitor)
        {
            Visitors.RemoveAll(del => (del.ID_Visitor == idVisitor));

        }

        public void InsertOneVisitorList(VisitorClass visitors)
        {
            Visitors.Add(visitors);
        }


    }
}
