using Class.CHospital;
using Portugal.City;
using Portugal.District;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class.CPacient;

namespace Class.CRoom
{
    public class Class_Room
    {

        private static int idRoom = 0;
        public Class_Room(int idHospital,bool busy=false)
        {
            this.Id = System.Threading.Interlocked.Increment(ref idRoom);
            this.IdHospital = idHospital;
            this.Busy = busy;

        }

        public Class_Room(int idHospital, PacientClass pacient, bool busy = false)
        {
            this.Id = System.Threading.Interlocked.Increment(ref idRoom);
            this.IdHospital = idHospital;
            this.Pacient = pacient;
            this.Busy = busy;

        }

        ~Class_Room() { }

        public int Id { get; set; }

        public bool Busy { get; set; }

        public int IdHospital { get; set; }

        public PacientClass Pacient { get; private set; }


    }



}
