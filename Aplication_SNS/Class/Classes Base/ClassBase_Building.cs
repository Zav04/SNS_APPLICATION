﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portugal.City;
using Portugal.District;

namespace Class.Building
{
    public class ClassBase_Building
    {

        public ClassBase_Building(string bRue, District bDistrict, City bCity, uint bNumberofFlors, uint bNumberofRoms, uint bNumberofBeds)
        {
            this.Rue = bRue;
            this.District = bDistrict;
            this.City = bCity;
            this.NumberOfFlors = bNumberofFlors;
            this.NumberOfRoms = bNumberofRoms;
            this.NumberOfFlors = bNumberofFlors;
            this.NumberofBeds= bNumberofBeds; 
        }


        /// <summary>
        /// Destructor of object
        /// </summary>
        ~ClassBase_Building() { }

        /// <summary>
        /// Propertie Rue
        /// </summary>
        public string Rue { get; set; }

        /// <summary>
        /// Propertie Rue
        /// </summary>
        public District District { get; set; }

        /// <summary>
        /// Propertie Rue
        /// </summary>
        public City City { get; set; }

        /// <summary>
        /// Propertie Number of floor of a Building
        /// </summary>
        public uint NumberOfFlors { get; set; }

        /// <summary>
        /// Propertie Number of Rooms in a Building
        /// </summary>
        public uint NumberOfRoms { get; set; }

        /// <summary>
        /// Propertie Number of beds in a Building
        /// </summary>
        public uint NumberofBeds { get; set; }

       



    }
}
