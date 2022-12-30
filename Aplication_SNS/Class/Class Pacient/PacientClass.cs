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
using Class.Visitor;
using DoctorSpecialtys;

namespace Class.CPacient
{
    public class PacientClass : ClassBase_Persons
    {

        /// <summary>
        /// Overload Contructor of Pacient
        /// </summary>

        private static int idPacient = 0;

        public PacientClass(string pName, uint pAge, string pRue, District pDistrict, City pCity, string pCCNumber, ulong pCCNIF, ulong pCCSNS, ulong pccSS, string pdateOfBirth, Status pStatus , string observation, DoctorSpecialty typeIllness)
            : base(pName, pAge, pRue, pDistrict, pCity, pCCNumber, pCCNIF, pCCSNS, pccSS, pdateOfBirth)
        {

            this.Status = pStatus;
            this.Observation= observation;
            this.ID_Pacient = System.Threading.Interlocked.Increment(ref idPacient);

        }

        public PacientClass(string pName, uint pAge, string pRue, District pDistrict, City pCity, string pCCNumber, ulong pCCNIF, ulong pCCSNS, ulong pccSS, string pdateOfBirth, Status pStatus, string observation, DoctorSpecialty typeIllness,
                  Hospital hospital, Doctor doctor, Class_Room room)
                 : base(pName, pAge, pRue, pDistrict, pCity, pCCNumber, pCCNIF, pCCSNS, pccSS, pdateOfBirth)
        {

            this.Status = pStatus;
            this.Observation = observation;
            this.Hospital= hospital;
            this.Doctor= doctor;
            this.Room= room;
            this.TypeIllness= typeIllness;
            this.ID_Pacient = System.Threading.Interlocked.Increment(ref idPacient);

        }

        public PacientClass(string pName, uint pAge, string pRue, District pDistrict, City pCity, string pCCNumber, ulong pCCNIF, ulong pCCSNS, ulong pccSS, string pdateOfBirth, Status pStatus, string observation, DoctorSpecialty typeIllness,
            Hospital hospital, Doctor doctor, Class_Room room, List<VisitorClass> visitors )
            : base(pName, pAge, pRue, pDistrict, pCity, pCCNumber, pCCNIF, pCCSNS, pccSS, pdateOfBirth)
        {

            this.Status = pStatus;
            this.Observation = observation;
            this.Hospital = hospital;
            this.Doctor = doctor;
            this.Room = room;
            this.TypeIllness = typeIllness;
            this.Visitors= visitors;
            this.ID_Pacient = System.Threading.Interlocked.Increment(ref idPacient);

        }

        /// <summary>
        /// Destructor of Pacient
        /// </summary>
        ~PacientClass() { }

        public int ID_Pacient { get; set; }
        public Status Status { get; set; }

        public string Observation { get; set; }

        public Hospital Hospital { get; set; }

        public Doctor Doctor { get; set; }

        public Class_Room Room { get; set; }
        
        public DoctorSpecialty TypeIllness { get; set; }

        public List<VisitorClass> Visitors { get; set; }


        public void DeleteVisitorFromList(int idVisitor)
        {
            Visitors.RemoveAll(del => (del.ID_Visitor == idVisitor));

        }

        public void DeleteVisitorFromList(string nameVisitor)
        {
            Visitors.RemoveAll(del => (del.Name == nameVisitor));
        }

        public void InsertOneVisitorToList(VisitorClass visitors)
        {
            if (this.Visitors == null)
            {
                this.Visitors = new List<VisitorClass>();
                this.Visitors.Add(visitors);
            }
            else
            {
                this.Visitors.Add(visitors);
            }

        }


    }
}
