﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class.Building;
using Portugal.City;
using Portugal.District;
using Class.CRoom;


namespace Class.CHospital
{
    public class Hospital : ClassBase_Building
    {

        private static int idHospital = 0;
        public Hospital(string bName, string bRue, District bDistrict, City bCity, uint bNumberofFlors, uint bNumberofRoms, uint bNumberofBeds) 
            : base(bRue, bDistrict, bCity,bNumberofFlors, bNumberofRoms, bNumberofBeds)
        {
            this.Name = bName;
            this.IdHospital= System.Threading.Interlocked.Increment(ref idHospital);
            this.Rooms=SetListOfRooms(bNumberofBeds);

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


        /// <summary>
        /// Propertie Read Only Rooms
        /// </summary>
        public List<Class_Room> Rooms { get; private set; }


        public uint GetFreeBeds()
        {
            uint counterRooms = 0;

            int numberofRooms = Rooms.Count;

            for (int i = 0; i < numberofRooms; i++)
            {
                if (Rooms[i].Busy == false)
                    counterRooms++;
            }
            return counterRooms;
        }


        private List<Class_Room> SetListOfRooms(uint nRooms)
        {
            List <Class_Room> rooms= new List <Class_Room>();
            for (int i = 0; i < nRooms; i++)
                rooms.Add(new Class_Room(this.IdHospital));
            return rooms;
        }
    }
}
