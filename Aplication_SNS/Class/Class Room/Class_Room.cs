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

 
        public Class_Room(int idRoom,bool busy=false)
        {
            this.Id=idRoom;
            this.Busy = busy;

        }

        ~Class_Room() { }

        public int Id { get; set; }

        public bool Busy { get; set; }

    }



}
