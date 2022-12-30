using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class.Building;
using Portugal.City;
using Portugal.District;
using Class.CRoom;
using Class.CDoctor;
using Class.CPacient;

namespace Class.CHospital
{
    public class Hospital : ClassBase_Building
    {

        private static int idHospital = 0;
        private int idRoom = 0;
        public Hospital(string bName, string bRue, District bDistrict, City bCity, uint bNumberofFlors, uint bNumberofRoms, uint bNumberofBeds)
            : base(bRue, bDistrict, bCity, bNumberofFlors, bNumberofRoms, bNumberofBeds)
        {
            this.Name = bName;
            this.IdHospital = System.Threading.Interlocked.Increment(ref idHospital);
            this.Rooms = SetListOfRooms(bNumberofBeds);

        }


        /// <summary>
        /// Destructor of object
        /// </summary>
        ~Hospital() { }

        /// <summary>
        /// Propertie Name
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Propertie Read Only ID
        /// </summary>
        public int IdHospital { get; private set; }

        public int IdRoom { get; private set; }


        /// <summary>
        /// Propertie Read Only Rooms
        /// </summary>
        public List<Class_Room> Rooms { get; private set; }

        /// <summary>
        /// Propertie Read Only Rooms
        /// </summary>
        public List<PacientClass> Pacients { get; private set; }


        /// <summary>
        /// Propertie Read Only Doctors
        /// </summary>
        public List<Doctor> Doctors { get; private set; }


        public int GetFreeBeds()
        {
            int counterRooms = 0;

            int numberofRooms = Rooms.Count;

            for (int i = 0; i < numberofRooms; i++)
            {
                if (Rooms[i].Busy == false)
                    counterRooms++;
            }
            return counterRooms;
        }

        public void SetDoctorToHospital(Doctor doctor)
        {

            if (this.Doctors == null)
            {
                this.Doctors = new List<Doctor>();
                this.Doctors.Add(doctor);
            }
            else
            {
                this.Doctors.Add(doctor);
            }

        }

        public void SetPacientToHospital(PacientClass pacient)
        {

            if (this.Pacients == null)
            {
                this.Pacients = new List<PacientClass>();
                this.Pacients.Add(pacient);
            }
            else
            {
                this.Pacients.Add(pacient);
            }

        }


        private List<Class_Room> SetListOfRooms(uint nRooms)
        {
            List<Class_Room> rooms = new List<Class_Room>();
            for (int i = 1; i <= nRooms; i++)
            {
                this.IdRoom = System.Threading.Interlocked.Increment(ref idRoom);
                rooms.Add(new Class_Room(idRoom));
            }
            return rooms;
        }
    }
}
